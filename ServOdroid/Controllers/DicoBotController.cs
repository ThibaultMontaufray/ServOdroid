//namespace ServOdroid.Controllers
//{
//    using ServOdroid.Models;
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.IO;
//    using System.Linq;
//    using System.Web;
//    using System.Web.Mvc;
//    using PagedList;

//    public class DicoBotController : Controller
//    {
//        #region Attribute
//        private const string WEBPAGEPATH = "D:/DEV/ServOdroid/ServOdroid/ServOdroid/Views/DicoBot/";
//        private const string ROBOTLIBPATH = "../../Resources/DicoBot/Library/";
//        private int _weekNumber = 0;
//        #endregion

//        #region Method public
//        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
//        {
//            List<Robot> db = new List<Robot>();
//            db.Add(new Robot() {LastName="last1", FirstMidName="first1", EnrollmentDate=DateTime.Now.AddDays(-1)});
//            db.Add(new Robot() {LastName="last2", FirstMidName="first2", EnrollmentDate=DateTime.Now.AddDays(-2)});
//            db.Add(new Robot() {LastName="last3", FirstMidName="first3", EnrollmentDate=DateTime.Now.AddDays(-3)});
//            db.Add(new Robot() {LastName="last4", FirstMidName="first4", EnrollmentDate=DateTime.Now.AddDays(-4)});
//            db.Add(new Robot() {LastName="last5", FirstMidName="first5", EnrollmentDate=DateTime.Now.AddDays(-5)});

//            ViewBag.CurrentSort = sortOrder;
//            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
//            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

//            if (searchString != null)
//            {
//                page = 1;
//            }
//            else
//            {
//                searchString = currentFilter;
//            }

//            ViewBag.CurrentFilter = searchString;

//            var robots = from s in db select s;
//            if(!string.IsNullOrEmpty(searchString))
//            {
//                robots = robots.Where(s => s.LastName.Contains(searchString) || s.FirstMidName.Contains(searchString));
//            }
//            switch (sortOrder)
//            {
//                case "name_desc":
//                    robots = robots.OrderByDescending(s => s.LastName);
//                    break;
//                case "Date":
//                    robots = robots.OrderBy(s => s.EnrollmentDate);
//                    break;
//                case "date_desc":
//                    robots = robots.OrderByDescending(s => s.EnrollmentDate);
//                    break;
//                default:
//                    robots = robots.OrderBy(s => s.LastName);
//                    break;
//            }
//            int pageSize = 3;
//            int pageNumber = (page ?? 1);

//            //return View(robots.ToPageList(pageNumber, pageSize));
//            return View(robots.ToList());
//        }
//        public ActionResult DicoBotSearch(string returnFilter)
//        {
//            ViewBag.Message = "One week one bot.";
//            ViewBag.ReturnFilter = returnFilter;
//            return View();
//        }
                
//        [HttpPost]
//        [AllowAnonymous]
//        [ValidateAntiForgeryToken]
//        public ActionResult DicoBotSearch(DicoBotViewModel model, string returnFilter)
//        {
//            return Redirect("http://www.servodroid.com/");

//            //ViewBag.Message = "One week one bot.";
//            //ViewBag.Real = model.Real;
//            //ViewBag.Name = model.Name;
//            //ViewBag.Class = model.Class;
//            //ViewBag.Color = model.Color;
//            //ViewBag.Constructor = model.Constructor;
//            //ViewBag.Epoque = model.Epoque;
//            //ViewBag.Model = model.Model;
//            //ViewBag.Origin = model.Origin;
//            //ViewBag.Serie = model.Serie;
//            //ViewBag.SizeMax = model.SizeMax;
//            //ViewBag.SizeMin = model.SizeMin;
//            //ViewBag.Surname = model.Surname;
//            //ViewBag.Model = model;
            
//            //return View(model);
//        }
//        public ActionResult DicoBotDetail()
//        {
//            return Redirect("http://www.servodroid.com/");

//            //_weekNumber = getWeekNumber(DateTime.Now);
//            //ViewBag.Robot = GetTodayRobot(GetRobotName());
//            //ViewBag.Message = ViewBag.Robot.Name;   
//            //return View();
//        }
//        #endregion

//        #region Methods private
//        private string GetRobotName()
//        {
//            string WeekRobot = "";
//            string[] tab;

//            using (StreamReader sr = new StreamReader(WEBPAGEPATH + ROBOTLIBPATH + "index.csv"))
//            {
//                while (sr.Peek() > 0)
//                {
//                    tab = sr.ReadLine().Split(';');
//                    if (int.Parse(tab[0]) == DateTime.Now.Year && int.Parse(tab[1]) == _weekNumber)
//                    {
//                        WeekRobot = tab[2];
//                        ViewBag.TodaysRobotName = tab[2]; 
//                        break;
//                    }
//                }
//            }

//            return WeekRobot;
//        }
//        private Robot GetTodayRobot(string robotName)
//        {
//            Robot rob = new Robot();
//            rob.Name = robotName;

//            FileInfo fi;
//            foreach (string item in Directory.GetFiles(WEBPAGEPATH + ROBOTLIBPATH + robotName))
//            {
//                fi = new FileInfo(item);
//                if (fi.Name.StartsWith("picture")) rob.PicturePath.Add(ROBOTLIBPATH + robotName + "/" + fi.Name);
//                else if (fi.Name.Equals("info.xml")) rob.LoadInfo(fi.FullName);
//                else if (fi.Name.Equals("description.html")) rob.LoadDescription(fi.FullName);
//                else if (fi.Name.Equals("links.txt")) rob.LoadLink(fi.FullName);
//            }

//            return rob;
//        }
//        private int getWeekNumber(DateTime dt)
//        {
//            DateTime dtIncrement = new DateTime(dt.Year, 1, 1).AddMonths(1);
//            for (int i = 1; i < 54; i++)
//            {
//                if (dt <= dtIncrement) return i;
//                else dtIncrement = dtIncrement.AddDays(7);
//            }
//            return 0;
//        }
//        #endregion
//    }
//}