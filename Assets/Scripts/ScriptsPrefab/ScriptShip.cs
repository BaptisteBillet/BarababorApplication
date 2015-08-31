using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;



public class ScriptShip : MonoBehaviour
{
    #region MembersDeclaration
    // Ship's main infos :name and archetype
    public string m_ShipName;

    public string m_Archetype;

    //_______________________________________________________________________________________





    //Characteristics of the ship and the Array where they're memorized 
    public int m_Speed;
    public float m_Damage;
    public int m_HealthPoint;
    public int m_Capacity;
    public int m_Regeneration;
    public int m_Vision;



    int[] m_CharacteristicsArray = new int[6];




    //______________________________________________________________________________________





    // Members useful to organize the characteristics	
    int m_FirstValue;
    int m_SecondValue;



    //______________________________________________________________________________________




    //Different parts of the ship
    public string[] m_ArrayofElements = new string[4];

    public string m_CurrentBow;// Elements already on the ship
    public string m_CurrentStern;
    public string m_CurrentMast;
    public string m_CurrentKeel;

    public GameObject m_BoathousePanel;// The boathouse panel, where the playerprefs are stored
    ScriptBoathouseManager m_ScriptBoathouseManager;



    public Text m_SpeedField;//Different Fields where the ship's characteristics are displayed 
    public Text m_DamageField;
    public Text m_CapacityField;
    public Text m_HealthPointField;
    public Text m_RegenerationField;
    public Text m_VisionField;




    //_________________________________________________________________________________________



    public string[] m_ArrayofEquipement = new string[5];

    public string m_EquipedSpecialist;
    public string m_EquipedEquipement1;
    public string m_EquipedEquipement2;
    public string m_EquipedEquipement3;
    public string m_EquipedEquipement4;
    public string m_EquipedUltimate;

    GameObject m_SelectedEquipement;
    ScriptShipEquipement m_ScriptShipEquipement;

    bool m_UltimateEquiped;
    //____________________________________________________________________________________________
    //Where the different Equipements of the ship are displayed 


    public Text m_TextFieldPassif;
    public Text m_TextFieldEquipement1;
    public Text m_TextFieldEquipement2;
    public Text m_TextFieldEquipement3;
    public Text m_TextFieldUltimateEquipement;

    //____________________________________________________________________________________________




    string m_MemorizedKeel;
    string m_MemorizedBow;
    string m_MemorizedStern;
    string m_MemorizedMast;

    public bool m_FirstTime;

    GameObject m_SelectedPiece;
    ScriptShipPieces m_ScriptShipPieces;





    //_____________________________________________________________________________________________


    #endregion

