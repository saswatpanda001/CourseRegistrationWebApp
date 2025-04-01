using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseManagementWebApp.Models;
using CourseManagementWebApp.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;



namespace CourseManagementWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password && u.Role == "User");

            if (user != null)
            {
                SessionManager.LoggedInUser = user;
                return RedirectToAction("Dashboard", "Account");
            }

            ViewBag.ErrorMessage = "Invalid email or password or role";
            return View();
        }


        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(string email, string password)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.ErrorMessage = "Please enter both email and password.";
                return View();
            }

            try
            {
                // Check for admin user
                var user = _context.Users
                    .FirstOrDefault(u => u.Email == email && u.Password == password && u.Role == "Admin");

                if (user == null)
                {
                    ViewBag.ErrorMessage = "Invalid email, password, or role.";
                    return View();
                }

                // Store user in session
                SessionManager.LoggedInUser = user;
                return RedirectToAction("AdminDashboard", "Account");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View();
            }
        }




        public IActionResult Logout()
        {
            SessionManager.LoggedInUser = null;
            return RedirectToAction("Login");
        }



        public async Task<IActionResult> Dashboard()
        {
            // Check if the user is logged in
            if (SessionManager.LoggedInUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = SessionManager.LoggedInUser.UserId;

            // Fetch the user data asynchronously
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);

            // Fetch the enrollments asynchronously
            var enrollments = await _context.Enrollments
                                             .Include(a => a.Course)
                                             .Where(a => a.UserId == userId)
                                             .ToListAsync();

            // Pass the user and enrollments to the view
            ViewBag.User = user;
            ViewBag.Enrollments = enrollments;

            return View();
        }




        public IActionResult AdminDashboard()
        {
            if (SessionManager.LoggedInUser == null || SessionManager.LoggedInUser.Role != "Admin")
            {
                return RedirectToAction("Login", "Account");
            }

            var totalUsers = _context.Users.Count();
            var totalCourses = _context.Courses.Count();
            var totalEnrollments = _context.Enrollments.Count();

            ViewBag.TotalUsers = totalUsers;
            ViewBag.TotalCourses = totalCourses;
            ViewBag.TotalEnrollments = totalEnrollments;

            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(string Email, string Password)
        {
            // Check if the email exists
            var user = _context.Users.FirstOrDefault(u => u.Email == Email);

            if (user == null)
            {
                ViewBag.ErrorMessage = "No account found with this email.";
                return View();
            }

            // Update Password
            user.Password = Password;
            _context.SaveChanges();

            ViewBag.SuccessMessage = "Password has been reset successfully!";
            return View();
        }


        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(User user)
        {
            // Check if email or phone already exists
            if (_context.Users.Any(u => u.Email == user.Email))
            {
                ViewBag.ErrorMessage = "Email is already in use.";
                return View(user);
            }

            if (_context.Users.Any(u => u.Phone == user.Phone))
            {
                ViewBag.ErrorMessage = "Phone number is already registered.";
                return View(user);
            }

            // Set defaults
            user.Role = "User";

            // Save user to database
            _context.Users.Add(user);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Account created successfully! Please login.";
            return RedirectToAction("Login");
        }


        public IActionResult GenerateCsv()
        {
            if (SessionManager.LoggedInUser == null || SessionManager.LoggedInUser.Role != "Admin")
            {
                return RedirectToAction("Login", "Auth");
            }

            StringBuilder csv = new StringBuilder();

            // 1. Users Data
            var users = _context.Users.ToList();
            csv.AppendLine("Users Data");
            csv.AppendLine("UserId,Name,Email,Phone,Address,Role");
            foreach (var user in users)
            {
                csv.AppendLine($"{user.UserId},{user.Name},{user.Email},{user.Phone},{user.Address},{user.Role}");
            }
            csv.AppendLine();

            // 2. Courses Data
            var courses = _context.Courses.ToList();
            csv.AppendLine("Courses Data");
            csv.AppendLine("CourseId,CourseName,Description,StartDate,EndDate");
            foreach (var course in courses)
            {
                csv.AppendLine($"{course.CourseId},{course.CourseName},{course.Description},{course.StartDate:yyyy-MM-dd},{course.EndDate:yyyy-MM-dd}");
            }
            csv.AppendLine();

            // 3. Enrollments Data
            var enrollments = _context.Enrollments.ToList();
            csv.AppendLine("Enrollments Data");
            csv.AppendLine("EnrollmentId,UserId,CourseId,EnrollmentDate");
            foreach (var enrollment in enrollments)
            {
                csv.AppendLine($"{enrollment.EnrollmentId},{enrollment.UserId},{enrollment.CourseId},{enrollment.EnrollmentDate:yyyy-MM-dd}");
            }

            // Convert to CSV and Return as File
            var csvBytes = Encoding.UTF8.GetBytes(csv.ToString());
            return File(csvBytes, "text/csv", "CourseManagementData.csv");
        }




        // GET: EditProfile
        public async Task<IActionResult> EditProfile()
        {
            var userId = SessionManager.LoggedInUser.UserId;
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View(SessionManager.LoggedInUser);
        }


        [HttpPost]
        public async Task<IActionResult> EditProfile(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            // Check if the email is already in use by another user (excluding the current user's email)
            var isEmailTaken = await _context.Users
                .AnyAsync(u => u.Email == user.Email && u.UserId != SessionManager.LoggedInUser.UserId);

            if (isEmailTaken)
            {
                ModelState.AddModelError("Email", "This email is already in use by another user.");
                return View(user);
            }

            // Check if the phone number is already in use by another user (excluding the current user's phone number)
            var isPhoneTaken = await _context.Users
                .AnyAsync(u => u.Phone == user.Phone && u.UserId != SessionManager.LoggedInUser.UserId);

            if (isPhoneTaken)
            {
                ModelState.AddModelError("Phone", "This phone number is already in use by another user.");
                return View(user);
            }

            // If email is the same, don't update it.
            var existingUser = await _context.Users.FindAsync(SessionManager.LoggedInUser.UserId);

            if (existingUser != null)
            {
                // Only update the fields that are different
                if (existingUser.Email != user.Email)
                {
                    existingUser.Email = user.Email;
                }

                if (existingUser.Phone != user.Phone)
                {
                    existingUser.Phone = user.Phone;
                }

                // You can do this for any other fields that you want to ensure are updated
                existingUser.Name = user.Name;
                existingUser.Password = user.Password;
                existingUser.Address = user.Address;

                // Mark the entity as modified and save changes
                _context.Update(existingUser);
                await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard","Account"); // Redirect to the profile page
            }

            // If no user was found, return the view with the user object
            return View(user);
        }

































    }
}
