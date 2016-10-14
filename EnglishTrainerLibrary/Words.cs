using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainerLibrary
{
    public class Words
    {
        public string Word { get; private set;}
        public int Id { get; private set; }
      //  public int maxId = 1;
        public Words(string word, int id)
        {
            Word = word;
            Id = id;
        }
        
    }
}
