using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Dtos.Item;
using ToDo.Application.Interfaces;
using ToDo.Domain.Entities;
using ToDo.Domain.Interface;
using ToDo.Web.Mvc.Models;

namespace ToDo.Web.Mvc.Controllers
{
    public class ItemController : Controller
    {
        protected IItemService service;

        public ItemController(IItemService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var items = await service.GetItemsAsync();

            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Description")] ItemRequestDTO itemRequestDTO)
        {
            if (ModelState.IsValid)
            {
                await service.CreateItemAsync(itemRequestDTO);

                return RedirectToAction(nameof(Index));
            }  

            return View();
        }

        
        [HttpGet]
        public async Task<IActionResult> Edit(Guid Id)
        {
            if (Id != null)
            {
                await service.EditItemAsync(Id);

                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid Id)
        {
            if (Id != null )
            {
                await service.DeleteItemAsync(Id);

                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}
