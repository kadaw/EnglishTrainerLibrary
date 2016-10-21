using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EnglishTrainerLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EqualsTest()
        {
            FileSystem fileSystem = new FileSystem("UsersProfiles.txt");
            List<Words> engWords = new List<Words>();
            List<Words> rusWords = new List<Words>();
            fileSystem.LoadedEngWords("BaseOfEngWords.txt", engWords);
            fileSystem.LoadedRusWords("BaseOfRusWords.txt", rusWords);
            
            Assert.AreEqual(engWords[2], rusWords[2]);
        }
        [TestMethod]
        public void TrainingTest()
        {
            List<Words> randWords = new List<Words>();
            Training TestTraining = new Training("UsersProfiles.txt");
            randWords = TestTraining.ReturnRandWords("BaseOfEngWords.txt", "BaseOfRusWords.txt");
            Assert.AreEqual(randWords[0], randWords[1]); }
        [TestMethod]
        public void CheckAnswerTest()
        {
            Training TestTraining = new Training("UsersProfiles.txt");
            TestTraining.rightAnswer = false;
            var equal = TestTraining.CheckAnswer(false);
            var rightEqual = true;
            Assert.AreEqual(rightEqual, equal);
        }
    }
}
