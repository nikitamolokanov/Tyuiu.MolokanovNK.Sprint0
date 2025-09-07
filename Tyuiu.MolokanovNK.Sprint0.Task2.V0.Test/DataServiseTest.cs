using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MolokanovNK.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolokanovNK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Никита";
            var res = DataServise.GetMessage(name);

            //Вызываем класс Assert и метод AreEqua1
            Assert.AreEqual("Привет..., Никита", res);
        }
    }
}