    #region Functions
    // Use this for initialization
    void Awake()
    {
        m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager>();// Get the script from the boathouse panel


       
        if (m_FirstTime == true)// if it's the first time the player customize his ship, it's equipment is set to default
        {
            PlayerPrefs.SetString("m_MemorizedKeel", "QuilleDefault");//the keel that's saved in the memory is set to QuilleDefault. We use only the name of an object (string) to look for it in a dictionary containing all the different kind of object of a same type (keel, bow, stern, mast...)
            PlayerPrefs.SetString("m_MemorizedBow", "ProueDefault");
            PlayerPrefs.SetString("m_MemorizedStern", "PoupeDefault");
            PlayerPrefs.SetString("m_MemorizedMast", "VoileDefault");
        }

        m_CurrentBow = PlayerPrefs.GetString("m_MemorizedBow");// if it's not the first time the player customize his ship, the system go in the memory to look what's the name of the piece on board
        m_CurrentKeel = PlayerPrefs.GetString("m_MemorizedKeel");
        m_CurrentStern = PlayerPrefs.GetString("m_MemorizedStern");
        m_CurrentMast = PlayerPrefs.GetString("m_MemorizedMast");



        m_ArrayofElements[0] = m_CurrentKeel;//stock the different parts of a ship in an array
        m_ArrayofElements[1] = m_CurrentBow;
        m_ArrayofElements[2] = m_CurrentStern;
        m_ArrayofElements[3] = m_CurrentMast;

        CharacteristicsCalculation(); // launch CharacteristicsCalculation

       

        int m_ConvertedDamage = Mathf.CeilToInt(m_Damage); // Convert the float of damages into a int (necessary for now)

        //Initialize all the members
        m_FirstValue = 0; // Set FirstValue and Second Value (ArchetypeAttribution) to 0
        m_SecondValue = 0;

        m_CharacteristicsArray[0] = m_Speed;//Fill the array with the different values of the ship's characteristics 
        m_CharacteristicsArray[1] = m_ConvertedDamage;
        m_CharacteristicsArray[2] = m_HealthPoint;
        m_CharacteristicsArray[3] = m_Capacity;
        m_CharacteristicsArray[4] = m_Regeneration;
        m_CharacteristicsArray[5] = m_Vision;

        m_SpeedField.text = " " + m_Speed;//Display the values of the ship's characteristics
        m_DamageField.text = " " + m_Damage;
        m_CapacityField.text = "" + m_Capacity;
        m_HealthPointField.text = " " + m_HealthPoint;
        m_RegenerationField.text = " " + m_Regeneration;
        m_VisionField.text = " " + m_Vision;

        m_ArrayofEquipement[0] = PlayerPrefs.GetString("m_EquipedSpecialist");
        m_ArrayofEquipement[1] = PlayerPrefs.GetString("m_EquipedEquipement1");
        m_ArrayofEquipement[2] = PlayerPrefs.GetString("m_EquipedEquipement2");
        m_ArrayofEquipement[3] = PlayerPrefs.GetString("m_EquipedEquipement3");

        if (m_UltimateEquiped==false)
        {
            m_ArrayofEquipement[4] = PlayerPrefs.GetString("m_EquipedEquipement4");
        }
        else if (m_UltimateEquiped==true)
        {
            m_ArrayofEquipement[4] = PlayerPrefs.GetString("m_EquipedUltime");
        }

        Debug.Log(m_ArrayofEquipement[0]);
        Debug.Log(m_ArrayofEquipement[1]);
        ArchetypeAttribution();// Launch ArchetypeAttribution.

    }

    #region Archetype
    public void ArchetypeAttribution()
    {
        for (int j = 0; j < 4; j++) // Use a for loop to check each "box" of the array one after the other.
        {
            if (m_CharacteristicsArray[j] > m_SecondValue) // If the currently checked "box" of the array is bigger than the actual m_SecondValue
            {
                if (m_CharacteristicsArray[j] > m_FirstValue) //And if the currently checked "box" of the array is bigger than the actual m_FirstValue
                {
                    m_SecondValue = m_FirstValue;// Then m_SecondValue takes m_FirstValue's value 
                    m_FirstValue = m_CharacteristicsArray[j];// And m_FirstValue takes the currently checked "box" value
                }
                else //And if the currently checked "box" of the array is not bigger than the actual m_FirstValue
                {
                    m_SecondValue = m_CharacteristicsArray[j]; // m_SecondValue takes the currently checked box value.
                }

            }

        }

        if (((m_FirstValue == m_Speed) && (m_SecondValue == m_Damage)) || ((m_FirstValue == m_Damage) && (m_SecondValue == m_Speed))) //If the biggest characteristic is Speed and the second biggest is Damage or the other way arround, 
        {
            m_Archetype = "Assaut";// then the ship's archetype is assaut.

        }

        else if (((m_FirstValue == m_Speed) && (m_SecondValue == m_Capacity)) || ((m_FirstValue == m_Capacity) && (m_SecondValue == m_Speed)))
        {
            m_Archetype = "Pillard";
        }

        else if (((m_FirstValue == m_HealthPoint) && (m_SecondValue == m_Capacity)) || ((m_FirstValue == m_Capacity) && (m_SecondValue == m_HealthPoint)))
        {
            m_Archetype = "Blindé";
        }

        else if (((m_FirstValue == m_Speed) && (m_SecondValue == m_HealthPoint)) || ((m_FirstValue == m_HealthPoint) && (m_SecondValue == m_Speed)))
        {
            m_Archetype = "Explorateur";
        }

        else if (((m_FirstValue == m_HealthPoint) && (m_SecondValue == m_Damage)) || ((m_FirstValue == m_Damage) && (m_SecondValue == m_HealthPoint)))
        {
            m_Archetype = "Guerrier";

        }

    }
    #endregion

