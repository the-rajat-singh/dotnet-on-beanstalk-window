using Microsoft.AspNetCore.Mvc;
using NotesApp.Models;
using System.Collections.Generic;

namespace NotesApp.Controllers
{
    public class NotesController : Controller
    {
        private static List<Note> notes = new List<Note>();

        public IActionResult Index()
        {
            return View(notes);
        }

        [HttpPost]
        public IActionResult Add(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                notes.Add(new Note { Content = content });
            }
            return RedirectToAction("Index");
        }
    }
}

