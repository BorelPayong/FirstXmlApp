using FirstXmlApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstXmlApp.VieuwModels
{
    public class ChatListVieuwModels
    {
        private readonly List<ChatList> items;

        public ChatListVieuwModels()
        {
            items = new List<ChatList>
            {
                new ChatList("Franck", "15:04", "/Assets/1.png", "tu es ou?? le teacher te...")
            };
        }

        public IEnumerable<ChatList> Getitems()
        {
            return items;
        }
    }
}
