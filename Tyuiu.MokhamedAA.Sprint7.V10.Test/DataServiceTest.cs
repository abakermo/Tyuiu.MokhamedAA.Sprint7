using Tyuiu.MokhamedAA.Sprint7.V10.Lib;
namespace Tyuiu.MokhamedAA.Sprint7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {
            DataService ds = new DataService();
            string path = @"C:\Users\������������\Desktop\IGaame.csv";
            string[,] wait = new string[,] { {"�","�������","�����","���������","������"},
                {"1","1234","���������","100000","8" }, { "2","1235","����","1000","7"}};
            string[,] res = ds.LoadFromData(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}