using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SavedData
{
    #region Variables
    public int skin, hair, mouth, eyes, armour, clothes;

    public string charName;

    public string health;
    public string mana;
    public string classType;
    #endregion

    #region Save the data
    public SavedData(Customisation custom)
    {
        // Save all player attributes
        skin = custom.skinIndex;
        hair = custom.hairIndex;
        mouth = custom.mouthIndex;
        eyes = custom.eyesIndex;
        armour = custom.armourIndex;
        clothes = custom.clothesIndex;

        charName = custom.charName; // Save character name
        health = custom.stats[0].ToString(); // Save player health
        mana = custom.stats[1].ToString(); // Save player mana 
        classType = custom.selectedClass[custom.selectedIndex]; // Save player class

    }
    #endregion
}
