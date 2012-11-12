using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public class CategoryService: ICategoryService
    {
        public IEnumerable<Item> GetCategory(int id)
        {
            return MockCategory();
        }
        List<Item> MockCategory()
        {
            var item = new Item
            {
                Title = "Återvinningscentral Hovsta",
                Desc = "Här ska det stå en beskrivning...",
                Url = "http://www.orebro.se/305.html",
                Icon = "http://geodata.orebro.se/images/atervinning_a.jpg",
                X = "15.34510316130411",
                Y = "59.255292950802385"
            };
            var item2 = new Item
            {
                Title = "Återvinningscentral Atle",
                Desc = "Här ska det stå en beskrivning...",
                Url = "http://www.orebro.se/305.html",
                Icon = "http://geodata.orebro.se/images/atervinning_a.jpg",
                X = "15.239830446450839",
                Y = "59.34655600001931"
            };
            var item3 = new Item
            {
                Title = "Hundlatriner",
                Desc = "Här ska det stå en beskrivning...",
                Url = "http://www.orebro.se/",
                Icon = "http://www.lansstyrelsen.se/_layouts/LST-Images/Serviceinformation/soptunna.jpg",
                X = "15.219075135497945",
                Y = "59.27226251755445"
            };
            List<Item> items = new List<Item>();
            items.Add(item);
            items.Add(item2);
            items.Add(item3);
            return items;
        }
    }
}
