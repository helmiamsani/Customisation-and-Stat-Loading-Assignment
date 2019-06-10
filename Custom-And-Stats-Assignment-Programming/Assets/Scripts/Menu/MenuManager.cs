using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    #region Variables

    #region Panels
    [Header("Panels Attributes")]
    public GameObject[] panels; // Panels game objects
    public int panelIndex = 0, panelMax; // Panel index and Panel Max
    private GameObject _currentPanel, _nextPanel; // To store current panel and the next panel
    #endregion

    #region Customisation
    [Header("Customisation")]
    public Customisation custom;
    /*
    public int _selectedIndex;
    public string[] _selectedClass;*/

    #region Classes
    [Header("Character Class Attributes")]
    public Text className;
    public Text health;
    public Text mana;
    public Text stamina;
    public Text intelligence;
    public Text charisma;
    public Text strength;
    #endregion

    #endregion

    #endregion

    private void Start()
    {
        /*
        // Referencing to customisation script
        _selectedIndex = custom.selectedIndex;
        _selectedClass = custom.selectedClass;*/

        custom.ChooseClass(custom.selectedIndex);
        className.text = custom.selectedClass[custom.selectedIndex].ToString();

        #region Showing stats' scores

        health.text = custom.stats[0].ToString(); // Applying string to text for Health
        mana.text = custom.stats[1].ToString(); // Applying string to text for Mana
        stamina.text = custom.stats[2].ToString(); // Applying string to text for Stamina
        intelligence.text = custom.stats[3].ToString(); // Applying string to text for Intelligence
        charisma.text = custom.stats[4].ToString(); // Applying string to text for Charisma
        strength.text = custom.stats[5].ToString(); // Applying string to text for Strength

        #endregion
    }

    #region Menu Button

    #region Next Button
    public void NextButton()
    {
        _currentPanel = panels[panelIndex]; // Previous Panel stores the current panels (eg. panels[0])
        _currentPanel.SetActive(false); // Previous Panel is set to off
        panelIndex++; // increase the panelIndex 
        _nextPanel = panels[panelIndex]; // Next Panel stores the next panels (eg. panels[1])
        _nextPanel.SetActive(true); // Next panel is set to on
    }
    #endregion

    #region Back Button
    public void BackButton()
    {
        _currentPanel = panels[panelIndex]; // Previous Panel stores the current panels (eg. panels[0])
        _currentPanel.SetActive(false); // Previous Panel is set to off
        panelIndex--; // decrease the panelIndex
        _nextPanel = panels[panelIndex]; // Next Panel stores the next panels (eg. panels[1])
        _nextPanel.SetActive(true); // Next panel is set to on
    }
    #endregion

    #region Play Button
    public void PlayButton()
    {

    }
    #endregion

    #endregion

    #region Change Appearances Button

    #region Skin

    #region SkinNext
    public void SkinNext()
    {
        custom.SetTexture("Skin", 1);
    }
    #endregion

    #region SkinBack
    public void SkinBack()
    {
        custom.SetTexture("Skin", -1);
    }
    #endregion

    #endregion

    #region Eyes

    #region EyesNext
    public void EyesNext()
    {
        custom.SetTexture("Eyes", 1);
    }
    #endregion

    #region EyesBack
    public void EyesBack()
    {
        custom.SetTexture("Eyes", -1);
    }
    #endregion

    #endregion

    #region Mouth

    #region MouthNext
    public void MouthNext()
    {
        custom.SetTexture("Mouth", 1);
    }
    #endregion

    #region MouthBack
    public void MouthBack()
    {
        custom.SetTexture("Mouth", -1);
    }
    #endregion

    #endregion

    #region Hair

    #region HairNext
    public void HairNext()
    {
        custom.SetTexture("Hair", 1);
    }
    #endregion

    #region HairBack
    public void HairBack()
    {
        custom.SetTexture("Hair", -1);
    }
    #endregion

    #endregion

    #region Clothes

    #region ClothesNext
    public void ClothesNext()
    {
        custom.SetTexture("Clothes", 1);
    }
    #endregion

    #region ClothesBack
    public void ClothesBack()
    {
        custom.SetTexture("Clothes", -1);
    }
    #endregion

    #endregion

    #region Armour

    #region ArmourNext
    public void ArmourNext()
    {
        custom.SetTexture("Armour", 1);
    }
    #endregion

    #region ArmourBack
    public void ArmourBack()
    {
        custom.SetTexture("Armour", -1);
    }
    #endregion

    #endregion

    #endregion

    #region Change Class
    public void ClassNext()
    {

    }
    #endregion
}
