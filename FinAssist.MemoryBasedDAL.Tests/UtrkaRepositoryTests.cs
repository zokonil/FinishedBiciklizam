using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Biciklizam.Model;
using Biciklizam.MemoryBasedDAL;

namespace Biciklizam.MemoryBasedDAL.Tests
{
    [TestClass]
    public class UtrkaRepositoryTests
    {
        [TestMethod]
        public void InitializeUtrkaRepo()
        {
            UtrkaRepository repo = UtrkaRepository.getInstance();

            Assert.IsNotNull(repo);
        }
        [TestMethod]
        public void AddUtrka()
        {
            UtrkaRepository repo = UtrkaRepository.getInstance();
            Utrka utrka = new Kronometar(repo.getNewId(), 120.5f, new TimeSpan(2, 20, 30), new DateTime(2020, 7, 18));

            Console.WriteLine(utrka.GetType() == typeof(Kronometar));

            repo.addUtrka(utrka);

            Assert.IsTrue(repo.getUtrkaNum() == 1);
        }
        [TestMethod]
        public void FindUtrkaById()
        {
            UtrkaRepository repo = UtrkaRepository.getInstance();

            Utrka utrka = repo.getUtrkaByID(1);

            Assert.IsNotNull(utrka);
        }
        [TestMethod]
        public void deleteUtrka()
        {
            UtrkaRepository repo = UtrkaRepository.getInstance();

            repo.deleteUtrka(1);

            Assert.AreEqual<int>(0, repo.getUtrkaNum());
        }
    }
}
