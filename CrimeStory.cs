using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysterium
{
    class CrimeStory
    {
        public CharacterCard characterCard { get; set; }
        public LocationCard locationCard { get; set; }
        public StoryCard storyCard { get; set; }

        public CrimeStory
            (CharacterCard characterC, LocationCard locationC, StoryCard storyC)
        {

            this.characterCard = characterC;
            this.locationCard = locationC;
            this.storyCard = storyC;

        }
    }
}
