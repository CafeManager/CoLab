using Microsoft.AspNetCore.Mvc;
using CoLab.Data;
using CoLab.Models;

namespace CoLab.Controllers
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CommentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Comments> objCommentList = _db.Comments;
            return View(objCommentList);
        }

        //GET
        public IActionResult Create() 
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryTokenAttribute]
        public IActionResult Create(Comments obj)
        {
            if (ModelState.IsValid)
            {
                _db.Comments.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id) {
            if (id == null || id == 0) {
                NotFound();
            }
            var commentFromDb = _db.Comments.Find(id);
            //var commentFromDbFirst = _db.Comments.FirstOrDefault(u=>u.Id == id);
            //var commentFromDbSingle = _db.Comments.SingleOrDefault(u=>u.Id == id);
            if (commentFromDb == null) {
                return NotFound();
            }
            return View(commentFromDb);
        }
    }
}
