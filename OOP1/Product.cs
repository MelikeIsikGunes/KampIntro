using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  //Urun
    {
        public int Id { get; set; } //primary key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }  //fiyatı
        public int CategoryId { get; set; } //foreign key
        public int UnitInStock { get; set; } //Stok Adedi

    }
}
