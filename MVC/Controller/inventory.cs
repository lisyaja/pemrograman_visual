using AppInventory.Models;
using System.Collections.Generic;

namespace AppInventory.Controllers
{
    public class InventoryController
    {
        private List<Barang> daftarBarang = new List<Barang>();

        public List<Barang> GetAll() => daftarBarang;

        public void Add(Barang barang)
        {
            daftarBarang.Add(barang);
        }

        public void Update(int index, Barang barang)
        {
            if (index >= 0 && index < daftarBarang.Count)
                daftarBarang[index] = barang;
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < daftarBarang.Count)
                daftarBarang.RemoveAt(index);
        }
    }
}
