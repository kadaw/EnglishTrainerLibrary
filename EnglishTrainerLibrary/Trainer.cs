using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainerLibrary
{
    public class Training
    {
       
        public bool rightAnswer;
        public Training(string pathForEngFileSystem)
        {
            FileSystem fileSystem = new FileSystem("UsersProfiles.txt");
       
        }
        public List<Words> ReturnRandWords(string pathForEngWords, string pathForRusWords)
        {
            FileSystem fileSystem = new FileSystem("UsersProfiles.txt");
            List<Words> engWords = new List<Words>();
            List<Words> rusWords = new List<Words>();
            //  pathForEngWords = "BaseOfEngWords.txt";//убрать в финальной версии
            //  pathForRusWords = "BaseOfRusWords.txt";//убрать в финальной версии
            fileSystem.LoadedEngWords(pathForEngWords, engWords);
            fileSystem.LoadedRusWords(pathForRusWords, rusWords);
            Words randEngWord = engWords[new Random().Next(0, engWords.Count - 1)];
            Words randRusWord = rusWords[new Random().Next(0, rusWords.Count - 1)];
            if (randEngWord.Equals(randRusWord))
            {
                rightAnswer = true;
            }
            else rightAnswer = false;
            List<Words> randWords = new List<Words>();
            randWords.Add(randEngWord);
            randWords.Add(randRusWord);
            return randWords;
        }


        public bool CheckAnswer(bool answer)
        {
            if (answer==rightAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
