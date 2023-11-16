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
        RecordsRepositoryList _recordsRepositoryList = new RecordsRepositoryList(); // liste kopi

        [TestMethod()]
        public void RecordsRepositoryGetAllFromListTest()
        {
            var Result = _recordsRepositoryList.GetAll();
            Assert.AreEqual(Result.Count(), 10);
            Assert.AreEqual(Result.ElementAt(0).Title, "The Dark Side of the Moon");
        }

        [TestMethod()]
        public void RecordsRepositoryGetFilterTest()
        {
            var Result = _recordsRepositoryList.Get(title: "The Dark Side of the Moon");
            Assert.AreEqual(Result.Count(), 1);
            Assert.AreEqual(Result.ElementAt(0).Title, "The Dark Side of the Moon");
            Assert.AreEqual(Result.ElementAt(0).Artist, " Floyd");
            Assert.AreEqual(Result.ElementAt(0).Duration, 43);
            Assert.AreEqual(Result.ElementAt(0).PublicationYear, 1973);

            Result = _recordsRepositoryList.Get(artist: "pink");
            Assert.AreEqual(Result.Count(), 7);
            Assert.AreEqual(Result.ElementAt(0).Title, "The Wall");
            Assert.AreEqual(Result.ElementAt(0).Artist, "Pink Floyd");
            Assert.AreEqual(Result.ElementAt(0).Duration, 81);
            Assert.AreEqual(Result.ElementAt(0).PublicationYear, 1979);

            Result = _recordsRepositoryList.Get(duration: 50);
            Assert.AreEqual(Result.Count(), 4);
            Assert.AreEqual(Result.ElementAt(0).Title, "The Wall");
            Assert.AreEqual(Result.ElementAt(0).Artist, "Pink Floyd");
            Assert.AreEqual(Result.ElementAt(0).Duration, 81);
            Assert.AreEqual(Result.ElementAt(0).PublicationYear, 1979);

            Result = _recordsRepositoryList.Get(publicationYear: 1979);
            Assert.AreEqual(Result.Count(), 1);
                Assert.AreEqual(Result.ElementAt(0).Title, "The Wall");
                Assert.AreEqual(Result.ElementAt(0).Artist, "Pink Floyd");
                Assert.AreEqual(Result.ElementAt(0).Duration, 81);
                Assert.AreEqual(Result.ElementAt(0).PublicationYear, 1979);

        }
    }



}