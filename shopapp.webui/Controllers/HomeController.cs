using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    //localhost:5000/home dersek bu şema bizi buraya getirir
    public class HomeController: Controller//.netcore içinde var olan Controller clasını Homeconstroller clasına kalıttımki Homecontroller controller gibi hareket etsin
    {
        //localhost:5000/home/Index buraya gelir ve retundeki yazar
        public string Index(){
            return "home/index";
        }
        public string Abouth(){
            return "home/abouth";
        }
    }
}