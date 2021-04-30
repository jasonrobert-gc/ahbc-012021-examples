using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Day27.Data;
using Day27.Models;
using Microsoft.AspNetCore.Identity;

namespace Day27.Controllers
{
    public class ShoppingItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ShoppingItemsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ShoppingItems
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            //return View(await _context.Items.FirstOrDefaultAsync(x => x.User.Id == userId));
            return View(await _context.Items.Where(x => x.User.Id == userId).ToListAsync());
        }

        // GET: ShoppingItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingListItem = await _context.Items
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shoppingListItem == null)
            {
                return NotFound();
            }

            return View(shoppingListItem);
        }

        // GET: ShoppingItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoppingItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Quantity")] ShoppingListItem shoppingListItem)
        {
            if (ModelState.IsValid)
            {
                shoppingListItem.User = await _userManager.GetUserAsync(User);
                _context.Add(shoppingListItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoppingListItem);
        }

        // GET: ShoppingItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingListItem = await _context.Items.FindAsync(id);
            if (shoppingListItem == null)
            {
                return NotFound();
            }
            return View(shoppingListItem);
        }

        // POST: ShoppingItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Quantity")] ShoppingListItem shoppingListItem)
        {
            if (id != shoppingListItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoppingListItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoppingListItemExists(shoppingListItem.Id))
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
            return View(shoppingListItem);
        }

        // GET: ShoppingItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingListItem = await _context.Items
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shoppingListItem == null)
            {
                return NotFound();
            }

            return View(shoppingListItem);
        }

        // POST: ShoppingItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoppingListItem = await _context.Items.FindAsync(id);
            _context.Items.Remove(shoppingListItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoppingListItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}
