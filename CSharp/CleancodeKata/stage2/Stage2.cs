namespace CleancodeKata.stage2
{
    /**
     * Refactor until there is no else, you think the code is clean, and all the tests pass.
     */
    public class Stage2
    {
        public static int ComputeScore(int dice1, int dice2, int dice3)
        {
            if (AllAreEqual(dice1, dice2, dice3))
            {
                return 0;
            }

            if (dice1 == 1 && dice2 == 2 && dice3 == 3 ||
                dice1 == 1 && dice2 == 3 && dice3 == 2 ||
                dice1 == 2 && dice2 == 1 && dice3 == 3 ||
                dice1 == 2 && dice2 == 3 && dice3 == 1 ||
                dice1 == 3 && dice2 == 1 && dice3 == 2 ||
                dice1 == 3 && dice2 == 2 && dice3 == 1)
            {
                return 100;
            }

            int score = dice1 + dice2 + dice3;
            if (AtLeastOnePairIsEqual(dice1, dice2, dice3))
            {
                score *= 2;
            }
            return score;
        }

        private static bool AllAreEqual(int dice1, int dice2, int dice3)
        {
            return dice1 == dice2 && dice1 == dice3;
        }

        private static bool AtLeastOnePairIsEqual(int dice1, int dice2, int dice3)
        {
            return dice1 == dice2 || dice2 == dice3 || dice1 == dice3;
        }
    }
}