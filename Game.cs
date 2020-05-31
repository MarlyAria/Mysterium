using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysterium
{
    class Game : Cards, ICardDraw, IStory
    {


        Random r = new Random();
        int Difficulty;
        int Psychics;
        int CharacterArrayCards;




        /*
    // Init an array with set 1, 2, and 3.
    int[] nums = { 1, 2, 3 };DONE
    Solution solution = new Solution(nums); DONE

    // Shuffle the array [1,2,3] and return its result. Any permutation of [1,2,3] must equally likely to be returned.
    solution.shuffle();

// Resets the array back to its original configuration [1,2,3].
solution.reset();

// Returns the random shuffling of array [1,2,3].
solution.shuffle();
*/
        /* 2 = 4,5,6
* 3 = 5,6,7
* 4 = 5,6,7
* 5 = 6,7,8
* 6 = 7,8,9
* 7 = 8,9,10
 */


        public void DrawCharacter()
        {
          
            //easy game
            if (Difficulty == 0)
            {
                //code voor de kaarten trekken
                CharacterArray = CharacterArray.OrderBy(x => r.Next()).ToArray();
                if (Psychics == 1)
                {
                    for (int i = 3; i < CharacterArray.Length; i++)
                    {
                        Console.WriteLine(CharacterArray[i]);
                    }
                }
                if (Psychics == 2)
                {
                    for (int i = 4; i < CharacterArray.Length; i++)
                    {
                        Console.WriteLine(CharacterArray[i]);
                    };
                }
                if (Psychics == 3)
                {
                    for (int i = 5; i < CharacterArray.Length; i++)
                    {
                        Console.WriteLine(CharacterArray[i]);
                    };
                }
                if (Psychics == 4)
                {
                    for (int i = 6; i < CharacterArray.Length; i++)
                    {
                        Console.WriteLine(CharacterArray[i]);
                    };
                }
                if (Psychics == 5)
                {
                    for (int i = 7; i < CharacterArray.Length; i++)
                    {
                        Console.WriteLine(CharacterArray[i]);
                    };
                }
                if (Psychics == 6)
                {
                    for (int i = 8; i < CharacterArray.Length; i++)
                    {
                        Console.WriteLine(CharacterArray[i]);
                    }; ;
                }
            }

        }

        public void DrawLocation()
        {
            throw new NotImplementedException();
        }

        public void DrawChoice()
        {
            throw new NotImplementedException();
        }

        void IStory.DrawChoise()
        {
            throw new NotImplementedException();
        }
    }
}
