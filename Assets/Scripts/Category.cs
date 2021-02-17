using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Category : MonoBehaviour
{
    public List<string> category = new List<string>();
    public List<AudioSource> audioVoice = new List<AudioSource>();
    public Text wordText; 
    
    
    void Start()
    {
        //Categories
        category.Add("Fast Food Brand");
        category.Add("Car Part");
        category.Add("Body Part");
        category.Add("Clothing Brand");
        category.Add("Kitchen Utensil");
        category.Add("Sports");
        category.Add("Plants");
        category.Add("Vegatables");
        category.Add("Insects");
        category.Add("Reptile");
        category.Add("Dessert");
        category.Add("Shoe Brand");
        category.Add("Game Title");
        category.Add("Fruit");
        category.Add("Garden Tool");
        category.Add("Furniture");
        category.Add("Music Instruments");
        category.Add("Colors");
        category.Add("Classroom Object");
        category.Add("Alcohol Drinks");
        category.Add("Movie Title");
        category.Add("Athlete Names");
        category.Add("Countries/Cities");
        category.Add("Mammals");
        category.Add("Slow Animal");


        //Animals
        //Art
        //Careers
        //Clothing
        //Television
        //Movies
        //sports
        //Food
        //Geography
        //Music
        //Technology
        //

    }
    public void ChooseWord()
    {
        int randomIndex = Random.Range(0, category.Count);
        string randomWord = category[randomIndex];
        category.Remove(randomWord);

        wordText.text = randomWord;
    }
}
