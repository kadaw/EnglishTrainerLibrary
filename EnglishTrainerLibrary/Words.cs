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
        public Words(string word, int id)
        {
            Word = word;
            Id = id;
        }
        protected bool Equals(Words other)
        {
            return string.Equals(Id, other.Id);

        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Words)obj);
        }

    }
}
