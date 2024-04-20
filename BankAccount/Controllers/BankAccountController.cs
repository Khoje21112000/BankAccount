using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankAccount.Data;
using BankAccount.Models;

namespace BankAccount.Controllers
{
    public class BankAccountController : Controller
    {
        private readonly BankDbContext _context;

        public BankAccountController(BankDbContext context)
        {
            _context = context;
        }

        // GET: BankAccount
        public IActionResult Index()
        {
            var bankAccounts = _context.BankAccounts.ToList();
            return View(bankAccounts);
        }

        // GET: BankAccount/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BankAccount/Create
        [HttpPost]
        public IActionResult Create([Bind("AccountNumber,BankName,BankAddress,Amount")] BankAccountModel bankAccount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankAccount);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(bankAccount);
        }

        // GET: BankAccount/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankAccount = _context.BankAccounts.Find(id);
            if (bankAccount == null)
            {
                return NotFound();
            }
            return View(bankAccount);
        }

        // POST: BankAccount/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,AccountNumber,BankName,BankAddress,Amount")] BankAccountModel bankAccount)
        {
            if (id != bankAccount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankAccount);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankAccountExists(bankAccount.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bankAccount);
        }



        // GET: BankAccount/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankAccount = _context.BankAccounts.FirstOrDefault(m => m.Id == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return View(bankAccount);
        }

        // POST: BankAccount/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var bankAccount = _context.BankAccounts.Find(id);
            _context.BankAccounts.Remove(bankAccount);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        private bool BankAccountExists(int id)
        {
            return _context.BankAccounts.Any(e => e.Id == id);
        }
    }
}