    public void CharacteristicsCalculation()
    {

        m_Speed = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Speed + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Speed + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Speed + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Speed;//Get the differents characteristics of the different pieces of the ship and add them to calculate it's characteristics
        m_Damage = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Damage + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Damage + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Damage + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Damage;
        m_HealthPoint = TriDataBase.instance.m_BowDico[m_CurrentBow].m_HealthPoint + TriDataBase.instance.m_SternDico[m_CurrentStern].m_HealthPoint + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_HealthPoint + TriDataBase.instance.m_MastDico[m_CurrentMast].m_HealthPoint;
        m_Capacity = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Capacity + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Capacity + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Capacity + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Capacity;
        m_Regeneration = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Regeneration + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Regeneration + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Regeneration + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Regeneration;
        m_Vision = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Vision + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Vision + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Vision + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Vision;
    }

    public void GetEquipement(GameObject EquipementSelected)
    {
        m_SelectedEquipement = EquipementSelected;
        m_ScriptShipEquipement = m_SelectedEquipement.GetComponent<ScriptShipEquipement>();


    }

    public void SaveEquipement()
    {
        switch (m_ScriptShipEquipement.m_EquipementType)
        {
            case "Specialist":
                PlayerPrefs.SetString("m_EquipedSpecialist", m_ScriptShipEquipement.m_EquipementName);
                break;

            case "Ultimate":
                PlayerPrefs.SetString("m_EquipedUltimate", m_ScriptShipEquipement.m_EquipementName);
                m_UltimateEquiped = true;
                break;
        }
    }

    public void SaveEquipement2 (int StorageIndex)
    {
        switch (StorageIndex)
        {
            case 1:
                PlayerPrefs.SetString("m_EquipedEquipement1", m_ScriptShipEquipement.m_EquipementName);
                break;

            case 2:
                PlayerPrefs.SetString("m_EquipedEquipement2", m_ScriptShipEquipement.m_EquipementName);
                break;

            case 3:
                PlayerPrefs.SetString("m_EquipedEquipement3", m_ScriptShipEquipement.m_EquipementName);
                break;

            case 4:
                PlayerPrefs.SetString("m_EquipedEquipement4", m_ScriptShipEquipement.m_EquipementName);
                m_UltimateEquiped = false;
                break;
        }
    }

    public void GetPiece(GameObject PieceSelected)//Get the script of the piece selected
    {
        m_SelectedPiece = PieceSelected;
        m_ScriptShipPieces = m_SelectedPiece.GetComponent<ScriptShipPieces>();

       
    }


    public void SavePiece() // Save the name of the selected piece in the memory
    {

       

        switch (m_ScriptShipPieces.m_PieceType)
        {
            case "Keel":
                PlayerPrefs.SetString("m_MemorizedKeel", m_ScriptShipPieces.m_PieceName);

                break;

            case "Bow":
                PlayerPrefs.SetString("m_MemorizedBow", m_ScriptShipPieces.m_PieceName);
                Debug.Log("OY");
                break;

            case "Stern":
                PlayerPrefs.SetString("m_MemorizedStern", m_ScriptShipPieces.m_PieceName);
                break;

            case "Mast":
                PlayerPrefs.SetString("m_MemorizedMast", m_ScriptShipPieces.m_PieceName);
                break;

            case "Specialist":
                PlayerPrefs.SetString("m_EquipedSpecialist", m_ScriptShipPieces.m_PieceName);
                break;

            case "Ultimate":
                PlayerPrefs.SetString("m_EquipedUltimate", m_ScriptShipPieces.m_PieceName);
                break;
        }
    }

    #endregion

}


