using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRest.Tests
{


    [TestClass()]
    public class RecordsRepositoryListTests
    {
        RecordsRepositoryList recordsRepositoryList = new RecordsRepositoryList(); // liste kopi

        [TestMethod()]
        public void RecordsRepositoryGetAllFromListTest()
        {
            var Result = recordsRepositoryList.GetAll();
            Assert.AreEqual(Result.Count(), 10);
            Assert.AreEqual(Result.ElementAt(0).Title, "The Dark Side of the Moon");

        }
    }
}