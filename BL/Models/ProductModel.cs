using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public bool IsBarcoded { get; set; }// ürün barkodlu ise bu alan true barkodsuz ise false
        public string? BarcodeNo { get; set; }//IsBarcoded true ise bu alan dolacak false ise boş kalacak.
        public int? Amount { get; set; }
        public string? Unit { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public bool Guarantee { get; set; }

        public int Cost { get; set; }
        public int CurrentPrice { get; set; }
        public string Explanation { get; set; }
        public int WarehouseId { get; set; }

        public WareHouseModel WareHouse { get; set; }
    }
}
