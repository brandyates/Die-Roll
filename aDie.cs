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
        public aDie(int Seed)
        {
            this.Seed = Seed;
        }

        /// <summary>
        /// Roll the dice to get a random die face.
        /// </summary>
        /// <returns>An int representing the die face. </returns>
        public int Roll()
        {
            Random rand = new Random();
            int face = rand.Next(1, 7);
            return face;
        }


    }
}
