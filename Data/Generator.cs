using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PornTitleGenerator.Data
{
    public static class Generator
    {

        private static readonly IDictionary<string, IEnumerable<string>> NameDatabase;
        private static readonly IDictionary<string, IEnumerable<string>> TitleDatabase;
        private static readonly IDictionary<string, IEnumerable<string>> ButtonDatabase;

        private static readonly Random Rand = new Random();

        static Generator()
        {
            NameDatabase = new Dictionary<string, IEnumerable<string>>();
            TitleDatabase = new Dictionary<string, IEnumerable<string>>();
            ButtonDatabase = new Dictionary<string, IEnumerable<string>>();

            // Names

            NameDatabase["global"] = new List<string>
            {
                "Al Caporno", "Alfred Fistcock", "Analdin", "Analice", "Anustasia",
                "Bang Hur", "Beverly Hills Cock", "Biocock", "Black Booty", "Butt Spencer", "Buttman",
                "Choke-A-Hontas", "Cliffbanger", "Cockzilla",
                "Diablow", "Dickman", "Donald Suck", "Dwayne \"The Cock\" Johnson",
                "Ejacula",
                "Ficky Mouse", "Flesh Gordon", "Forrest Cunt", "Fuckleberry Hinn", "Fucky Luke",
                "Gaylien", "Genderella", 
                "Hairy Popper",
                "Indiana Bones",
                "Jabba the Slut", "James Boned", "Jane Blond", "Jeanne d'Arm", "Jeanne d'Arsch",
                "King Dong",
                "Lawrence of Analia", "Long Dong Silver", "Long Ranger",
                "Midget Bones", "Monty's Python",
                "Peter Porn", "Pocahotass", "Pornocchio", "Preservoir Dogs",
                "Rambone", "Robin's Wood", "Robocock",
                "Screwbacca", "Shercock Holmes", "Sinderella", "Sliderman", "Snatch Adams", "Star Whores",
                "The Ass-Team", "The Big Libidowski", "The Bitcher", "The Bone Ranger", "The Flintbones",
                "The gAy Team", "The Ozporns", "The Sexorcist", "The Whores Whisperer", "Tiger's Wood",
                "Wankenstein", "Wonka's Willy"
            };

            NameDatabase["de"] = new List<string>
            {
                "Arschibald der Pornobutler",
                "Captain Schamerica", 
                "Der große Ficktator", "Der Mönch mit der Peitsche", "Die Fickinger",
                "Die Inzestbauern vom Rammlerhof", "Die Schwainzelmännchen", "Dornmöschen",
                "Graf Porno",
                "Johann Wolfgang von G-Punkt",
                "Lawrence von Analien", 
                "Mac Geiler", "Maria mag die Lena", "Moby Fick", 
                "Onan der Barbar",
                "Perverseus", 
                "Räuber Fotzenglotz", 
                "Scheidi", "Schneebitchchen", "Schneeflittchen", "Schneeritzchen", "Schwänzel und Wedel",
                "Sündbad der Seepfarrer", 
            };

            // Titles

            TitleDatabase["global"] = new List<string>
            {
                "- 21 Hump Street",
                "- A Midsummer Night's Cream", "- American Fistory", "- Analgeddon",
                "- Ass Effect", 
                "- Bangnam Style", "- Bone Voyage", "- Bonerlands", "- Boning John Malkovich",
                "- Call of Booty", "- Cocklateral Damage", "- Cuntsino Royale",
                "- Director's Fuck", "- Dongnam Style",
                "- Eyes Wide Slut",
                "- Fist Club", "- For Your Ass Only",
                "- Gay's Anatomy", "- Good Will Humping", "- Great Sexpectations",
                "- Insextion",
                "- Mass Errect", "- Metal Cock Solid", "- Modern Whorefare",
                "- Night of the giving head",
                "- Pleasure Hunt", "- Pleasure Island", "- Position Impossible", 
                "- Red Head Redemption",
                "- Sleeping Booty", "- Steppenbrand am Rosettenrand",
                "- The Fappening", "- The Porn Identity", "- The Screwman Show", "- The Sexperiment", "- The Truman Blow",
                "- The Wanking Dead", "- To Thrill A Cockingbird",
                "- Weapons of Ass Destruction", "- Whores of Warcraft",
                "and the sorcerer's bone",
                "in Diana Jones",
                "vs. Penetrator"
            };

            TitleDatabase["de"] = new List<string>
            {
                "- Alarm im Darm", "- Analstufe Rot", "- Aufstand in der Lederhose",
                "- Bundesjungfernspiele", 
                "- Darmageddon", "- Das Besteigen der Lämmer", 
                "- Der Analschlag", "- Der Pimmel über Berlin", "- Drei Schwengel für Charlie",
                "- Eine für alle, alle in einer", "- Eiskalte Schwengel", 
                "- Hör mal wer da nagelt",
                "- Im Körper des Feindes", 
                "- Jetzt wirds spritzig",
                "- Neues vom Sündenhof", 
                "- Pulp Fickschön",
                "- Sauerei auf der Bounty", "- Schamlos in Seattle", "- Schwanz der Vampire", 
                "- Skandal im Oral Office", "- Strip Langsam",
                "- Und täglich schmerzt mein Rüssel mir", "- Unterm Dirndl wird gejodelt",
                "- Unser Skatclub sticht alles!", "- Urlaub am Mösee",
                "- Wem die Stunde schleckt", 
                "bläst zum Zapfenstreich",
                "fingert Nemo",
                "im Ständerland", "in der Schwanzwald Klinik", 
                "und der Gefangene von Arschpackan", "und die Kammer des Schleckens",
                "und die wunde Schlampe",
            };

            ButtonDatabase["global"] = new List<string>()
            {
                "Push me!", "Aaaah!",
            };

            ButtonDatabase["de"] = new List<string>()
            {
                "Gib mir mehr!", "Soooo isch lässig!", "Härter!", "Fester!",
            };
        }

        public static string GetRandomName(string acceptLanguage)
        {
            return GetRandomElement(NameDatabase, acceptLanguage);
        }

        public static string GetRandomTitle(string acceptLanguage)
        {
            return GetRandomElement(TitleDatabase, acceptLanguage);
        }

        public static string GetRandomButtonText(string acceptLanguage)
        {
            return GetRandomElement(ButtonDatabase, acceptLanguage);
        }

        private static T GetRandomElement<T>(IDictionary<string, IEnumerable<T>> dictionary, string acceptLanguage)
        {
            var localized = dictionary.Where(x => acceptLanguage.Contains(x.Key)).SelectMany(x => x.Value);
            var collection = dictionary["global"].Union(localized).ToList();

            return collection.ElementAt(Rand.Next(collection.Count));
        }

    }
}