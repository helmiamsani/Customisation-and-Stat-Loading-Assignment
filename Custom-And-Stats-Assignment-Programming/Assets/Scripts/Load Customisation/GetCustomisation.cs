using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
//you will need to change Scenes
public class GetCustomisation : MonoBehaviour
{

    [Header("Character")]
    //public variable for the Skinned Mesh Renderer which is our character reference
    public Renderer character;

    [Header("Loaded File")]
    public int skin, hair, mouth, eyes, armour, clothes;
    //public string charName;

    private Customisation custom;

    #region Start
    private void Start()
    {
        //our character reference connected to the Skinned Mesh Renderer via finding the Mesh
        character = GameObject.FindGameObjectWithTag("PlayerMesh").GetComponent<SkinnedMeshRenderer>();

        //Run the function LoadTexture	
        LoadTexture();

        Debug.Log("Texture is Loaded");
    }
    #endregion

    #region LoadTexture Function
    void LoadTexture()
    {
        //check to see if our save file for this character
        string path = Application.persistentDataPath + "/Save.jpg";

        if (File.Exists(path))
        {
            SavedData data = SaveCustomisation.LoadPlayerData();
            SetTexture("Skin", data.skin);
            skin = data.skin;
            SetTexture("Hair", data.hair);
            hair = data.hair;
            SetTexture("Mouth", data.mouth);
            mouth = data.mouth;
            SetTexture("Skin", data.skin);
            eyes = data.eyes;
            SetTexture("Armour", data.armour);
            armour = data.armour;
            SetTexture("Clothes", data.clothes);
            clothes = data.clothes;
            //charName = data.charName;
        }

        else
        {
            SetTexture("Skin", custom.skinIndex = 0);
            SetTexture("Hair", custom.hairIndex = 0);
            SetTexture("Mouth", custom.mouthIndex = 0);
            SetTexture("Eyes", custom.eyesIndex = 0);
            SetTexture("Clothes", custom.clothesIndex = 0);
            SetTexture("Armour", custom.armourIndex = 0);
        }
    }
    #endregion

    #region SetTexture
    //the string is the name of the material we are editing, the int is the direction we are changing
    void SetTexture(string type, int index)
    {
        //we need variables that exist only within this function
        //these are int material index and Texture2D textures
        Texture2D tex = null;
        int matIndex = 0;
        //inside a switch statement that is swapped by the string name of our material
        switch (type)
        {
            #region Skin
            //case skin      
            case "Skin":
                //textures is our Resource.Load Character Skin save index we loaded in set as our Texture2D
                tex = Resources.Load("Character/Skin_" + index) as Texture2D;
                //material index element number is 1
                matIndex = 1;
                break;
            #endregion

            #region Eyes    
            case "Eyes":
                //textures is our Resource.Load Character Eyes save index we loaded in set as our Texture2D
                tex = Resources.Load("Character/Eyes_" + index) as Texture2D;
                //material index element number is 4
                matIndex = 2;
                break;
            #endregion

            #region Mouth
            case "Mouth":
                //textures is our Resource.Load Character Mouth save index we loaded in set as our Texture2D
                tex = Resources.Load("Character/Mouth_" + index) as Texture2D;
                //material index element number is 3
                matIndex = 3;
                break;
            #endregion

            #region Hair
            case "Hair":
                //textures is our Resource.Load Character Hair save index we loaded in set as our Texture2D
                tex = Resources.Load("Character/Hair_" + index) as Texture2D;
                //material index element number is 2
                matIndex = 4;
                break;
            #endregion

            #region Clothes
            case "Clothes":
                //textures is our Resource.Load Character Clothes save index we loaded in set as our Texture2D
                tex = Resources.Load("Character/Clothes_" + index) as Texture2D;
                //material index element number is 5
                matIndex = 5;
                break;
            #endregion

            #region Armour
            case "Armour":
                //textures is our Resource.Load Character Armour save index we loaded in set as our Texture2D
                tex = Resources.Load("Character/Armour_" + index) as Texture2D;
                //material index element number is 6
                matIndex = 6;
                break;
            #endregion
        }

        //Material array is equal to our characters material list
        Material[] mats = character.materials;
        //our material arrays current material index's main texture is equal to our texture arrays current index
        mats[matIndex].mainTexture = tex;
        //our characters materials are equal to the material array
        character.materials = mats;
    }
    #endregion
}
