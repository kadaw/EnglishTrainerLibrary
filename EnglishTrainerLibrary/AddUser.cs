using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainerLibrary
{
    public class AddUser
    {
        public List<UserProfile> users = new List<UserProfile>();

        public void addUser(string name)
        {
            var wordId = GetNewId();
            users.Add(new UserProfile(wordId, name));
        }
        private int GetNewId()
        {
            var maxId = users.Count + 1;
            return maxId;
        }

    }
}

