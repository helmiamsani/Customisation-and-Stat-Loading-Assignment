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
    #region Stats
    public string[] statArray = new string[6]; // Store all names of Physical and Personality Attributes
    public int[] tempStats = new int[6]; // Helping computer to change stats and statArray
    public int[] stats = new int[6];// Store the value of Physical and Personality Attributes 
    public int points = 30; // Points to use for the stats
    #endregion

    #region Character Class
    public CharacterClass charClass;
    public string[] selectedClass = new string[5];
    public int selectedIndex = 0;
    #endregion

    #endregion

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // Mouse cursor does not constrain at all
        Cursor.visible = true; // Mouse cursor is visible

        statArray = new string[] {"Health", "Mana", "Stamina", "Intelligence", "Charisma", "Strength" };
        selectedClass = new string[] { "Barbarian", "Bard", "Monk", "Paladin", "Ranger"};


        #region Pulling Texture from the Assets

        #region Skin Textures
        //for loop, looping from 0 to less than the max amount of skin textures needed
        for (int i = 0; i < skinMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Skin_#
            Texture2D temp = Resources.Load("character/Skin_" + i.ToString()) as Texture2D;
            //add temp texture to the skin List
            skin.Add(temp);
        }
        #endregion

        #region Mouth Textures
        //for loop looping from 0 to less than the max amount of mouth textures needed
        for (int i = 0; i < mouthMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Mouth_#
            Texture2D temp = Resources.Load("character/Mouth_" + i.ToString()) as Texture2D;
            //add temp texture to the mouth List
            mouth.Add(temp);
        }
        #endregion

        #region Hair Textures
        //for loop looping from 0 to less than the max amount of hair textures needed
        for (int i = 0; i < hairMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Hair_#
            Texture2D temp = Resources.Load("character/Hair_" + i.ToString()) as Texture2D;
            //add temp texture to the hair List
            hair.Add(temp);
        }
        #endregion

        #region Eyes Textures
        //for loop looping from 0 to less than the max amount of eyes textures needed
        for (int i = 0; i < eyesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Eyes_#
            Texture2D temp = Resources.Load("character/Eyes_" + i.ToString()) as Texture2D;
            //add temp texture to the eyes List
            eyes.Add(temp);
        }
        #endregion

        #region Clothes Textures        
        //for loop looping from 0 to less than the max amount of clothes textures needed
        for (int i = 0; i < clothesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Clothes_#
            Texture2D temp = Resources.Load("character/Clothes_" + i.ToString()) as Texture2D;
            //add temp texture to the Clothes List
            clothes.Add(temp);
        }
        #endregion

        #region Armour Textures
        //for loop looping from 0 to less than the max amount of armour textures needed
        for (int i = 0; i < armourMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Armour_#
            Texture2D temp = Resources.Load("character/Armour_" + i.ToString()) as Texture2D;
            //add temp texture to the Armour List
            armour.Add(temp);
        }
        #endregion

        #endregion

        #region Default Textures
        SetTexture("Skin", 0);
        SetTexture("Eyes", 0);
        SetTexture("Mouth", 0);
        SetTexture("Hair", 0);
        SetTexture("Clothes", 0);
        SetTexture("Armour", 0);
        #endregion

        ChooseClass(selectedIndex);
    }

    #region SetTexture
    // A function for setting up character textures
    public void SetTexture(string type, int dir) // type (string): type (skin, eyes, armour, clothes, etc) of features that are going to be chosen, dir (int): which number of features are going to be chosen.
    {
        int index = 0, max = 0, matIndex = 0; // Ints of index numbers, max numbers, material index
        Texture2D[] textures = new Texture2D[0]; // Texture2D array of textures

        #region Switching Type of Features
        // Switching the type (string) of features 
        switch (type)
        {
            #region Skin Section
            // FOR >>Skin<<
            case "Skin":
                // Index stores skinIndex
                index = skinIndex;
                // Max stores skinMax
                max = skinMax;
                // Textures stores the array of Skin
                textures = skin.ToArray();
                // Material index element number is 1 (Can be found inside Warrior's Mesh)
                matIndex = 1;
                //break
                break;
            #endregion

            #region Eyes Section
            // FOR >>Eyes<<
            case "Eyes":
                // Index stores eyesIndex
                index = eyesIndex;
                // Max stores eyesMax
                max = eyesMax;
                // Textures stores the array of Eyes
                textures = eyes.ToArray();
                // Material index element number is 2 (Can be found inside Warrior's Mesh)
                matIndex = 2;
                //break
                break;
            #endregion

            #region Mouth Section
            // FOR >>Mouth<<
            case "Mouth":
                // Index stores mouthIndex
                index = mouthIndex;
                // Max stores mouthMax
                max = mouthMax;
                // Textures stores the array of Skin
                textures = mouth.ToArray();
                // Material index element number is 3 (Can be found inside Warrior's Mesh)
                matIndex = 3;
                //break
                break;
            #endregion

            #region Hair Section
            // FOR >>Hair<<
            case "Hair":
                // Index stores hairIndex
                index = hairIndex;
                // Max stores hairMax
                max = hairMax;
                // Textures stores the array of hair
                textures = hair.ToArray();
                //material index element number is 4 (Can be found inside Warrior's Mesh)
                matIndex = 4;
                //break
                break;
            #endregion

            #region Clothes Section
            // FOR >>Hair<<
            case "Clothes":
                // Index stores clothesIndex
                index = clothesIndex;
                // Max stores clothesMax
                max = clothesMax;
                // Textures stores the array of clothes
                textures = clothes.ToArray();
                //material index element number is 5 (Can be found inside Warrior's Mesh)
                matIndex = 5;
                //break
                break;
            #endregion

            #region Armour Section
            // FOR >>Armour<<
            case "Armour":
                // Index stores armourIndex
                index = armourIndex;
                // Max stores armourMax
                max = armourMax;
                // Textures stores the array of armour
                textures = armour.ToArray();
                //material index element number is 6 (Can be found inside Warrior's Mesh)
                matIndex = 6;
                //break
                break;
                #endregion
        }
        #endregion

        #region Directing which Number of Features are going to be Chosen
        // Index plus equals our direction
        index += dir;

        // If index is less than 0 (OR if the material is at default)
        if (index < 0)
        {
            index = max - 1; // The material is set to the last material
        }

        // If material is at the last material
        if (index > max - 1)
        {
            index = 0; // The material is set to the deault
        }
        #endregion

        // Mat stores character materials (can be found in Skinned Mesh Render (in Mesh))
        Material[] mat = character.materials;

        // Main Texture is set to the current texture (eg. "Skin"[skinIndex])
        mat[matIndex].mainTexture = textures[index];

        // Character materials then stores the Mat 
        character.materials = mat;

        #region Showing Type of Features to Audiences
        switch (type)
        {
            #region Skin
            case "Skin":
                // SkinIndex stores index
                skinIndex = index;
                break;
            #endregion

            #region Eyes
            case "Eyes":
                // EyesIndex stores index
                eyesIndex = index;
                break;
            #endregion

            #region Mouth
            case "Mouth":
                // MouthIndex stores index
                mouthIndex = index;
                break;
            #endregion

            #region Hair
            case "Hair":
                // HairIndex stores index
                hairIndex = index;
                break;
            #endregion

            #region Clothes
            case "Clothes":
                // ClothesIndex stores index
                clothesIndex = index;
                break;
            #endregion

            #region Armour
            case "Armour":
                // ArmourIndex stores index
                armourIndex = index;
                break;
            #endregion
        }
        #endregion

    }
    #endregion

    #region Choose Class
    public void ChooseClass(int className)
    {
        switch (className)
        {
            case 0:
                stats[0] = 120; // Health
                stats[1] = 40; // Mana
                stats[2] = 140; // Stamina
                stats[3] = 60; // Intelligence
                stats[4] = 30; // Charisma
                stats[5] = 160;  // Strength
                charClass = CharacterClass.Barbarian;
                break;

            case 1:
                stats[0] = 80; // Health
                stats[1] = 150; // Mana
                stats[2] = 80; // Stamina
                stats[3] = 160; // Intelligence
                stats[4] = 150; // Charisma
                stats[5] = 10; // Strength
                charClass = CharacterClass.Bard;
                break;

            case 2:
                stats[0] = 100; // Health
                stats[1] = 100; // Mana
                stats[2] = 100; // Stamina
                stats[3] = 100; // Intelligence
                stats[4] = 100; // Charisma
                stats[5] = 10; // Strength
                charClass = CharacterClass.Monk;
                break;

            case 3:
                stats[0] = 160; // Health
                stats[1] = 120; // Mana
                stats[2] = 70; // Stamina
                stats[3] = 170; // Intelligence
                stats[4] = 100; // Charisma
                stats[5] = 150; // Strength
                charClass = CharacterClass.Paladin;
                break;

            case 4:
                stats[0] = 90; // Health
                stats[1] = 80; // Mana
                stats[2] = 200; // Stamina
                stats[3] = 180; // Intelligence
                stats[4] = 200; // Charisma
                stats[5] = 30; // Strength
                charClass = CharacterClass.Ranger;
                break;
        }
    }
    #endregion

    #region Enums
    public enum CharacterClass
    {
        Barbarian,
        Bard,
        Monk,
        Paladin,
        Ranger
    }
    #endregion
}