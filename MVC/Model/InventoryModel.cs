using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInventory.Model
{
    public class InventoryModel
    {
        public string Id { get; set; }
        public string Kode { get; set; }
        public string Nama { get; set; }
        public string Kondisi { get; set; }
        public string Jumlah { get; set; }
        public string Satuan { get; set; }
    }
}
