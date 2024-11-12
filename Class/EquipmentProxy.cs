using Proxy_Trabalho.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Trabalho.Class
{
    public class EquipmentProxy : IEquipment
    {
        Equipment client = new Equipment();

        public string GetData()
        {
            if (client.intemId != 0)
                return client.GetData();

            else
                return "Item is not in inventory";
        }
    }
}
