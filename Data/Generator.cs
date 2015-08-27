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
                "Choke-A-Hontas", "Cliffbanger", "Cockodile Dundee", "Cockzilla",
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
                "Rambone", "Robin Head", "Robin's Wood", "Robocock",
                "Screwbacca", "Shercock Holmes", "Sinderella", "Sliderman", "Snatch Adams", "Star Whores", "Strokemon",
                "The Analigator", "The Ass-Team", "The Big Libidowski", "The Bitcher", "The Bone Ranger", "The Flintbones",
                "The gAy Team", "The Ozporns", "The Sexorcist", "The Whores Whisperer", "Tiger's Wood",
                "Wankenstein", "Wonka's Willy"
            };

            NameDatabase["de"] = new List<string>
            {
                "Arschibald der Pornobutler",
                "Captain Rosette", "Captain Schamerica", 
                "Der große Ficktator", "Der Mönch mit der Peitsche", "Der Nervenkitzler", "Die Fickinger",
                "Die Inzestbauern vom Rammlerhof", "Die Schwainzelmännchen", "Die Speckbrigade", "Dornmöschen",
                "Graf Porno",
                "Häuptling schlaffe Feder", "Häuptling spritzender Speer", "Hausmeister Brause",
                "Johann Wolfgang von G-Punkt",
                "Lawrence von Analien", 
                "Mac Geiler", "Maria mag die Lena", "Masturbienchen", "Moby Fick", "Mu Shi",
                "Ödipussy", "Onan der Barbar",
                "Perverseus",  "Puffalo Bill",
                "Räuber Fotzenglotz", 
                "Scheidi", "Schneebitchchen", "Schneeflittchen", "Schneeritzchen", "Schwänzel und Wedel",
                "Spermarella", "Sündbad der Seepfarrer", 
                "Zacharias Eichelzupf",
            };

            NameDatabase["en"] = new List<string>
            {
                "Oedipussy",
            };

            // Titles

            TitleDatabase["global"] = new List<string>
            {
                "- 21 Hump Street",
                "- A Midsummer Night's Cream", "- American Fistory", "- Analgeddon",
                "- Ass Effect", 
                "- Bangnam Style", "- Bone Voyage", "- Bonerlands", "- Boning John Malkovich",
                "- Call of Booty", "- Cocklateral Damage", "- Cuntsino Royale",
                "- Dildorado", "- Director's Fuck", "- Dongnam Style",
                "- Eyes Wide Slut",
                "- Fill Jill", "- Fist Club", "- For Your Ass Only", "- Fuck Stop",
                "- Gay's Anatomy", "- Good Will Humping", "- Great Sexpectations",
                "- Insextion",
                "- Lord of the Strings",
                "- Mass Errect", "- Metal Cock Solid", "- Modern Whorefare",
                "- Night of the giving head",
                "- Pleasure Hunt", "- Pleasure Island", "- Pornflakes", "- Position Impossible", 
                "- Red Head Redemption",
                "- Sleeping Booty", 
                "- The Fappening", "- The Porn Identity", "- The Screwman Show", "- The Sexperiment", "- The Truman Blow",
                "- The Wanking Dead", "- To Thrill A Cockingbird",
                "- Weapons of Ass Destruction", "- Whores of Warcraft",
                "and the sorcerer's bone",
                "in Diana Jones",
                "vs. Penetrator"
            };

            TitleDatabase["de"] = new List<string>
            {
                "- Alarm im Darm", "- Alpensahne", "- Analstufe Rot", "- Auf Schloss Bumms klappern die Nüsse", 
                "- Aufstand in der Lederhose", "- Aus heiterem Pimmel",
                "- Blast die Hörner!", "- Bube sticht Dame", "- Bundesjungfernspiele", 
                "- Darmageddon", "- Das Arschiv", "- Das Besteigen der Lämmer", 
                "- Der Analschlag", "- Der Feuerbusch", "- Der Pimmel über Berlin", "- Der Weltenfummler", 
                "- Die Entsaftung des Quarterbacks",
                "- Drei Schwengel für Charlie", "- Doktorspiele",
                "- Ein Platz an der Nonne", "- Eine für alle, alle in einer", "- Eiskalte Schwengel", 
                "- Exzesse einer Nacktschwester",
                "- Frühstück bei Fickany", "- Fuckeln im Sturm",
                "- Hör mal wer da nagelt",
                "- Im ganzen Streifen keinen Steifen", "- Im Körper des Feindes", "- Invasion der Marsmösen",
                "- Jetzt wirds spritzig",
                "- Liebesspiel mit Besenstiel",
                "- Mach's mir schnell, es wird schon hell!",
                "- Nachbars Schaft", "- Neues vom Sündenhof",  "- Nicht schön, aber saugeil!",
                "- Operation Rohrfrei",
                "- Pulp Fickschön",
                "- Rhein Inn Main Po",
                "- Sauerei auf der Bounty", "- Schamlos in Seattle", "- Schwanz der Vampire", "- She-M@le für dich",
                "- Skandal im Oral Office", "- Spermacolada", "- Spermal den Mund auf", "- Spritzgebäck", "- Steppenbrand am Rosettenrand",
                "- Stoßgebete", "- Strip Langsam",
                "- Trommelfeuer aus der Sackkanone",
                "- Und täglich schmerzt mein Rüssel mir", "- Unterm Dirndl wird gejodelt",
                "- Unser Skatclub sticht alles!", "- Urlaub am Mösee",
                "- Wem die Stunde schleckt", 
                "- Wir kommen schon!",
                "- Zapf-Säue",
                "bläst zum Zapfenstreich",
                "fingert Nemo",
                "im Schleckerland", "im Ständerland", "im Vögelschutzgebiet", "in der Wichstumsphase", "in der Schwanzwald Klinik", 
                "und der Gefangene von Arschpackan", "und die Kammer des Schleckens", "und die Spermatologin", 
                "und die Vögelgrippe", "und die wunde Schlampe",
            };

            TitleDatabase["en"] = new List<string>
            {
                "- You've Got She-M@le",
            };

            ButtonDatabase["global"] = new List<string>
            {
                "Push me!", "Aaaah!", "Who's your daddy?", "Yes! Right there!",
            };

            ButtonDatabase["de"] = new List<string>
            {
                "Gib mir mehr!", "Soooo isch lässig!", "Härter!", "Fester!", "Joooo!",
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