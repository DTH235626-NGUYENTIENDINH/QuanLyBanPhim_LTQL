using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBP.DATA
{
    public class LoaiBanPhim
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }
        public virtual ObservableCollectionListSource<BanPhim> BanPhim { get; } = new();
    }
}
