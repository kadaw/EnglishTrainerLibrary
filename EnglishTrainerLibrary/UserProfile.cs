﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainerLibrary
{
    public class UserProfile
    {
       public UserProfile(int id, string name)
        {
            Id = id;
            Name = name;
            StudiedWords = new List<Words>();
        }
        public List<Words> StudiedWords;
        public int Id { get; private set; }
        public string Name { get; private set; }

    }
}
