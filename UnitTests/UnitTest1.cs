using _732_2AlphSort;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sort_54321_12345()
        {
            string input = "5 4 3 2 1";
            string expected = "1 2 3 4 5 ";

            Sorter1 sorter = new Sorter1();
            string result = sorter.MakeSort(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void AuthorizeRegistrated()
        {
            bool Authorizated = true;
            string Login = "user";
            string Password = "1";
            DBManager dBManager = new DBManager("C:\\Users\\матвей\\Desktop\\osnova.db");
            Assert.AreEqual(Authorizated, dBManager.CheckUser(Login, Password));
        }

        [TestMethod]
        public void AuthorizeUnregistrated()
        {
            bool Authorizated = false;
            string Login = "user";
            string Password = "123";
            DBManager dBManager = new DBManager("C:\\Users\\матвей\\Desktop\\osnova.db");
            Assert.AreEqual(Authorizated, dBManager.CheckUser(Login, Password));
        }

        [TestMethod]
        public void ContainsOnlyDigits_AllDigits_ReturnsTrue()
        {
            char[] arr = { '1', '2', '3', '4', '5', '6' };
            Assert.IsTrue(ContainsOnlyDigits(arr));
        }

        [TestMethod]
        public void ContainsOnlyDigits_NonDigits_ReturnsFalse()
        {
            char[] arr = { '1', '2', '3', 'a', 'b', 'c' };
            Assert.IsFalse(ContainsOnlyDigits(arr));
        }

        public bool ContainsOnlyDigits(char[] arr)
        {
            foreach (char c in arr)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
       