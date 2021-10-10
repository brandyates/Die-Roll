using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Simulates a die. Inherited from the <see cref="aRandomVariable"/> class.
    /// </summary>
    class aDie : aRandomVariable
    {

        /// <summary>
        /// DieFace is the number returned to get the face of the die.
        /// </summary>
        public int[] faces = new int[2];
        public int face { get; set; }
        public int face2 { get; set; }
        public int seed { get; set; }
        /// <summary>
        /// Constructs a die.
        /// </summary>
        public aDie()
        {
            rand = new Random();
        }

        /// <summary>
        /// Constructs a die with seed in mind.
        /// </summary>
        /// <param name="seed">Number used to generate random number sequence.</param>
        public aDie(int seed)
        {
            rand = new Random(seed);
        }

        /// <summary>
        /// Roll the dice to get a random die face.
        /// </summary>
        /// <returns>An array representing the two die faces being rolled. arr[0] = face1, arr[1] = face2. </returns>
        public int Roll()
        {
            face = rand.Next(1, 7);
            
            return face;
        }

        /// <summary>
        /// Rolls the dice to get a random sequence of numbers based on the seed.
        /// </summary>
        /// <param name="seed">A number used to generate the random sequence of numbers.</param>
        /// <returns> An array representing the two die faces being rolled. arr[0] = face1, arr[1] = face2. </returns>
        /*public int Roll(int seed)
        {
            face = rand_seed.Next(1, 7);
            return face;
        }*/


    }
}
