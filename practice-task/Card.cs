using System;

namespace practice_task
{
    class Card
    {
        public string name { get; set; }
        public string suit { get; set; }
        public int value { get; set; }
        public Card(string pName, string pSuit, int pValue)
        {
            name = pName;
            suit = pSuit;
            value = pValue;
        }
    }
}
