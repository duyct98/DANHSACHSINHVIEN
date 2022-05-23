using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANHSACHSINHVIEN
{
    internal class svlist
    {
        
        public sinhvien data;
        public svlist next;
        public svlist(sinhvien data, svlist next)
        {
            this.data = data;
            this.next = next;
        }
    }
    
}

