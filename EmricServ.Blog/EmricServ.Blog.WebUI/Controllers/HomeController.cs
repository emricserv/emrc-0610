using EmricServ.Blog.Domain.Entities;
using EmricServ.Blog.Repository;
using EmricServ.Blog.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmricServ.Blog.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private BlogCategoryRepository blogCategoryRepsitory;
        private BlogPostRepository blogPostRepository;
        public IUnitOfWork unitOfWork { get; set; }
        public HomeController(IUnitOfWork _unitofwork)
        {
            this.unitOfWork = _unitofwork;
            blogCategoryRepsitory = unitOfWork.Repository<BlogCategoryRepository>();
            blogPostRepository = unitOfWork.Repository<BlogPostRepository>();
        }
        public ActionResult Index()
        {
            var count = blogCategoryRepsitory.SelectAll().Count();
            var test = blogCategoryRepsitory.TesMethod();
            var bpcount = blogPostRepository.SelectAll().Count();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}