using IBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using IBusinessLayer;
using IDAL;

namespace BusinessLayer
{
    public class TestBL : ITestBL
    {
         ITestDAL TestDAL;
        #region Constructor
        public TestBL()
        {
            TestDAL = new TestDAL();
        }
        #endregion Constructor

        public bool TestMethod()
        {
            return true;
        }
    }
}
