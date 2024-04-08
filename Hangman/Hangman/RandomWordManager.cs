namespace Hangman
{
    using System;

    /// <summary>
    /// Manages choosing a random word for playing hangman
    /// </summary>
    public class RandomWordManager
    {
        private Random RandomPick;
        private string[] words = new string[]
    {
        "zenith",
        "zephyr",
        "tennis",
        "information",
        "courier",
        "basketball",
        "distinction",
        "telephone",
        "hardship",
        "congressional",
        "fulfillment",
        "courtesy",
        "banana",
        "programmer",
        "canopy",
        "friendship",
        "heaven",
        "chocolate",
        "helicopter",
        "financial",
        "integration",
        "lightheaded",
        "mountainside",
        "snowflake",
        "socialism",
        "monarchy",
        "lucrative",
        "bibliography",
        "television",
        "radiology",
        "peppermint",
        "parakeet",
        "circulation",
        "anatomical",
        "zeppelin",
        "xylophone",
        "sequester",
        "cantaloupe",
        "bonanza",
        "beekeeper",
        "volleyball",
        "massage",
        "cheetah",
        "environmental",
        "horsdoeuvre",
        "flashlight",
        "butterfly",
        "lightweight",
        "extraordinary",
        "hardship",
        "salamander",
        "salesmanship",
        "gigantic",
        "metamorphosis",
        "popularity",
        "punctuation",
        "masquerade",
        "footloose",
        "fellowship",
        "immigration",
        "knowledge"
    };

        public RandomWordManager()
        {
            DateTime aTime = new DateTime(1000);
            aTime = DateTime.Now;
            int nSeed = (int)(aTime.Millisecond);
            RandomPick = new Random(nSeed);
            // 
            // TODO: Add Constructor Logic here
            //
        }

        public string Pick()
        {
            string newword = "";
            int index = (int)(RandomPick.NextDouble() * words.GetUpperBound(0));
            newword = words[index];
            newword = newword.ToUpper();
            return newword;
        }
    }
}
