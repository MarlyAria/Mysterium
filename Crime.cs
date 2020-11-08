using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysterium
{
    class Crime
    {
        public CharacterCard characterCard { get; set; }
        public LocationCard locationCard { get; set; }
        public ObjectCard objectCard { get; set; }
                
        public Crime
            (CharacterCard characterC, LocationCard locationC, ObjectCard objectC)
        {
            
            this.characterCard = characterC;
            this.locationCard = locationC;
            this.objectCard = objectC;
            
        }

        public Crime()
        {
        }
    }
}
