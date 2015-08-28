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



	int [] m_CharacteristicsArray = new int[4];

	//______________________________________________________________________________________
		
	// Members useful to organize the characteristics	
	int m_FirstValue;
	int m_SecondValue;

	//______________________________________________________________________________________

	//Different parts of the ship
	public string [] m_ArrayofElements = new string[4]; 

	public string m_CurrentBow;
	public string m_CurrentStern;
	public string m_CurrentMast;
	public string m_CurrentKeel;

	public GameObject m_BoathousePanel;
	ScriptBoathouseManager m_ScriptBoathouseManager;


    //To Delete

    public Text m_SpeedField;
    public Text m_DamageField;
    public Text m_CapacityField;
    public Text m_HealthPointField;

	// Use this for initialization
	void Start () 
	{
		m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager> ();


		m_CurrentBow = m_ScriptBoathouseManager.m_CurrentBow;
		m_CurrentKeel = m_ScriptBoathouseManager.m_CurrentKeel;
		m_CurrentMast = m_ScriptBoathouseManager.m_CurrentMast;
		m_CurrentStern = m_ScriptBoathouseManager.m_CurrentStern;


        m_ArrayofElements [0]=m_CurrentKeel;
		m_ArrayofElements [1]=m_CurrentBow ;
		m_ArrayofElements [2]=m_CurrentStern;
		m_ArrayofElements [3]=m_CurrentMast;

        CharacteristicsCalculation();

        Debug.Log(m_CurrentBow);

		int m_ConvertedDamage = Mathf.CeilToInt(m_Damage);

		//Initialize all the members
		m_FirstValue = 0;
		m_SecondValue = 0;

		m_CharacteristicsArray [0] = m_Speed;
		m_CharacteristicsArray [1] = m_ConvertedDamage;
		m_CharacteristicsArray [2] = m_HealthPoint;
		m_CharacteristicsArray [3] = m_Capacity;

        m_SpeedField.text =" " + m_Speed;
        m_DamageField.text =" " + m_Damage;
        m_CapacityField.text = "" + m_Capacity;
        m_HealthPointField.text = " " + m_HealthPoint;

        ArchetypeAttribution ();// Launch ArchetypeAttribution.

	}

	#region Archetype
	public void ArchetypeAttribution ()
	{
		for (int j=0; j<4; j++) // Use a for loop to check each "box" of the array one after the other.
		{
			if (m_CharacteristicsArray [j] > m_SecondValue) // If the currently checked "box" of the array is bigger than the actual m_SecondValue
			{
				if (m_CharacteristicsArray [j] > m_FirstValue) //And if the currently checked "box" of the array is bigger than the actual m_FirstValue
				{
					m_SecondValue = m_FirstValue;// Then m_SecondValue takes m_FirstValue's value 
					m_FirstValue=m_CharacteristicsArray [j];// And m_FirstValue takes the currently checked "box" value
				} 
				else //And if the currently checked "box" of the array is not bigger than the actual m_FirstValue
				{
					m_SecondValue = m_CharacteristicsArray [j]; // m_SecondValue takes the currently checked box value.
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

	public void CharacteristicsCalculation ()
	{
	
		m_Speed = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Speed + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Speed + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Speed + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Speed;
		m_Damage = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Damage + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Damage + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Damage + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Damage;
		m_HealthPoint = TriDataBase.instance.m_BowDico[m_CurrentBow].m_HealthPoint + TriDataBase.instance.m_SternDico[m_CurrentStern].m_HealthPoint + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_HealthPoint + TriDataBase.instance.m_MastDico[m_CurrentMast].m_HealthPoint;
		m_Capacity = TriDataBase.instance.m_BowDico[m_CurrentBow].m_Capacity + TriDataBase.instance.m_SternDico[m_CurrentStern].m_Capacity + TriDataBase.instance.m_KeelDico[m_CurrentKeel].m_Capacity + TriDataBase.instance.m_MastDico[m_CurrentMast].m_Capacity;


	}
}




