using Proxy_Trabalho.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Trabalho.Class
{
    public class Equipment : IEquipment
    {
        string itemName;
        public int intemId;
        //Constructor
        public Equipment()
        {               
            itemName = "Iron Sword";
            intemId = 1;
        }

        public string GetData()
        {
            return (itemName + " ID: " + intemId.ToString());
        }
    }
}
