using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Rhyme : MonoBehaviour
{
    //List of words
     public List<string> words = new List<string>();
     public List<AudioSource> audioVoice = new List<AudioSource>(); 
     public Text wordText;

    //List of Missions
    public List<string> missions = new List<string>();
    public Text missionText; 
   
    void Start()
    {
        //RHYME

        //Catergory: Animal
        words.Add("Cat");
        words.Add("Dog");
        words.Add("Cow");
        words.Add("Horse");
        words.Add("Fish");
        words.Add("Bird");
        words.Add("Lion");
        words.Add("Cheetah");
        words.Add("Ant");
        words.Add("Chimpanzee");
        words.Add("Ox");
        words.Add("Panda");
        words.Add("Walrus");
        words.Add("Otter");
        words.Add("Hen");
        words.Add("Chicken");

        //Category: Food
        words.Add("Cheesy");
        words.Add("Sushi");
        words.Add("Muffin");
        words.Add("Spaghetti");
        words.Add("Rice");
        words.Add("Burger");
        words.Add("Fries");
        words.Add("Pizza");
        words.Add("Wonton");
        words.Add("Kebab");
        words.Add("Skewer");
        words.Add("Brisket");

        //Category: Stationary
        words.Add("Pen");
        words.Add("Calculator");
        words.Add("Scissor");
        words.Add("Pencil");

        //funny/rude/profanity
        words.Add("Asshole");
        words.Add("Vagina");
        words.Add("DickCheese");
        words.Add("Penis");
        words.Add("Bobbies");
        words.Add("Clit");
        words.Add("Conjunctivitis");
        words.Add("Nipple");
        words.Add("Belly");
        words.Add("BlowJob");

        //RandomWords
        words.Add("Freaky");
        words.Add("Cheeky");
        words.Add("Weenie");
        words.Add("Doodle");
        words.Add("Ambiguous");
        words.Add("Spite");
        words.Add("Offspring");
        words.Add("Football");
        words.Add("Mystery");
        words.Add("Border");
        words.Add("Economic");
        words.Add("Traction");
        words.Add("Earthquake");
        words.Add("Tsunami");
        words.Add("Weenie");
        words.Add("Doodle");

        misisonCount(); 
    }

    void misisonCount()
    {
        missions.Add("Clap and increase by 1 clap after each person");
        missions.Add("Wink right and left");
        missions.Add("Add ‘Fuck’ at the end of each answer");
        missions.Add("Add ‘Penis’ at the end of each answer");
        missions.Add("Add ‘Penis’ at the end of each answer");
        missions.Add("Add ‘Smelly’ at the end of each answer");
        missions.Add("Add ‘Laa’ at the end of each answer");
        missions.Add("Add ‘fart’ at the end of each answer");
        missions.Add("Loser Drinks 2");
        missions.Add("Wild Card");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
        //missions.Add("");
    }

    public void ChooseWord()
    {
        //Rhyme Word
      int randomIndex= Random.Range (0,words.Count);
      string randomWord = words[randomIndex];
      words.Remove(randomWord);   

        wordText.text = randomWord;

        //Side Mission

        int randomMissionIndex = Random.Range(0, missions.Count);
        string randomMissionWord = missions[randomMissionIndex];
        missionText.text = randomMissionWord; 
    }
}
    