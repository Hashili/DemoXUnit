using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoXUnit
{
    public class TestData : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "amina" };
            yield return new object[] { "ishaan" };
            
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
 
    }
}
