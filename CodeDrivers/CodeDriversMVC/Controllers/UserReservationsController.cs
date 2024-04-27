using CodeDriversMVC.Models;
using CodeDriversMVC.Services;
using CodeDriversMVC.Constants;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CodeDriversMVC.Controllers
{
    public class UserReservationsController : Controller
    {
        private readonly UserReservationService _reservation;
        private readonly HttpContextAccessor _httpContextAccessor;

        public UserReservationsController(UserReservationService reservation, HttpContextAccessor httpContextAccessor)
        {
            _reservation = reservation;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            var email = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

            var userReservations = _reservation.GetUserReservations(email);
            return View(userReservations);
        }
        
        public IActionResult CancelReservation(int reservationId)
        {
            _reservation.CancelReservation(reservationId);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AskAQuestion()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AskAQuestion(string message)
        {
            EmailService.SendEmailAsync(Constants.Constants.AdminEmail, "Question", message);
            
            return RedirectToAction("Home", "Index");
        }

     
    }
}
