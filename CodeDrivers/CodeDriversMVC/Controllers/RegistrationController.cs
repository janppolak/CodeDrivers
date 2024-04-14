using CodeDrivers;
using CodeDrivers.Models;
using CodeDriversMVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Configuration;
using System.Reflection;

namespace CodeDriversMVC.Controllers
{
    public class RegistrationController : Controller
    {
        private const string Path = @"fakeUsers.json";


        private readonly RegistrationService _registrationService;
        private readonly UserValidationHelper _validationHelper;

        public RegistrationController(RegistrationService registrationService, UserValidationHelper validationHelper)
        {
            _registrationService = registrationService;
            _validationHelper = validationHelper;
        }

        public ActionResult Index()
        {
            ViewData["ShowToast"] = true;

            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {

            if (!_validationHelper.IsValidPassword(user.Password))
            {
                ModelState.AddModelError("PasswordValidationError", "Hasło musi składać się z co najmniej 8 znaków w tym co najmniej jednej cyfry.");
                return View("Index", user);
            }
            else if (!_validationHelper.IsConfirmedPassword(user.Password, Request.Form["PasswordConfirmation"]))
            {
                ModelState.AddModelError("PasswordValidationError", "Hasła nie są zgodne!");
                return View("Index", user);
            }
            else if (!_validationHelper.IsValidEmail(user.Email))
            {
                ModelState.AddModelError("EmailValidationError", "Wprowadzono niepoprawny e-mail");
                return View("Index", user);
            }
            else if (!_validationHelper.IsValidPhoneNumber(user.PhoneNumber))
            {
                ModelState.AddModelError("PhoneValidationError", "Numer telefonu powinien składać się z 9 cyfr nieodzielonych odstępami.");
                return View("Index", user);
            }
            else if (!_validationHelper.IsMoreThan18(user.DateOfBirth))
            {
                ModelState.AddModelError("DateOfBirthValidationError", "Aby zarezerwować samochód, musisz mieć ukończone 18 lat.");
                return View("Index", user);
            }
            else if(_registrationService.IsEmailRegistered(user.Email))
            {
                ModelState.AddModelError("UserAlreadyExists", "Użytkownik o tym adresie e-mail już istnieje.");
                return View("Index", user);
            }
            else
            {
                _registrationService.Create(user);
                TempData["ShowToast"] = "success";
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult ViewList()
        {
            var allUser=_registrationService.GetAll();
            return View("ViewList",allUser);
        }

        // GET: RegistrationController/Details/5
        public ActionResult Details(string email)
        {
            var allUsers = _registrationService.GetByEmail(email);
            return View(allUsers);
            
        }

        // GET: RegistrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User newUser)
        {
            _registrationService.CreateByAdmin(newUser);
            TempData["SuccessUser"] = "Użytkownik został dodany do listy.";
            return RedirectToAction(nameof(ViewList));
        }

        // GET: RegistrationController/Edit/5
        public ActionResult Edit(string email)
        {
            var userToEdit = _registrationService.GetByEmail(email);
            return View(userToEdit);
        }

        // POST: RegistrationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string email, User userToEdit)
        {
            _registrationService.Update(userToEdit);
            return RedirectToAction(nameof(ViewList));
        }

        // GET: RegistrationController/Delete/5
        public ActionResult Delete(string email)
        {
            var userToBeRemoved = _registrationService.GetByEmail(email);
            return View(userToBeRemoved);
        }

        // POST: RegistrationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string email, User userToBeRemoved)
        {
            _registrationService.RemoveUser(email);
            TempData["DeleteUser"] = "Użytkownik został usunięty z listy.";
            return RedirectToAction(nameof(ViewList));
        }
    }
}
