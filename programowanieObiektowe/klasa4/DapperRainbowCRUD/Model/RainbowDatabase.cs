using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRainbowCRUD.Model
{
    public class RainbowDatabase : Database<RainbowDatabase>
    {
        public Table<Master> MasterTable { get; set; }
    }
}
