using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private string itemID;
        private string itemDesc;
        private string itemPack;

        //*************
        //Properties
        //*************

        public string ItemID
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
            return itemID + "  " + itemDesc + "  " + itemPack;
        }

        //****************
        //Constructors
        //****************

        public WineItem(string ItemID, string ItemDesc, string ItemPack)
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
