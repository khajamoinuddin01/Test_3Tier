using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TestDAL : IDAL.ITestDAL        
    {

        public bool TestMethod()
        {
            return true;
        }
    }
}
