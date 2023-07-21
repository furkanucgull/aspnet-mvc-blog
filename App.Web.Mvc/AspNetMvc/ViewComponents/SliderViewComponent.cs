using AspNetMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var SliderItems = new List<SliderViewModel>
            {
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Trip to California",
                    Title= "Travel",
                    ImageUrl= "/images/slider/slider1.jpg"
                },
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Our Favorite Weekend Getaways",
                    Title= "Weekends",
                    ImageUrl= "/images/slider/slider2.jpg"
                },
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "/images/slider/slider3.jpg"
                }, 
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "/images/slider/slider1.jpg"
                }, 
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "/images/slider/slider2.jpg"
                },
            };

            return View(SliderItems);
        }
    }
}
