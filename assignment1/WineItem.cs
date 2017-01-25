using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private int itemID;
        private string itemDesc;
        private string itemPack;

        //*************
        //Properties
        //*************

        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public string ItemDesc
        {
            get { return itemDesc; }
            set { itemDesc = value; }
        }

        public string ItemPack
        {
            get { return itemPack; }
            set { itemPack = value; }
        }

        //***************
        //Public Methods
        //***************

        public string ItemDescAndPack()
        {
            return itemDesc + "  " + itemPack;
        }

        public override string ToString()
        {
            return itemID.ToString("C") + "  " + itemDesc + "  " + itemPack;
        }

        //****************
        //Constructors
        //****************

        public WineItem(int ItemID, string ItemDesc, string ItemPack)
        {
            itemID = ItemID;
            itemDesc = ItemDesc;
            itemPack = ItemPack;
        }

        public WineItem()
        {
            //Do nothing
        }
    }
}
