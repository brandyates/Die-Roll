using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Simulates a die. Inherited from the Random class.
    /// </summary>
    class aDie : Random
    {
        /// <summary>
        /// Seed is the number used to generate the sequence of the dice roll
        /// </summary>
        public int Seed { get; set; }
        /// <summary>
        /// DieFace is the number returned to get the face of the die.
        /// </summary>
        public int DieFace { get; set; }

        /// <summary>
        /// Constructs a die.
        /// </summary>
        /// <param name="Seed"> The seed that is generated from a random roll.</param>
        public aDie()
        {
            //this.Seed = Seed;
        }

        /// <summary>
        /// Roll the dice to get a random die face.
        /// </summary>
        /// <returns>An array representing the two die faces being rolled. arr[0] = face1, arr[1] = face2. </returns>
        public int[] Roll()
        {
            int[] faces = new int[2];
            Random rand = new Random();
            int face = rand.Next(1, 7);
            int face2 = rand.Next(1, 7);
            faces[0] = face;
            faces[1] = face2;
            return faces;
        }


    }
}
