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
    public class RecordTests
    {
        [TestMethod()]
        public void ValidateRecordisValid()
        {
            var validRecord = new Record() {Artist = "fewfef",Duration = 123,PublicationYear = 1230,Title = "fwe"};
            var invalidRecordArtistTomString = new Record() { Artist = "", Duration = 123, PublicationYear = 1230, Title = "fwe" };
            var invalidRecordArtistNull = new Record() { Artist = null, Duration = 123, PublicationYear = 1230, Title = "fwe" };
            var invalidRecordDuration = new Record() { Artist = "fewfef", Duration = -123, PublicationYear = 1230, Title = "fwe" };
            var invalidRecordPublicationYear = new Record() { Artist = "fewfef", Duration = 123, PublicationYear = 123, Title = "fwe" };
            var invalidRecordTitleString = new Record() { Artist = "fewfef", Duration = 123, PublicationYear = 1230, Title = "" };
            var invalidRecordTitleNull = new Record() { Artist = "fewfef", Duration = 123, PublicationYear = 1230, Title = null };


            validRecord.Validate();
            Assert.ThrowsException<ArgumentException>(() => invalidRecordArtistTomString.Validate());
            Assert.ThrowsException<ArgumentNullException>(() => invalidRecordArtistNull.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidRecordDuration.Validate());
            Assert.ThrowsException<ArgumentException>(() => invalidRecordPublicationYear.Validate());
            Assert.ThrowsException<ArgumentException>(() => invalidRecordTitleString.Validate());
            Assert.ThrowsException<ArgumentNullException>(() => invalidRecordTitleNull.Validate());

        }
        




        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}