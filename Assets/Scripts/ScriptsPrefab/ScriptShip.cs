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
	public int m_Damage;
	public int m_HealthPoint;
	public int m_Capacity;

	int [] m_CharacteristicsArray = new int[4];

	//______________________________________________________________________________________
		
	// Members useful to organize the characteristics	
	int m_FirstValue;
	int m_SecondValue;

	//______________________________________________________________________________________

	//Different parts of the ship
	public GameObject [] m_ArrayofElements = new GameObject[4]; 

	ScriptElements m_ScriptBow;
	ScriptElements m_ScriptStern;
	ScriptElements m_ScriptMast;
	ScriptElements m_ScriptKeel;



	// Use this for initialization
	void Start () 
	{

		m_ScriptKeel = m_ArrayofElements [0].GetComponent<ScriptElements>();
		m_ScriptBow = m_ArrayofElements [1].GetComponent<ScriptElements>();
		m_ScriptStern = m_ArrayofElements [2].GetComponent<ScriptElements>();
		m_ScriptMast = m_ArrayofElements [3].GetComponent<ScriptElements>();


		CharacteristicsCalculation (); 

		//Initialize all the members
		m_FirstValue = 0;
		m_SecondValue = 0;

		m_CharacteristicsArray [0] = m_Speed;
		m_CharacteristicsArray [1] = m_Damage;
		m_CharacteristicsArray [2] = m_HealthPoint;
		m_CharacteristicsArray [3] = m_Capacity;


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
	
		m_Speed = m_ScriptKeel.m_Speed + m_ScriptBow.m_Speed + m_ScriptStern.m_Speed + m_ScriptMast.m_Speed;
		m_Damage = m_ScriptKeel.m_Damage + m_ScriptBow.m_Damage + m_ScriptStern.m_Damage + m_ScriptMast.m_Damage;
		m_HealthPoint = m_ScriptKeel.m_HealthPoint + m_ScriptBow.m_HealthPoint + m_ScriptStern.m_HealthPoint + m_ScriptMast.m_HealthPoint;
		m_Capacity = m_ScriptKeel.m_Capacity + m_ScriptBow.m_Capacity + m_ScriptStern.m_Capacity + m_ScriptMast.m_Capacity;


	}
}




