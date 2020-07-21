using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        //localhost:5000/product/list
        public string Index()
        {//yazdımki product yazınca locale hemen product index çalışsın çünkü startupta action ındex
            return "product/index";
        }
        public string list()
        {
            return "product/list";
        }
        //localhost:5000/product/details
        public string Details(int id)
        {
            return "product/details/"+id;
        }
    }
}