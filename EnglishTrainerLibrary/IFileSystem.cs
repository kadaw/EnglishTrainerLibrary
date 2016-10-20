using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainerLibrary
{
    public interface IFileSystem
    {
        void LoadedUsers(string path, List<UserProfile> Users);
        void LoadedEngWords(string path, List<Words> engWords);
        void LoadedRusWords(string path, List<Words> rusWords);

    }
}
