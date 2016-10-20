using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainerLibrary
{
    public class AddWord
    {
        public List<Words> engWords = new List<Words>();
        public List<Words> rusWords = new List<Words>();

        public void addWord(string engWord, string rusWord)
        {
            var wordId = GetNewId();
            engWords.Add(new Words(engWord, wordId));
            rusWords.Add(new Words(rusWord, wordId));
        }
                private int GetNewId()
        {
                    var maxId = engWords.Count + 1;
                    return maxId;
        }

    }
}
