using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Customisation : MonoBehaviour
{
    #region Variables

    #region Character Customisation
    [Header("Texture List")] // OR Material List
    //Texture2D List for skin,hair, mouth, eyes, armour and clothes
    public List<Texture2D> skin = new List<Texture2D>();
    public List<Texture2D> hair = new List<Texture2D>();
    public List<Texture2D> mouth = new List<Texture2D>();
    public List<Texture2D> eyes = new List<Texture2D>();
    public List<Texture2D> armour = new List<Texture2D>();
    public List<Texture2D> clothes = new List<Texture2D>();

    [Header("Index")]
    //Index numbers for our current skin, hair, mouth, eyes textures
    public int skinIndex;
    public int hairIndex, mouthIndex, eyesIndex, armourIndex, clothesIndex;

    [Header("Renderer")]
    //Renderer for the character it can be referenced to a material list
    public Renderer character;

    [Header("Max Index")]
    //What are their maximum files from the assets folder
    public int skinMax;
    public int hairMax, mouthMax, eyesMax, armourMax, clothesMax;
    #endregion

    #region General Char Customisation
    [Header("Character Name")]
    //name of our character that the user is making
    public string characterName = "Holly Molly";

    [Header("Stats")]
    public string[] statArray = new string[6]; // Store all names of Physical and Personality Attributes
    public int[] tempStats = new int[6]; // Helping computer to change stats and statArray
    public int[] stats = new int[6];// Store the value of Physical and Personality Attributes 
    public int points = 30; // Points to use for the stats
    #endregion

    #endregion

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public enum CharacterClass
    {
        Barbarian,
        Bard,
        Druid,
        Monk,
        Paladin,
        Ranger,
        Sorcerer,
        Warlock
    }
}
