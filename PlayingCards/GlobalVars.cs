using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCards
{
    internal static class GlobalVars
    {
        private static int aceRank = 14;
        private static int highestCard = 14;
        private static int lowestCard = 2;

        public static int AceRank
        {
            get { return aceRank; }
            set { aceRank = value; }
        }

        public static int HighestCard
        {
            get { return highestCard; }
            set { highestCard = value; }
        }

        public static int LowestCard
        {
            get { return lowestCard; }
            set { lowestCard = value; }
        }
    }
}