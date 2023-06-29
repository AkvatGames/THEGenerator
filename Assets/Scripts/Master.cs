using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{

    //Toggle lockToggle;
    public Text genreLockText;
    public Text rulesLockText;
    public Text placeLockText;
    public Text objectiveLockText;
    public Text wildcardLockText;
    //public Text perspectiveText;

    public Text genreContainerData;
    public Text rulesContainerData;
    public Text placeContainerData;
    public Text objectiveContainerData;
    public Text wildcardContainerData;
    public Text perspectiveContainerData;

    public Dropdown perspectiveDrop;

    public GameObject theperspectiveGO;
    public GameObject theGenreGO;
    public GameObject theRulesGO;
    public GameObject thePlaceGO;
    public GameObject theObjectiveGO;
    public GameObject theWildcardGO;


    public Toggle perspectiveToggle;
    public Toggle genreLockToggle;
    public Toggle rulesLockToggle;
    public Toggle placeLockToggle;
    public Toggle objectiveLockToggle;
    public Toggle wildcardLockToggle;


    public Animator sentenceAnim = null;

    public SentenceGenerator sentenceGenerator;

    private int numberGrabber;
    System.Random random = new System.Random();

    //public ToggleRocker toggleRocker;
    public TheLocks theLocks;
    //bool isLocked;

    
    string[] enemyTypes = new string[]
{
                "zombies",
                "mercenaries",
                //"police",
                "criminals",
                "gangsters",
                //"Karens",
                "monsters",
                "werewolves",
                "dinosaurs",
                "zombies",
                "mercenaries",
                //"police",
                "criminals",
                "gangsters",
                //"Karens",
                "monsters",
                "werewolves",
                "dinosaurs",
                "zombies",
                "mercenaries",
                //"police",
                "criminals",
                "gangsters",
                //"Karens",
                "monsters",
                "werewolves",
                "dinosaurs",
                "zombies",
                "mercenaries",
                //"police",
                "criminals",
                "gangsters",
                //"Karens",
                "monsters",
                "werewolves",
                "dinosaurs",
                "zombies",
                "mercenaries",
                //"police",
                "criminals",
                "gangsters",
                //"Karens",
                "monsters",
                "werewolves",
                "dinosaurs",
                "evil mega corporations",
                "crawling enemies",
                "flying enemies",
                //"charging enemies",
                "long range enemies",
                "brawler enemies",
                "explosive enemies",
                "enemies",
                "grunt enemies",
                "boss'",
                "boss'",
                "crawling enemies",
                "flying enemies",
                //"charging enemies",
                "long range enemies",
                "brawler enemies",
                "explosive enemies",
                "long range enemies",
                "brawler enemies",
                "explosive enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "enemies",
                "grunt enemies",
                "boss'",
                "boss'",
};
    
    string[] itemTypes = new string[]
{
                "coins",
                "crystals",
                "coins",
                "crystals",
                "coins",
                "crystals",
                "coins",
                "crystals",
                "souls",
                "coins",
                "crystals",
                "souls", "coins",
                "crystals",
                "souls",
                "shards",
                "items",
                "bananas",
                "apples",
                "cakes",
                "waffles",
                "cartons of milk",
                "letters",
                "packages",
                "computers",
                "messages",
                "letters",
                "packages",
                "computers",
                "messages",
                "letters",
                "packages",
                "computers",
                "messages",
                "audio logs",
                "audio logs",
                "audio logs",
                "audio logs",
                "dogs",
                "cats",
                "birds",
                "animals",
                "photos",
                "books",
                "swords",
                "shields",

};
    
    string[] pOITypes = new string[]
{
                "castles",
                "houses",
                "caves",
                "caverns",
                "temples",
                "temples",
                "temples",
                "meadows",
                "towns",
                "generators",
                "offices",
                "portals",
                "tombs",
                "portals",
                "tombs",
                "portals",
                "tombs",
                "portals",
                "tombs",
                "portals",
                "tombs",
                "wells",
                "rooms",
                "towers",
                "monuments",
                "buildings",
                "shops",
                "towers",
                "monuments",
                "buildings",
                "shops",
                "towers",
                "monuments",
                "buildings",
                "shops",

};

    string[] measurementTypes = new string[]
{
                "miles",
                "meters",
                "yards",
                "miles",
                "meters",
                "yards",
                "units",
};

    string[] timeTypes = new string[]
{
                "hours",
                "days",
                "hours",
                "days",
                "hours",
                "days",
                "minutes",
                "seconds",
                "years",
};

    string[] environments = new string[]
{
                "in the grasslands",
                "in the rainforest",
                "in the desert",
                "in the mountains",
                "in the swamp",
                "in the tundra",
                "in outter space",
                "on an alien planet",
                "in city hall",
                "in the subway",
                "in a city",
                "in a town",
                "in a suburban town",
                "on a moving train",
                "at a train station",
                "at an airport",
                "at the docks",
                "in a cargo yard",
                "in the slums",
                "in a nuclear fallout",
                "in a post apocalyptic world",
                "in an airport",
                "in a forest",
                "underwater",
                "in a space ship",
                "in a space station",
                "in a submarine",
                "in a tower",
                "in a castle",
                "in a hotel",
                "in a motel",
                "in an apartment",
                "in an apartment building",
                "in a high rise",
                "on a boat",
                "on a cargo ship",
                "on a beach",
                "at a sporting event",
                "on an airplane",
                "underground",
                "in the clouds",
                "in a flying city",
};

    string[] genres = new string[]
{
                "action",
                "adventure",
                "action",
                "adventure",
                "action",
                "adventure",
                "action",
                "adventure",
                "action",
                "adventure",
                "action",
                "adventure",
                "drama",
                "horror",
                "horror",
                "horror",
                "comedy",
                "science fiction",
                "western",
                "thriller",
                "crime drama",
                "science fiction",
                "western",
                "thriller",
                "crime drama",
                "science fiction",
                "western",
                "thriller",
                "crime drama",
                "romantic",
                "narrative based",
                "historical",
                "noir",
                "fantasy",
                "fairytale",
                "mystery",
                "noir",
                "fantasy",
                "fairytale",
                "mystery",
                "noir",
                "fantasy",
                "fairytale",
                "mystery",
                "war centric",
                "experimental",
                "slasher",
                "martial arts",
                "experimental",
                "slasher",
                "martial arts",
                "dark comedy",
                "gangster",
                "silent",
                "comedy horror",
                "educational",
};


    void Awake()
    {
        string[] perspectives = new string[]
        {

        };

        //isLocked = theLocks.isLocked;
        sentenceGenerator = GetComponent<SentenceGenerator>();

        //add this back in later
        /*

        //Fetch the Toggle GameObjects
        //lockToggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, and output the state
        genreLockToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(genreLockToggle);
        });
        rulesLockToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(rulesLockToggle);
        });
        placeLockToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(placeLockToggle);
        });
        objectiveLockToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(objectiveLockToggle);
        });
        wildcardLockToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(wildcardLockToggle);
        });

        //Initialize the Text to say whether the Toggle is in a positive or negative state
        if (genreLockToggle.isOn == true)
        {
            genreLockText.text = "Locked";
    
        }
        else
        {
            genreLockText.text = "Unlocked";
            genreLockToggle.isOn = false;
        }
        if (rulesLockToggle.isOn == true)
        {
            rulesLockText.text = "Locked";
        }
        else
        {
            rulesLockText.text = "Unlocked";
            rulesLockToggle.isOn = false;
        }
        if (placeLockToggle.isOn == true)
        {
            placeLockText.text = "Locked";
        }
        else
        {
            placeLockText.text = "Unlocked";
            lockToggle.isOn = false;
        }
        if (objectiveLockToggle.isOn == true)
        {
            objectiveLockText.text = "Locked";
        }
        else
        {
            objectiveLockText.text = "Unlocked";
            lockToggle.isOn = false;
        }
        if (wildcardLockToggle.isOn == true)
        {
            wildcardLockText.text = "Locked";
        }
        else
        {
            wildcardLockText.text = "Unlocked";
            lockToggle.isOn = false;
        }
        */


    }
    

    /*
        //Output the new state of the Toggle into Text when the user uses the Toggle
        public void ToggleValueChanged(Toggle change)
    {
        if (genreLockToggle.isOn == true)
        {
            genreLockText.text = "Locked";

        }
        else
        {
            genreLockText.text = "Unlocked";
            genreLockToggle.isOn = false;
        }
        if (rulesLockToggle.isOn == true)
        {
            rulesLockText.text = "Locked";
        }
        else
        {
            rulesLockText.text = "Unlocked";
            rulesLockToggle.isOn = false;
        }
        if (placeLockToggle.isOn == true)
        {
            placeLockText.text = "Locked";
        }
        else
        {
            placeLockText.text = "Unlocked";
            lockToggle.isOn = false;
        }
        if (objectiveLockToggle.isOn == true)
        {
            objectiveLockText.text = "Locked";
        }
        else
        {
            objectiveLockText.text = "Unlocked";
            lockToggle.isOn = false;
        }
        if (wildcardLockToggle.isOn == true)
        {
            wildcardLockText.text = "Locked";
        }
        else
        {
            wildcardLockText.text = "Unlocked";
            lockToggle.isOn = false;
        }
    }
    */
    
    /*
    public void Unlock()
    {
        if (lockToggle.isOn == false)
        {
            lockToggle.isOn = false;
        }
        else
        {
            lockToggle.isOn = true;
        }
    }
    */

    //public void EnemyTypeGenerator()
    //{

    //if (isLocked == false)
    //{
    //wildcard generator
    //setup wildcard list
    //numberGrabber = Random.Range(0, );


    //print(pickWildcard);
    //}
    //}

    //public void playClip()
    //{
    //    audioSource.clip = audioClip;
    //    audioSource.Play();
    //}

    public void GenerateAll()
    {
        
        StartCoroutine(Generator());
        /*
        if(isLocked == false)
        {

            EnvironmentGenerator();
            GoalsGenerator();
            GenreGenerator();
            RulesGenerator();
            WildcardGenerator();
            //sentence.TheSentence();
            //playClip();
        }
        */
    }

    public void EnvironmentGenerator()
    {
        //toggleRocker.lockText.text = placeLockText.text;
        //bool isLocked = theLocks.isLocked;
        //env generator
        //setup env list
        if (placeLockText.text == "Unlocked")
        {
            numberGrabber = Random.Range(2, 100);

            int useEnvironments = random.Next(environments.Length);
            string pickEnvironments = environments[useEnvironments];
            placeContainerData.text = environments[useEnvironments];
            //print(pickEnvironments);
        }
    }

    public void PerspectiveGenerator()
    {
        //if (theLocks.lockText.text == "Unlocked")
        //{
        string[] perspectives = new string[]
{
                "first person",
                "first person",
                "first person",
                "first person",
                "first person",
                "first person",
                "first person",
                "first person",
                "first person",
                "first person",
                "first person",
                "third person",
                "third person",
                "third person",
                "third person",
                "third person",
                "third person",
                "third person",
                "third person",
                "third person",
                "third person",
                "third person",
                "top down",
                "top down",
                "top down",
                "top down",
                "top down",
                "top down",
                "top down",
                "top down",
                "side scrolling",
                "side scrolling",
                "side scrolling",
                "side scrolling",
                "side scrolling",
                "side scrolling",
                "side scrolling",
                "side scrolling",
                "side scrolling",
                "text based",
};
            //playClip();
            //genre generator
            //setup genres list
            //numberGrabber = Random.Range(2, 100);

            int usePerspectives = random.Next(perspectives.Length);
            string pickPerspectives = perspectives[usePerspectives];
            perspectiveContainerData.text = perspectives[usePerspectives];
            //print(pickGenres);
        //}
    }

    public void GenreGenerator()
    {
        //bool isLocked = theLocks.isLocked;
        if (genreLockText.text == "Unlocked")
        {
            //playClip();
            //genre generator
            //setup genres list
            numberGrabber = Random.Range(2, 100);

            int useGenres = random.Next(genres.Length);
            string pickGenres = genres[useGenres];
            genreContainerData.text = genres[useGenres];
            //print(pickGenres);
        }
    }

    public void GoalsGenerator()
    {
        //bool isLocked = theLocks.isLocked;
        this.theLocks.lockText.text = objectiveLockText.text;
        if (objectiveLockText.text == "Unlocked")
        {
            //playClip();
            //setup enemy types
            int useEnemyTypes = random.Next(enemyTypes.Length);
            string pickEnemyTypes = enemyTypes[useEnemyTypes];

            //setup item types
            int useItemTypes = random.Next(itemTypes.Length);
            string pickItemTypes = itemTypes[useItemTypes];

            //setup POI types
            int usePOITypes = random.Next(pOITypes.Length);
            string pickPOITypes = pOITypes[usePOITypes];

            //setup easurement types
            int useMeasurementTypes = random.Next(measurementTypes.Length);
            string pickMeasurementTypes = measurementTypes[useMeasurementTypes];

            numberGrabber = Random.Range(2, 50);

            string[] goals = new string[]
            {
                //make collect show more often
                "collect " + numberGrabber + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber * 2 + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber * 2 + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber * 2 + " " + itemTypes[useItemTypes],
                "collect " + numberGrabber * 2 + " " + itemTypes[useItemTypes],



                "locate " + numberGrabber + " " + itemTypes[useItemTypes],
                "locate all " + itemTypes[useItemTypes],
                "kill all " +  enemyTypes[useEnemyTypes],
                "locate all " + itemTypes[useItemTypes],
                "kill all " +  enemyTypes[useEnemyTypes],
                "locate all " + itemTypes[useItemTypes],
                "kill all " +  enemyTypes[useEnemyTypes],
                "kill " + numberGrabber + " " +  enemyTypes[useEnemyTypes],
                "talk to " + numberGrabber + " " +  enemyTypes[useEnemyTypes],
                "locate " + numberGrabber + " " +  enemyTypes[useEnemyTypes],
                "destroy all " + enemyTypes[useEnemyTypes],
                "destroy all " + pOITypes[usePOITypes],
                "destroy all " + itemTypes[useItemTypes],
                "destroy all " + enemyTypes[useEnemyTypes],
                "destroy all " + pOITypes[usePOITypes],
                "destroy all " + itemTypes[useItemTypes],
                "destroy all " + enemyTypes[useEnemyTypes],
                "destroy all " + pOITypes[usePOITypes],
                "destroy all " + itemTypes[useItemTypes],
                "destroy all " + enemyTypes[useEnemyTypes],
                "destroy all " + pOITypes[usePOITypes],
                "destroy all " + itemTypes[useItemTypes],
                "destroy " + numberGrabber + " " + enemyTypes[useEnemyTypes],
                //"travel " + numberGrabber * Random.Range(1,15) + " " + measurementTypes[useMeasurementTypes],
                //"fly " + numberGrabber * Random.Range(1,15) + " " + measurementTypes[useMeasurementTypes],
                //"drive " + numberGrabber * Random.Range(1,15) + " " + measurementTypes[useMeasurementTypes],
                "run " + numberGrabber * Random.Range(1,15) + " " + measurementTypes[useMeasurementTypes],
                "walk " + numberGrabber * Random.Range(1,15) + " " + measurementTypes[useMeasurementTypes],
                //"stalk " + enemyTypes[useEnemyTypes] + " " + numberGrabber * Random.Range(1,15) + " " + measurementTypes[useMeasurementTypes],
                "explore " + numberGrabber / 2 + " " + pOITypes[usePOITypes],
            };
            int useGoals = random.Next(goals.Length);
            string pickGoals = goals[useGoals];
            objectiveContainerData.text = goals[useGoals];
            //print(pickGoals);
        }
    }

    public void RulesGenerator()
    {
        //bool isLocked = theLocks.isLocked;
        
        if (rulesLockText.text == "Unlocked")
        {
            //playClip();
            numberGrabber = Random.Range(2, 100);
            string[] rules = new string[]
            {
                "point & click game",
                "platformer",
                "shooter",
                "platformer",
                "shooter",
                "platformer",
                "platformer",
                "shooter",
                "platformer",
                "shooter",
                "shooter",
                "platformer",
                "shooter",
                "platformer",
                "shooter",
                "platformer",
                "platformer",
                "shooter",
                "platformer",
                "shooter",
                "shooter",
                "driving",
                "runner",
                "walking simulator",
                "aerial combat game",
                "runner",
                "walking simulator",
                "aerial combat game",
                "flight simulator",
                "simulator",
                "simulator",
                "clicker game",
                "hack & slash",
                "hack & slash",
                "hack & slash",
                "endless runner",
                "collect-a-thon",
                "collect-a-thon",
                "collect-a-thon",
                "shooter",
                "bullet hell",
                "bullet hell",
                "bullet hell",
                "sports game",
                "puzzle game",
                "stealth game",
                "stealth game",
                "stealth game",
                "stealth game",
                "programming game",
                "racing game",
                "racing game",
                "racing game",
                "driving game",
                "typing game",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "strategy game",
                "metroidvania",
                "RPG",
                "roguelike",
                "dating sim",
                "survival game",
                "survival game",
                "survival game",
                "card game",
                "rhythm game",
                "card game",
                "rhythm game",
                "tower defense game",
                "sandbox game",
                "sandbox game",
                "typing game",
            };
            int useRules = random.Next(rules.Length);
            string pickRules = rules[useRules];
            rulesContainerData.text = rules[useRules];
            //print(pickRules);
            
        }
    }

    public void WildcardGenerator()
    {
        
        if (wildcardLockText.text == "Unlocked")
        {
            //playClip();
            //setup enemy types
            int useEnemyTypes = random.Next(enemyTypes.Length);
            string pickEnemyTypes = enemyTypes[useEnemyTypes];

            //setup time types
            int useTimeTypes = random.Next(timeTypes.Length);
            string pickTimeTypes = timeTypes[useTimeTypes];

            //setup item types
            int useItemTypes = random.Next(itemTypes.Length);
            string pickItemTypes = itemTypes[useItemTypes];

            numberGrabber = Random.Range(2, 100);
            string[] wildcard = new string[]
            {
                "only have 1 life",
                "only have " + numberGrabber + " lives",
                "can't pick up " + itemTypes[useItemTypes],
                "can only pick up " + itemTypes[useItemTypes],
                "can't pick anything up",
                "can't run",
                "can't jump",
                "can't pick up " + itemTypes[useItemTypes],
                "can only pick up " + itemTypes[useItemTypes],
                "can't pick anything up",
                "can't run",
                "can't jump",
                "can't pick up " + itemTypes[useItemTypes],
                "can only pick up " + itemTypes[useItemTypes],
                "can't pick anything up",
                "can't run",
                "can't jump",
                "can't talk",
                "can manipulate time",
                "can manipulate gravity",
                "are never alone",
                "always carry " + itemTypes[useItemTypes],
                "always carry " + numberGrabber + " " + itemTypes[useItemTypes],
                "are on a deserted island",
                "are the last alive",
                "are in a TV show",
                "are in a movie",
                "are in a musical",
                "can't die",
                "are being chased by " + enemyTypes[useEnemyTypes],
                "are being chased by " + enemyTypes[useEnemyTypes],
                "are being chased by " + itemTypes[useItemTypes],
                "are easily killed by " + itemTypes[useItemTypes],
                "gets health from " + itemTypes[useItemTypes],
                "are already dead",
                "only have " + numberGrabber + " " + timeTypes[useTimeTypes] + " to live",
                "are in a mockumentary",
                "are in a documentary",
            };
            int useWildcard = random.Next(wildcard.Length);
            string newPickWildcard = wildcard[useWildcard];
            wildcardContainerData.text = wildcard[useWildcard];
            //print(pickWildcard);
            this.theLocks.lockText.text = wildcardLockText.text;
        }
    }

    public void TheSentence()
    {
        if (sentenceAnim != null)
        {
            // play Bounce but start at a quarter of the way though
            sentenceAnim.Play("sentencePop");
        }

        
    }

    public IEnumerator Generator()
    {
        
        yield return new WaitForSeconds(0.25f);
        TheSentence();
        yield return new WaitForSeconds(0.25f);
        //PerspectiveGenerator();
        //theperspectiveGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        GenreGenerator();
        theGenreGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        RulesGenerator();
        theRulesGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        EnvironmentGenerator();
        thePlaceGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        GoalsGenerator();
        theObjectiveGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        WildcardGenerator();
        theWildcardGO.SetActive(true);

    }
}