﻿namespace Caravan.Logic
{
    public class Camel : PackAnimal
    {
        /// <summary>
        /// Kamel mit Maximalgeschwindigkeit 20 erzeugen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="maxPace"></param>
        public Camel(string name, int maxPace)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Geschwindigkeit in Abhängigkeit der Ladung (Reduktion um 1 je Ballen)
        /// </summary>
        public override int Pace
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
