using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptShipButton : MonoBehaviour 
{
	// Fields to complete
	public Text m_ShipName;
	public Image m_Icon;

	//_______________________________________________________________________________________
	//Sprite stock to change the ship's archetype Icon
	public Sprite [] m_ArrayofIcon = new Sprite[5];

	//_______________________________________________________________________________________
	//The ship we talk about and his ScriptShip
	public GameObject m_Ship;
	ScriptShip m_ScriptShip;

	//_______________________________________________________________________________________


	void Start () 
	{
		m_ScriptShip = m_Ship.GetComponent<ScriptShip> ();//Get the ScriptShip of the ship and stock it in the member m_Scriptship

		m_ShipName.text = m_ScriptShip.m_ShipName;

		DisplayInfo ();// Launch DisplayInfo

	}

	public void DisplayInfo ()
	{
		switch (m_ScriptShip.m_Archetype) // According to the value of m_Archetype from the ship,
		{

			case "Assaut" : // if the ship's archetype is Assaut,
			m_Icon.sprite = m_ArrayofIcon[0];// The icon of the ship become the assault one. 
			break;

		case "Pillard" :
			m_Icon.sprite = m_ArrayofIcon[1];
			break;

		case "Guerrier":
			m_Icon.sprite = m_ArrayofIcon[2];
			break;

		case "Explorateur" :
			m_Icon.sprite = m_ArrayofIcon [3];
			break;

		case "Blindé" :
			m_Icon.sprite = m_ArrayofIcon [4];
			break;

		}
	}



}
