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
        Words randEngWord;
        public int randWordId;
        FileSystem fileSystem = new FileSystem("UsersProfiles.txt");
        public Training(string pathForEngFileSystem)
        {
            FileSystem fileSystem = new FileSystem("UsersProfiles.txt");
            List<Words> randWords = ReturnRandWords("BaseOfEngWords.txt", "BaseOfRusWords.txt");

       
        }
        public List<Words> ReturnRandWords(string pathForEngWords, string pathForRusWords)
        {
            
            List<Words> engWords = new List<Words>();
            List<Words> rusWords = new List<Words>();
            List<Words> randWords = new List<Words>();
            //  pathForEngWords = "BaseOfEngWords.txt";//убрать в финальной версии
            //  pathForRusWords = "BaseOfRusWords.txt";//убрать в финальной версии
            fileSystem.LoadedEngWords(pathForEngWords, engWords);
            fileSystem.LoadedRusWords(pathForRusWords, rusWords);
            repeat:
            randEngWord = engWords[new Random().Next(0, engWords.Count - 1)];
            Words randRusWord = rusWords[new Random().Next(0, rusWords.Count - 1)];
            for (int i = 0; i < fileSystem.ThisUser.StudiedWords.Count+1; i++)
            {
                if (randEngWord.Equals(fileSystem.ThisUser.StudiedWords[i]))
                {
                    if (randEngWord.Equals(randRusWord))
                    {
                        rightAnswer = true;
                    }
                    else rightAnswer = false;
                    randWords.Add(randEngWord);
                    randWords.Add(randRusWord);
                }
                else
                {
                    goto repeat;
                }
            }
            return randWords;
        }


        public bool CheckAnswer(bool answer)
        {
            if (answer==rightAnswer)
            {
                fileSystem.ThisUser.StudiedWords.Add(randEngWord);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
