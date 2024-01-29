using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazLab1_1
{
    class CheckedListItems
    {

        public CheckedListItems()
        {

        }

        public CheckedListItems(string sicilNo , int dersId )
        {

            this.sicilNo = sicilNo;
            this.dersId = dersId;

        }

        public string sicilNo { get; set; }

        public int dersId { get; set; }
       
    }
}
