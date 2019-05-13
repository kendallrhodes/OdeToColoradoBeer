using OdeToColoradoBeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToColoradoBeer.Controllers
{
    public class ReviewsController : Controller
    {
        //
        // GET: /Reviews/

        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.Country
                select r;

            return View(model);
        }

        //
        // GET: /Reviews/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reviews/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews/Edit/5

        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.Id == id);

            return View(review);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {

            var review = _reviews.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                //..
                return RedirectToAction("Index");
            }
            return View(review);
        }
        //
        // GET: /Reviews/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<BeerReview> _reviews = new List<BeerReview>
        {
            new BeerReview {
                Id= 1,
                Name= "Denver Beer",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            },
            new BeerReview {
                Id= 1,
                Name= "Comrades",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            },
            new BeerReview {
                Id= 1,
                Name= "Baier",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            },
            new BeerReview {
                Id= 1,
                Name= "Copper Kettle",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            },
            new BeerReview {
                Id= 1,
                Name= "CoBrew",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            },
            new BeerReview {
                Id= 1,
                Name= "Dry Dock",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            },
            new BeerReview {
                Id= 1,
                Name= "Wits End",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            },
            new BeerReview {
                Id= 1,
                Name= "Little Machine",
                City= "Denver",
                State = "Colorado",
                
                Rating = 10,
            }
        };
    }
}
