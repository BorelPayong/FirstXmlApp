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
                new ChatList("Franck", "15:04", "/Assets/1.png", "tu es ou?? le teac falla ici..."),
                new ChatList("loic", "12:34", "/Assets/2.jpg", "tu es ou?? le teacher te falla ici..."),
                new ChatList("harold", "01:04", "/Assets/3.PNG", "tu es ou?? leerte falla ici..."),
                new ChatList("ronyl", "05:34", "/Assets/4.png", "tu es ou?? le cherte falla ici..."),
                new ChatList("maitre", "10:09", "/Assets/1.png", "tu es  le teacher te falla ici..."),
                new ChatList("pegy", "19:07", "/Assets/2.jpg", " ou?? le teacher te falla ici..."),
                new ChatList("raph", "20:44", "/Assets/3.PNG", "tu es ou?? le teacher te ..."),
                new ChatList("ethan", "23:14", "/Assets/4.png", "tu es  teacher te falla ici..."),
                new ChatList("Franck", "15:04", "/Assets/1.png", "tu es ou?? le teac falla ici..."),
                new ChatList("loic", "12:34", "/Assets/2.jpg", "tu es ou?? le teacher te falla ici..."),
                new ChatList("harold", "01:04", "/Assets/3.PNG", "tu es ou?? leerte falla ici..."),
                new ChatList("ronyl", "05:34", "/Assets/4.png", "tu es ou?? le cherte falla ici..."),
                new ChatList("maitre", "10:09", "/Assets/1.png", "tu es  le teacher te falla ici..."),
                new ChatList("pegy", "19:07", "/Assets/2.jpg", " ou?? le teacher te falla ici..."),
                new ChatList("raph", "20:44", "/Assets/3.PNG", "tu es ou?? le teacher te ..."),
                new ChatList("ethan", "23:14", "/Assets/4.png", "tu es  teacher te falla ici..."),
                new ChatList("Franck", "15:04", "/Assets/1.png", "tu es ou?? le teac falla ici..."),
                new ChatList("loic", "12:34", "/Assets/2.jpg", "tu es ou?? le teacher te falla ici..."),
                new ChatList("harold", "01:04", "/Assets/3.PNG", "tu es ou?? leerte falla ici..."),
                new ChatList("ronyl", "05:34", "/Assets/4.png", "tu es ou?? le cherte falla ici..."),
                new ChatList("maitre", "10:09", "/Assets/1.png", "tu es  le teacher te falla ici..."),
                new ChatList("pegy", "19:07", "/Assets/2.jpg", " ou?? le teacher te falla ici..."),
                new ChatList("raph", "20:44", "/Assets/3.PNG", "tu es ou?? le teacher te ..."),
                new ChatList("ethan", "23:14", "/Assets/4.png", "tu es  teacher te falla ici...")
            };
        }

        public IEnumerable<ChatList> Getitems()
        {
            return items;
        }
    }
}
