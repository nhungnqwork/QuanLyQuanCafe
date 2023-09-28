using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    internal class Menu
    {
        private float totalPrice;
        private float price;
        private string foodName;
        private int count;

        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string FoodName { get => foodName; set => foodName = value; }

        public Menu(string foodName, int count, float price, float totalPrice = 0) 
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
    }
}
