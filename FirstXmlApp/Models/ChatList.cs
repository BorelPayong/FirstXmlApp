﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstXmlApp.Models
{
    public class ChatList
    {
        public string FullName { get; set; }

        public string Time { get; set; }

        public string Photo { get; set; }

        public string ShortMessage { get; set; }

        public ChatList()
        {

        }

        public ChatList(string fullName, string time, string photo, string shortMessage)
        {
            FullName = fullName;
            Time = time;
            Photo = photo;
            ShortMessage = shortMessage;
        }
    }
}
