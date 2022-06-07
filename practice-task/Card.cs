using System;

namespace practice_task
{
    public class Card
    {
        public string suit { get; set; }
        public string name { get; set; }
        public int value { get; set; }
        public Card(string pSuit, string pName, int pValue)
        {
            suit = pSuit;
            name = pName;
            value = pValue;
        }
    }
}
