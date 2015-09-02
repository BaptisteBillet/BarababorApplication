using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoathouseShipEquipementButton : MonoBehaviour {

    //__________________________________________________________________________
 
    //The Boathouse Panel and it's script used to get the ship currently used
    public GameObject m_BoathousePanel;
    ScriptBoathouseManager m_ScriptBoathouseManager;

    //________________________________________________________________________

    //The Ship and it's script used to collect the informations like what are the different equipements on board
    GameObject m_Ship;
    ScriptShip m_ScriptShip;

    //_______________________________________________________________________


    public int m_Index;//Given directly in the inspector, won't change, used to know where to look for in the equipement array

    public Text m_EquipementName;//Textfield used to display the name of the equipement in the ship's equipement array

    public string m_NameofEquipement;

    public GameObject m_BlackPanel;//A black Panel used to overlay the rest of the screen except the description of the equipement
    public Button m_BlackPanelButton;
    public GameObject m_DescriptionFrame;
    

    public GameObject m_EquipButton;
    public GameObject m_EquipButton1;
    public GameObject m_EquipButton2;
    public GameObject m_EquipButton3;
    public GameObject m_EquipButton4;
    public GameObject m_ShopButton;
    public GameObject m_BackButton;
    public GameObject m_ElementButton;


    public Text m_DescriptionField;

    string m_EquipementType;
    //_______________________________________________________________________


	// Use this for initialization
	void Start ()
    {
        m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager>();

        m_Ship = m_ScriptBoathouseManager.m_SelectedShip;
        m_ScriptShip = m_Ship.GetComponent<ScriptShip>();

        m_EquipementName.text = m_ScriptShip.m_ArrayofEquipement[m_Index];

        switch (m_Index)
        {
            case 0:
            m_NameofEquipement = PlayerPrefs.GetString("m_EquipedSpecialist");
            break;

            case 1:
            m_NameofEquipement = PlayerPrefs.GetString("m_EquipedEquipement1");
            break;

            case 2:
            m_NameofEquipement = PlayerPrefs.GetString("m_EquipedEquipement2");
            break;

            case 3:
            m_NameofEquipement = PlayerPrefs.GetString("m_EquipedEquipement3");
            break;

            case 4:
            if (m_ScriptShip.m_UltimateEquiped == true)
                {
                    m_NameofEquipement = PlayerPrefs.GetString("m_EquipedEquipement4");
                }
            else if (m_ScriptShip.m_UltimateEquiped == true)
                {
                    m_NameofEquipement = PlayerPrefs.GetString("m_EquipedUltimate");
                }
            break;
        }

      

    }
	
    public void DescriptionDisplay ()
    {
        if (m_ScriptBoathouseManager.m_MultiStorageEnabled==false)
        {
               m_EquipButton.SetActive (false);
        }
        
        else if (m_ScriptBoathouseManager.m_MultiStorageEnabled == true)
        {
            m_EquipButton1.SetActive (false);
            m_EquipButton2.SetActive (false);
            m_EquipButton3.SetActive (false);
            m_EquipButton4.SetActive(false);
        }

        m_ShopButton.SetActive(false);
        m_BackButton.SetActive(false);
        m_ElementButton.SetActive(false);
        m_Ship.SetActive(false);

        m_BlackPanel.SetActive(true);
        m_BlackPanelButton.enabled = true;

        m_DescriptionFrame.SetActive(true);
        m_DescriptionField.enabled = true;
        

        switch (m_Index)
        {

            case 0:
                m_DescriptionField.text = TriDataBase.instance.m_SpecialistDico[m_NameofEquipement].m_Description;
                break;

            case 1:
                m_EquipementType = m_ScriptShip.m_RegisteredEquipementType1;

                if (m_EquipementType == "Weapon")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_WeaponDico[m_NameofEquipement].m_Description;
                }

                else if (m_EquipementType == "Gadget")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_GadgetDico[m_NameofEquipement].m_Description;
                }
                break;
            case 2:
                m_EquipementType = m_ScriptShip.m_RegisteredEquipementType1;

                if (m_EquipementType == "Weapon")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_WeaponDico[m_NameofEquipement].m_Description;
                }

                else if (m_EquipementType == "Gadget")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_GadgetDico[m_NameofEquipement].m_Description;
                }
                break;

            case 3:
                m_EquipementType = m_ScriptShip.m_RegisteredEquipementType1;

                if (m_EquipementType == "Weapon")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_WeaponDico[m_NameofEquipement].m_Description;
                }

                else if (m_EquipementType == "Gadget")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_GadgetDico[m_NameofEquipement].m_Description;
                }
                break;

            case 4:
                m_EquipementType = m_ScriptShip.m_RegisteredEquipementType1;

                if (m_EquipementType == "Weapon")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_WeaponDico[m_NameofEquipement].m_Description;
                }

                else if (m_EquipementType == "Gadget")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_GadgetDico[m_NameofEquipement].m_Description;
                }

                else if (m_EquipementType == "Ultimate")
                {
                    m_DescriptionField.text = TriDataBase.instance.m_UltimateDico[m_NameofEquipement].m_Description;
                }
                break;
        }
    }

    public void DescritpionErase()
    {
        m_DescriptionFrame.SetActive(false);
        m_DescriptionField.enabled = false;
    }

}
