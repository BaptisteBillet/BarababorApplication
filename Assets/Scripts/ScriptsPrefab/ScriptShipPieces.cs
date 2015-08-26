using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScriptShipPieces : MonoBehaviour {

	#region MembersDeclaration
	//Definitions of the piece
	public Image m_PieceIconField;
	public Sprite m_PieceIcon;
	public Text m_PieceNameField;
	public string m_PieceName;
	//_______________________________________________________________

	//Characteristics of the piece
	public int m_Speed;
	public int m_Damage;
	public int m_Capacity;
	public int m_HealthPoint;
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

	public GameObject m_Piece;
	MeshFilter m_PieceShape;
	Renderer m_PiecePaint; 

	public bool m_IsAvailable;

	#endregion

	void Start () 
	{


		m_PieceShape = m_Piece.GetComponent<MeshFilter> ();
		m_PiecePaint = m_Piece.GetComponent<Renderer> ();

		this.gameObject.SetActive (m_IsAvailable);// The piece is available only if it has been unlocked (bought in the shop) 

		m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager> ();//Get the script which controls the whole boathouse menu

		m_Ship = m_ScriptBoathouseManager.m_SelectedShip;//Get the selected ship in the boathouse's script

		m_ScriptShip = m_Ship.GetComponent<ScriptShip> ();// Get the ship's script, useful to get it's caracteristics 

		PieceSelection ();

		m_Description = "Vitesse :" + " " + m_Speed + " " + ", Domage :" + " " + m_Damage + " " + ", Capacité :" + " " + m_Capacity + " " + ", Points de vie :" + m_HealthPoint;// Display the piece's description like that

		m_SelectedPieceShape=m_PieceToChange.GetComponent<MeshFilter> ();//Get the Meshfilter of the ship's piece that's meant to be changed
		m_SelectedPieceRenderer = m_PieceToChange.GetComponent<Renderer> ();//Get also it's Renderer
	
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
		m_SelectedPieceShape.mesh = m_PieceShape.mesh; // change the shape of the piece on the boat by the selected piece's one
		m_SelectedPieceRenderer.material = m_PiecePaint.material;// same with the color, texture...

	}

	public void PieceSelection ()
	{
		switch (m_Piece.tag) 
		{
		case "Keel":
			m_PieceToChange = m_ScriptShip.m_ArrayofElements [0];
			break;
		
		case "Bow":
			m_PieceToChange = m_ScriptShip.m_ArrayofElements [1];
			break;

		case "Stern":
			m_PieceToChange = m_ScriptShip.m_ArrayofElements[2];
			break;

		case "Mast" : 
			m_PieceToChange = m_ScriptShip.m_ArrayofElements[3];
			break;

		}
	}








}
