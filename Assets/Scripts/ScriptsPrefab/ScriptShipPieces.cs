using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class ScriptShipPieces : MonoBehaviour {

	#region MembersDeclaration
	//Definitions of the piece
	public Image m_PieceIconField;
	public Sprite m_PieceIcon;
	public Text m_PieceNameField;
	public string m_PieceNameShown;
	//_______________________________________________________________

	//Characteristics of the piece
	int m_Speed;
	float m_Damage;
	int m_Capacity;
	int m_HealthPoint;
	//_______________________________________________________________

	//Description of the piece
	string m_Description; 
	//_______________________________________________________________


	//Where the result of the addition of the ship's characteristics and the piece's ones is displayed
	public Text m_FieldSpeed;
	public Text m_FieldDamage;
	public Text m_FieldCapacity;
	public Text m_FieldHP;
	//_______________________________________________________________


	//Where the piece's description is displayed
	public Text m_DescriptionField;

	//_______________________________________________________________

	public GameObject m_BoathousePanel;
	ScriptBoathouseManager m_ScriptBoathouseManager;


	//The ship we're customizing and the script where all it's infos are kept
	GameObject m_Ship;
	ScriptShip m_ScriptShip;
	//_______________________________________________________________

	//The piece we want to change
	GameObject m_PieceToChange;

	//MeshFilter and Renderer of the Element we want to change

	MeshFilter m_SelectedPieceShape;
	Renderer m_SelectedPieceRenderer; 

	//_______________________________________________________________

	//Mesh and Renderer of the piece we want to place on the ship

	public string m_PieceName; 

	public string m_PieceType; // Enter Here the type of the piece, if it's a bow, a keel, a stern or a mast

	public bool m_IsAvailable;





	#endregion

	void Start () 
	{
	
		this.gameObject.SetActive (m_IsAvailable);// The piece is available only if it has been unlocked (bought in the shop)

		m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager> ();//Get the script which controls the whole boathouse menu

		m_Ship = m_ScriptBoathouseManager.m_SelectedShip;//Get the selected ship in the boathouse's script

		m_ScriptShip = m_Ship.GetComponent<ScriptShip> ();// Get the ship's script, useful to get it's caracteristics 

	}


	public void DisplayPieceInfo ()//Started by a button click
	{

		m_DescriptionField.text = m_Description; //Display the description of the piece in the special place 

		m_FieldSpeed.text = ""+(m_ScriptShip.m_Speed + m_Speed);// Display what will be the caracteristics of the ship with this piece, it's the addition of the caracteristics already there and the piece's ones
		m_FieldDamage.text = "" +(m_ScriptShip.m_Damage + m_Damage);
		m_FieldCapacity.text = ""+(m_ScriptShip.m_Capacity + m_Capacity);
		m_FieldHP.text =""+ (m_ScriptShip.m_HealthPoint + m_HealthPoint);
	
		m_PieceIconField.sprite = m_PieceIcon;// Display the piece's icon
	}

	public void ModifyPieceAppearance()// Started with in the same time as DisplayPieceInfo 
	{


	}

	public void PieceSelection ()
	{
		switch (m_PieceType) 
		{
		case "Keel":
			m_ScriptShip.m_ArrayofElements [0] = m_PieceName;
			break;
		
		case "Bow":
			m_ScriptShip.m_ArrayofElements [1] = m_PieceName;
			break;

		case "Stern":
			m_ScriptShip.m_ArrayofElements[2] = m_PieceName;
			break;

		case "Mast" : 
			m_ScriptShip.m_ArrayofElements[3] = m_PieceName;
			break;

		}
	}



	public void GetCharacteristics ()
	{
		switch (m_PieceType) 
		{
		case "Keel" : 
			m_Speed = TriDataBase.instance.m_KeelDico[m_PieceName].m_Speed;
			m_Damage = TriDataBase.instance.m_KeelDico[m_PieceName].m_Damage;
			m_HealthPoint = TriDataBase.instance.m_KeelDico[m_PieceName].m_HealthPoint;
			m_Capacity =TriDataBase.instance.m_KeelDico[m_PieceName].m_Capacity;
			break;

		case "Bow" : 
			m_Speed = TriDataBase.instance.m_BowDico[m_PieceName].m_Speed;
			m_Damage = TriDataBase.instance.m_BowDico[m_PieceName].m_Damage;
			m_HealthPoint = TriDataBase.instance.m_BowDico[m_PieceName].m_HealthPoint;
			m_Capacity =TriDataBase.instance.m_BowDico[m_PieceName].m_Capacity;
			break;

		case "Stern" : 
			m_Speed = TriDataBase.instance.m_SternDico[m_PieceName].m_Speed;
			m_Damage = TriDataBase.instance.m_SternDico[m_PieceName].m_Damage;
			m_HealthPoint = TriDataBase.instance.m_SternDico[m_PieceName].m_HealthPoint;
			m_Capacity =TriDataBase.instance.m_SternDico[m_PieceName].m_Capacity;
			break;

		case "Mast" : 
			m_Speed = TriDataBase.instance.m_MastDico[m_PieceName].m_Speed;
			m_Damage = TriDataBase.instance.m_MastDico[m_PieceName].m_Damage;
			m_HealthPoint = TriDataBase.instance.m_MastDico[m_PieceName].m_HealthPoint;
			m_Capacity =TriDataBase.instance.m_MastDico[m_PieceName].m_Capacity;
			break;

		}

        m_Description = "Vitesse :" + " " + m_Speed + " " + ", Domage :" + " " + m_Damage + " " + ", Capacité :" + " " + m_Capacity + " " + ", Points de vie :" + m_HealthPoint;// Display the piece's description like that
    }







}
