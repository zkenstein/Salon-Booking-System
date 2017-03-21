using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salon.Services;
using Salon.ViewModels;
using Salon.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Salon.Controllers
{
    public class HomeController : Controller
    {
        private IDataService _dataservice;

        public HomeController(IDataService service)
        {
            _dataservice = service;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Client> list = _dataservice.getAll();
            DisplayAllViewModel vm = new DisplayAllViewModel();
            vm.ClientList = list;
            return View(vm);
        }


        public IActionResult Details(int id)
        {
            Client client = _dataservice.getClient(id);
            DetailsViewModel vm = new DetailsViewModel();
            vm.ClientId = client.ClientId;
            vm.Name = client.Name;
            vm.Dob = client.Dob.ToString("dd,MM,yyyy");
            vm.Contact = client.Contact;
            vm.Mobile = client.Mobile;
            vm.Email = client.Email;
            return View(vm);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateClientViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Client newClient = new Client
                {
                    Name = vm.Name,
                    Dob = vm.Dob,
                    Contact = vm.Contact,
                    Mobile = vm.Mobile,
                    Email = vm.Email
                };
                _dataservice.addClient(newClient);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Client updateClient =_dataservice.getClient(id);
            UpdateClientViewModel vm = new UpdateClientViewModel
            {
                Name = updateClient.Name,
                Dob = updateClient.Dob.ToString("dd,MM,yyyy"),
                Contact = updateClient.Contact,
                Mobile = updateClient.Mobile,
                Email = updateClient.Email
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateClientViewModel vm)
        {
            Client client = _dataservice.getClient(id);
            if (ModelState.IsValid)
            {
                client.Name = vm.Name;
                client.Dob = DateTime.Parse(vm.Dob);
                client.Contact = vm.Contact;
                client.Mobile = vm.Mobile;
                client.Email = vm.Email;
                _dataservice.updateClient();
                return RedirectToAction("Details", new {id=client.ClientId });
            }
            return View(vm);
        }
    }
}
