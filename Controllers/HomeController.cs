using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using phonebook.Models;

namespace phonebook.Controllers;

public class HomeController : Controller
{
    private readonly  Context db; 
    

    public HomeController(Context x)
    {
        db = x;
    }

    public IActionResult Index()
    {
        ViewBag.result=db.Tbl_Phonebooks.OrderByDescending(x=>x.id).ToList();
        return View();
    }
public IActionResult addnumber(Tbl_Phonebook phonebook)
    {
        db.Tbl_Phonebooks.Add(phonebook);
        db.SaveChanges();
        return RedirectToAction("index");
    }
    
public IActionResult delete(int id)
    {
       var del = db.Tbl_Phonebooks.Find(id);
       db.Tbl_Phonebooks.Remove(del);
        db.SaveChanges();
        return RedirectToAction("index");
    }

public IActionResult edit (int id)
    {
       var del = db.Tbl_Phonebooks.Find(id);
       return View(del);
    }


public IActionResult show (Tbl_Phonebook c )
    {
       var del = db.Tbl_Phonebooks.Find(c.id);
       del.name = c.name;
       del.number = c.number;
       del.email = c.email;
db.SaveChanges();
        return RedirectToAction("index");

       return View(del);
    }
    
}

