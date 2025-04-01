using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseManagementWebApp.Models;
using CourseManagementWebApp.Controllers;
using System.Text;
using Microsoft.EntityFrameworkCore;



namespace CourseManagementWebApp.Controllers
{
    public class UserFunctions : Controller
    {
        private readonly AppDbContext _context;

        public UserFunctions(AppDbContext context)
        {
            _context = context;
        }

        // Index - Show all courses
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        // Details - Show details of a single course
        public IActionResult Details(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enroll(int id, DateTime enrollmentDate)
        {
            var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            // Get the logged-in user's ID from SessionManager
            int userId = SessionManager.LoggedInUser.UserId;

            // Check if the user is already enrolled in the course
            bool isAlreadyEnrolled = _context.Enrollments
                .Any(e => e.UserId == userId && e.CourseId == course.CourseId);

            if (isAlreadyEnrolled)
            {
                TempData["Error"] = "You are already enrolled in this course.";
                return RedirectToAction("Details", new { id = course.CourseId });
            }

            // Add enrollment record
            var enrollment = new Enrollment
            {
                UserId = userId,
                CourseId = course.CourseId,
                EnrollmentDate = enrollmentDate
            };

            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();

            // Redirect to ShowEnrollments page
            return RedirectToAction("ShowEnrollments", "UserFunctions");
        }


        // Index - Show all enrollments for the logged-in user
        public IActionResult ShowEnrollments()
        {
            // Assuming session stores logged-in user information
            var loggedInUserId = SessionManager.LoggedInUser.UserId;
            var enrollments = _context.Enrollments
                                      .Where(e => e.UserId == loggedInUserId)
                                      .Include(e => e.Course)
                                      .ToList();
            return View(enrollments);
        }

        // Delete - Delete enrollment by ID
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var enrollment = _context.Enrollments.Find(id);
            if (enrollment != null)
            {
                _context.Enrollments.Remove(enrollment);
                _context.SaveChanges();
            }
            return Redirect(Url.Action("ShowEnrollments", "UserFunctions"));  // Redirect to the Index action of the Enrollments controller

        }



    }
}
