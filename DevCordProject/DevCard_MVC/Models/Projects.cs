using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Projects
    {
        public Projects(long id, string name, string descroption, string client, string img)
        {
            Id = id;
            Name = name;
            Descroption = descroption;
            Client = client;
            Img = img;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Descroption { get; set; }
        public string Client { get; set; }
        public string Img { get; set; }
    }
}
