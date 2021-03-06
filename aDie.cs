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
        /// Represents the random number that represents the die face.
        /// </summary>
        private int face { get; set; }

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
        /// <returns>A random number that is next in the seed. </returns>
        public int Roll()
        {
            //get the next random number in the sequence
            face = rand.Next(1, 7);
            
            return face;
        }




    }
}
