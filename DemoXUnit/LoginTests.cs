using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoXUnit
{
    public class LoginTests:Driver
    {
        [Fact]
        public void LoginTest()
        {
            string pageTitle = driver.Title;
            Console.WriteLine("The web page title is {0}", pageTitle);
            Assert.Equal(pageTitle, pageTitle);
        }

        [Fact]
        public void LoginTestAgain()
        {
            string pageTitle = driver.Title;
            Assert.Equal(pageTitle, pageTitle);
            Console.WriteLine("The web page title is {0}", pageTitle);
        }

        [Theory]
        [InlineData("hashili")]
        [InlineData("hashiliTitle")]
        [InlineData("hashiliNewTitle")]
        public void LoginTestAgainAgaina(string name)
        {
            string pageTitle = driver.Title;
            Assert.Equal(name, pageTitle);
            Console.WriteLine("The web page title is {0}", pageTitle);
        }

        [Theory]
        [ClassData(typeof(TestData))]
        public void LoginTestAgainAgainAgaina(string name)
        {
            string pageTitle = driver.Title;
            Assert.Equal(name, pageTitle);
            Console.WriteLine("The web page title is {0}", pageTitle);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void LoginTestAgainAgainAgainAgain(string name)
        {
            string pageTitle = driver.Title;
            Assert.Equal(name, pageTitle);
            Console.WriteLine("The web page title is {0}", pageTitle);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { "ello" },
            new object[] { "poi" }
,
        };

    }
}
