using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBUFapplicatie
{
    public class DAL
    {
        static string GetConnectionString()
        {
            return @"Data Source=Tyrone;Initial Catalog=TYDB;Integrated Security=True";
        }
    }
}
