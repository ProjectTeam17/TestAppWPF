using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestAppWPF.DBFirst
{
    class Class1
    {
        TestTable t1 = null;

        List<TestTable> mylist = null;

        public TestTable MyProperty { get; set; }

        public Class1()
        {
            t1 = new TestTable();
            mylist = new List<TestTable>();
        }

        public void ListTable()
        {
            
        }
    }
}
