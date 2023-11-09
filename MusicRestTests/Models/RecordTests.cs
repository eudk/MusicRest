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
        Record validRecord = new Record() { Artist = "f", Duration = 1, PublicationYear = 1000, Title = "f" };
        Record invalidRecordArtistEmptyString = new Record() { Artist = "", Duration = 123, PublicationYear = 1230, Title = "fwe" };
        Record invalidRecordArtistNull = new Record() { Artist = null, Duration = 123, PublicationYear = 1230, Title = "fwe" };
        Record invalidRecordDuration = new Record() { Artist = "fewfef", Duration = 0, PublicationYear = 1230, Title = "fwe" };
        Record invalidRecordPublicationYear = new Record() { Artist = "fewfef", Duration = 123, PublicationYear = 999, Title = "fwe" };
        Record invalidRecordTitleString = new Record() { Artist = "fewfef", Duration = 123, PublicationYear = 1230, Title = "" };
        Record invalidRecordTitleNull = new Record() { Artist = "fewfef", Duration = 123, PublicationYear = 1230, Title = null };

        

        [TestMethod()]
        public void ValidateRecordisValid()
        {

            validRecord.Validate();
        }

        [TestMethod()]
        public void ValidateRecordNotValidTitleNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => invalidRecordTitleNull.Validate());
        }

        [TestMethod()]
        public void ValidateRecordNotValidTitleEmptyString()
        {
            Assert.ThrowsException<ArgumentException>(() => invalidRecordTitleString.Validate());
        }

        [TestMethod()]
        public void ValidateRecordNotValidArtistNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => invalidRecordArtistNull.Validate());
        }

        [TestMethod()]
        public void ValidateRecordNotValidArtistEmptyString()
        {
            Assert.ThrowsException<ArgumentException>(() => invalidRecordArtistEmptyString.Validate());
        }

        [TestMethod()]
        public void ValidateRecordNotValidRecordDuration()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidRecordDuration.Validate());
        }

        [TestMethod()]
        public void ValidateRecordNotValidPublicationYear()
        {
            Assert.ThrowsException<ArgumentException>(() => invalidRecordPublicationYear.Validate());
        }



        [TestMethod()]
        public void ToStringTest()
        {
            string ActualString = validRecord.ToString();
            string ExpectedString = "Id: , Title: f, Artist: f, Duration: 1, Publication Year: 1000";
            Assert.AreEqual(ExpectedString, ActualString);

        }
    }
}