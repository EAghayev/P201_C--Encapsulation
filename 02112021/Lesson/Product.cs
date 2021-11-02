using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    class Product
    {
        public readonly string GroupNo = "P201";
        public double DiscountedPrice { get; private set; }
        public Product()
        {

        }

        public Product(double disPrice,string no)
        {
            this.DiscountedPrice = disPrice;
            this.GroupNo = no;
        }

        private double _discount;
        public double Discount
        {
            set
            {
                if (value >= 0)
                {
                    this._discount = value;
                    this.DiscountedPrice = this._price * (100 - value) / 100;
                }
            }
            get => this._discount;
        }

        private string _name;
        private double _price;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 2) this._name = value;
            }
        }
       
        public double Price {
            get
            {
                return this._price;
            }
            set
            {
                if (value >= 0) this._price = value;
            }
        }

        public void SetPrice(double price)
        {
            if(price>=0)
                this._price = price;
        }

        public double GetPrice()
        {
            return this._price;
        }

        public string GetInfo()
        {
            return $"Name: {this.Name} - Price: {this.Price} - Dicount: {this.Discount}  DiscountedPrice: {this.DiscountedPrice} - GroupNo: {this.GroupNo}";
        }
    }
}
