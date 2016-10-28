using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainerLibrary
{
   public class FileSystem
    {
       public int count;
        public UserProfile ThisUser;
        public FileSystem(string path)
        {
            string storage = File.ReadAllText(path);
            List<UserProfile> listOfUsers = JsonConvert.DeserializeObject<List<UserProfile>>(storage);
        }
        public void LoadUsers(string path, List<UserProfile> Users)
        {
            string storage = File.ReadAllText(path);
            List<UserProfile> listOfUsers = JsonConvert.DeserializeObject<List<UserProfile>>(storage);

            for (int i = 0; i < listOfUsers.Count; i++)
            {
                Users.Add(listOfUsers[i]);
            }
        }
        public void LoadedEngWords(string path, List<Words> engWords)
        {
            StreamReader streamReader = new StreamReader(path);
            string engWord = "";
            string str = "";
            while (!streamReader.EndOfStream)
            {
                str = streamReader.ReadLine();
                engWord = str.Substring(0, str.IndexOf("!"));
                var id = engWords.Count + 1;
                engWords.Add(new Words(engWord, id));

            }
        }
        public void LoadedRusWords(string path, List<Words> rusWords)
        {
            StreamReader streamReader = new StreamReader(path);
            string rusWord = "";
            string str = "";
            while (!streamReader.EndOfStream)
            {
                str = streamReader.ReadLine();
                rusWord = str.Substring(0, str.IndexOf("!"));
                var id = rusWords.Count + 1;
                rusWords.Add(new Words(rusWord, id));

            }
        }
        public void Registrtion(string path, string name)
        {
            string storage = File.ReadAllText(path);
            List<UserProfile> listOfUsers = JsonConvert.DeserializeObject<List<UserProfile>>(storage);
            var id = listOfUsers.Count+1;
            listOfUsers.Add(new UserProfile(id, name));
            ThisUser = listOfUsers[id];
        }
        public void Identification(string path, int id)
        {
            string storage = File.ReadAllText(path);
            List<UserProfile> listOfUsers = JsonConvert.DeserializeObject<List<UserProfile>>(storage);
            if (id < listOfUsers.Count)
            {
                ThisUser = listOfUsers[id];
            }
        }




    }
}
