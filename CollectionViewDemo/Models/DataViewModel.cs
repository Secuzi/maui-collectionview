using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo.Models
{
    public class DataViewModel
    {
        public ObservableCollection<Products> Products { get; set; }
        public DataViewModel()
        {
            Products = new ObservableCollection<Products>
            {
                new Products()
                {
                    Name = "Apple",
                    Price = 370.0m,
                    Image = "apple.jpg",
                    HasOffer = false,
                    Stock = 9
                },
                new Products
                    {
                    Name = "Watermelon",
                    Price = 370.0m,
                    Image = "watermelon.jpg",
                    HasOffer = false,
                    Stock = 9
                },
                new Products
                    {
                    Name = "Mango",
                    Price = 370.0m,
                    Image = "mango.jpg",
                    HasOffer = true,
                    Stock = 9
                },
                new Products
                    {
                    Name = "Sweet Potato",
                    Price = 370.0m,
                    Image = "sweetpotato.jpg",
                    HasOffer = false,
                    Stock = 9
                },
                new Products
                    {
                    Name = "Pineapple",
                    Price = 370.0m,
                    Image = "pineapple.jpg",
                    HasOffer = false,
                    Stock = 9
                     }

            };
        }
    }
}
