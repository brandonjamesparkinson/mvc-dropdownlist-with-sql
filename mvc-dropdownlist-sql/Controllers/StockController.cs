using mvc_dropdownlist_sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dropdownlist_sql.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult AddOrEdit(int id = 0)
        {
            Stock stockModel = new Stock();
            using (DbModels db = new DbModels())
            {
                if (id != 0)
                    stockModel = db.Stocks.Where(x => x.StockId == id).FirstOrDefault();

                stockModel.ProductCollection = db.Products.ToList<Product>();
            }
            
            // Hard coding dropdown values
            //stockModel.ProductCollection = new List<Product>() {
            //new Product() { ProductId = 1, ProductName = "Computer" },
            //new Product() {ProductId = 2, ProductName = "Mobile Phone" }
            //};

            return View(stockModel);
        }

        // POST: Stock
        [HttpPost]
        public ActionResult AddOrEdit(Stock stock)
        {
            // TODO: Save product ID & count in stock table

            return View();
        }
    }
}