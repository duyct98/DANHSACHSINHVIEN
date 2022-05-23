using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANHSACHSINHVIEN
{
    internal class loplist
    {
        
            public lopHoc data;
            public loplist next;
            public loplist(lopHoc data, loplist next)
            {
                this.data = data;
                this.next = next;
            }
        
    }
}
