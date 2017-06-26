﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayniteServices.Models.Playnite
{
    public class User
    {
        [BsonId(false)]
        [BsonIndex(true)]
        public string Id
        {
            get; set;
        }

        public string WinVersion
        {
            get; set;
        }

        public string PlayniteVersion
        {
            get; set;
        }

        public DateTime LastLaunch
        {
            get; set;
        }
    }
}
