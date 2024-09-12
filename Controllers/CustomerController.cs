using Microsoft.AspNetCore.Mvc;
using ModelViewControllerDemo.Models;
using ModelViewControllerDemo.Repositories;

namespace ModelViewControllerDemo.Controllers
{
    public class CustomerController : Controller
    {
        

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer c)
        {
            CustomerRepository.Customer.Add(c);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(CustomerRepository.Customer);
        }
        public IActionResult Edit(int id)
        {
            return View(CustomerRepository.Customer.FirstOrDefault((cus)=>cus.Id == id));

        }
        [HttpPost]
        public IActionResult Edit(int id,Customer c)
        {
            var result = CustomerRepository.Customer.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                result.Name = c.Name;
                result.Email = c.Email;
                result.Password = c.Password;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(CustomerRepository.Customer.FirstOrDefault((cus) => cus.Id == id));
        }
        [HttpPost]
        public IActionResult Delete(int id,Customer c)
        {
            var cus = CustomerRepository.Customer.FirstOrDefault(c => c.Id == id);
            if (cus != null)
            {
                CustomerRepository.Customer.Remove(cus);
            }
            return RedirectToAction("Index");
        }
    }
}
