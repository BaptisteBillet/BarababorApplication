using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;



public class ScriptShip : MonoBehaviour
{
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
    public string m_EquipedUltime;





    //____________________________________________________________________________________________




    string m_MemorizedKeel;
    string m_MemorizedBow;
    string m_MemorizedStern;
    string m_MemorizedMast;

    public bool m_FirstTime;

    GameObject m_SelectedPiece;
    ScriptShipPieces m_ScriptShipPieces;





    //_____________________________________________________________________________________________

    // Use this for initialization
    void Start()
    {
        m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager>();


        /* m_CurrentBow =  m_ScriptBoathouseManager.m_CurrentBow;
         m_CurrentKeel = m_ScriptBoathouseManager.m_CurrentKeel;
         m_CurrentMast = m_ScriptBoathouseManager.m_CurrentMast;
         m_CurrentStern =m_ScriptBoathouseManager.m_CurrentStern;
        */

        if (m_FirstTime == true)
        {
            PlayerPrefs.SetString("m_MemorizedKeel", "QuilleDefault");
            PlayerPrefs.SetString("m_MemorizedBow", "ProueDefault");
            PlayerPrefs.SetString("m_MemorizedStern", "PoupeDefault");
            PlayerPrefs.SetString("m_MemorizedMast", "VoileDefault");
        }

        m_CurrentBow = PlayerPrefs.GetString("m_MemorizedBow");
        m_CurrentKeel = PlayerPrefs.GetString("m_MemorizedKeel");
        m_CurrentStern = PlayerPrefs.GetString("m_MemorizedStern");
        m_CurrentMast = PlayerPrefs.GetString("m_MemorizedMast");



        m_ArrayofElements[0] = m_CurrentKeel;
        m_ArrayofElements[1] = m_CurrentBow;
        m_ArrayofElements[2] = m_CurrentStern;
        m_ArrayofElements[3] = m_CurrentMast;

        CharacteristicsCalculation();

        Debug.Log(m_CurrentBow);

        int m_ConvertedDamage = Mathf.CeilToInt(m_Damage);

        //Initialize all the members
        m_FirstValue = 0;
        m_SecondValue = 0;

        m_CharacteristicsArray[0] = m_Speed;
        m_CharacteristicsArray[1] = m_ConvertedDamage;
        m_CharacteristicsArray[2] = m_HealthPoint;
        m_CharacteristicsArray[3] = m_Capacity;
        m_CharacteristicsArray[4] = m_Regeneration;
        m_CharacteristicsArray[5] = m_Vision;

        m_SpeedField.text = " " + m_Speed;
        m_DamageField.text = " " + m_Damage;
        m_CapacityField.text = "" + m_Capacity;
        m_HealthPointField.text = " " + m_HealthPoint;
        m_RegenerationField.text = " " + m_Regeneration;
        m_VisionField.text = " " + m_Vision;

      /*  m_ArrayofEquipement[0] = PlayerPrefs.GetString("m_EquipedSpecialist");
        m_ArrayofEquipement[1] = PlayerPrefs.GetString("m_EquipedEquipement1");
        m_ArrayofEquipement[2] = PlayerPrefs.GetString("m_EquipedEquipement2");
        m_ArrayofEquipement[3] = PlayerPrefs.GetString("m_EquipedEquipement3");

        if (m_EquipedUltime == null)
        {
            m_ArrayofEquipement[4] = PlayerPrefs.GetString("m_EquipedEquipement4");
        }
        else
        {
            m_ArrayofEquipement[5] = PlayerPrefs.GetString("m_EquipedUltime");
        }
        */
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

        m_Speed = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Speed + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Speed + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Speed + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Speed;
        m_Damage = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Damage + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Damage + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Damage + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Damage;
        m_HealthPoint = TriDataBase.instance.m_BowDico[m_CurrentBow].m_HealthPoint + TriDataBase.instance.m_SternDico[m_CurrentStern].m_HealthPoint + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_HealthPoint + TriDataBase.instance.m_MastDico[m_CurrentMast].m_HealthPoint;
        m_Capacity = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Capacity + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Capacity + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Capacity + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Capacity;
        m_Regeneration = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Regeneration + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Regeneration + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Regeneration + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Regeneration;
        m_Vision = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Vision + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Vision + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Vision + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Vision;
    }

    public void GetEquipement()
    { }

    public void SaveEquipement()
    {
        switch (m_ScriptShipPieces.m_PieceType)
        {
            case "Keel":
                PlayerPrefs.SetString("CurrentKeel", m_ScriptShipPieces.m_PieceName);
                break;

            case "Bow":
                PlayerPrefs.SetString("CurrentBow", m_ScriptShipPieces.m_PieceName);
                break;

            case "Stern":
                PlayerPrefs.SetString("CurrentStern", m_ScriptShipPieces.m_PieceName);
                break;

            case "Mast":
                PlayerPrefs.SetString("CurrentMast", m_ScriptShipPieces.m_PieceName);
                break;
        }

    }


    public void GetPiece(GameObject PieceSelected)
    {
        m_SelectedPiece = PieceSelected;
        m_ScriptShipPieces = m_SelectedPiece.GetComponent<ScriptShipPieces>();

        Debug.Log(m_ScriptShipPieces.m_PieceName);

        Debug.Log(m_ScriptShipPieces.m_PieceType);
    }


    public void SavePiece()
    {

        Debug.Log(m_ScriptShipPieces.m_PieceType);

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
        }
    }

}


