using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Biciklizam.Model;
using Biciklizam.MemoryBasedDAL;

namespace Biciklizam.MemoryBasedDAL.Tests
{
    [TestClass]
    public class BiciklistRepositoryTests
    {
        [TestMethod]
        public void InitializeBiciklistRepo()
        {
            BiciklistRepository repo = BiciklistRepository.getInstance();

            Assert.IsNotNull(repo);
        }
        [TestMethod]
        public void AddBiciklist()
        {
            BiciklistRepository repo = BiciklistRepository.getInstance();
            Biciklist biciklist = new Biciklist(repo.getNewId(),"Franjo", "Horvat", "12345678901", new DateTime(1997, 7, 18));

            repo.addBiciklist(biciklist);

            Assert.IsTrue(repo.getBiciklistNum() == 1);
        }
        [TestMethod]
        public void FindBiciklistByOib()
        {
            BiciklistRepository repo = BiciklistRepository.getInstance();

            Biciklist biciklist = null;
            try
            {
                biciklist = repo.getBiciklistByOib("12345678901");
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.IsNotNull(biciklist);
        }
        [TestMethod]
        public void FindBiciklistByName()
        {
            BiciklistRepository repo = BiciklistRepository.getInstance();

            Biciklist biciklist = null;
            try
            {
                biciklist = repo.getBiciklistByName("Franjo");
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.IsNotNull(biciklist);
        }
        [TestMethod]
        public void FindBiciklistById()
        {
            BiciklistRepository repo = BiciklistRepository.getInstance();

            Biciklist biciklist = repo.getBiciklistByName("Franjo");
            Biciklist realBiciklist = repo.getBiciklistByID(biciklist.Id);

            Assert.IsNotNull(realBiciklist);
            Assert.AreEqual<int>(biciklist.Id, realBiciklist.Id);
        }
        [TestMethod]
        public void deleteBiciklist()
        {
            BiciklistRepository repo = BiciklistRepository.getInstance();

            Biciklist biciklist = repo.getBiciklistByName("Franjo");
            repo.deleteBiciklist(biciklist.Id);

            Assert.AreEqual<int>(0, repo.getBiciklistNum());
        }
    }
}
