using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers {
  public class EngineersController: Controller {
    private readonly ToDoListContext _db;

    public EngineersController(ToDoListContext db) {
      _db = db;
    }

    public ActionResult Index() {
      List < Engineer > model = _db.Engineers.ToList();
      return View(model);
    }

    public ActionResult Create() {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer Engineer) {
      _db.Engineers.Add(Engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id) {
      var thisEngineer = _db.Engineers
        .Include(Engineer => Engineer.JoinEntities)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(Engineer => Engineer.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer Engineer) {
      _db.Entry(Engineer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) {
      var thisEngineer = _db.Engineers.FirstOrDefault(Engineer => Engineer.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisEngineer = _db.Engineers.FirstOrDefault(Engineer => Engineer.EngineerId == id);
      _db.Engineers.Remove(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}