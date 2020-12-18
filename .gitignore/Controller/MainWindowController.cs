using promoMVC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace promoMVC.Controller
{
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;

        public MainWindowController(KeranjangBelanja keranjangBelanja)
        {
            this.keranjangBelanja = keranjangBelanja;
        }

        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }
        public List<Item> getSelectedItems()
        {
            return this.keranjangBelanja.getItems();
        }
        public void deleteSelectedItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }
    }
}
