using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class ScriptShipEquipement : MonoBehaviour {

	#region MembersDeclaration
	//Definitions of the piece
	public Image m_EquipementIconField;
	public Sprite m_EquipementIcon;
	public Text m_EquipementNameField;
	public string m_EquipementNameShown;
	//_______________________________________________________________

	
	//Description of the piece
	string m_Description;
    //_______________________________________________________________
    //Characteristics of an Equipement
    public int m_Damage;
    public int m_Range;
    public float m_Cooldown;
    public int m_ShootType;

    public string m_Speciality;
    public int m_SpecialistValue;


    //______________________________________________________________

	//Where the piece's description is displayed
	public Text m_DescriptionField;

	//The ship we're customizing and the script where all it's infos are kept
	GameObject m_Ship;
	ScriptShip m_ScriptShip;
	//_______________________________________________________________
    
	public string m_EquipementName; 

	public string m_EquipementType; // Enter Here the type of the piece, if it's a Specialist, a Weapon, a Gadget or an Ultimate

	public bool m_IsAvailable;

    #endregion

    void Start () 
	{
	
		this.gameObject.SetActive (m_IsAvailable);// The piece is available only if it has been unlocked (bought in the shop)

        m_EquipementNameField.text = m_EquipementNameShown;
       

	}


	public void DisplayPieceInfo ()//Started by a button click
	{
        
		m_DescriptionField.text = m_Description; //Display the description of the piece in the special place 

        Debug.Log("OY");
        
        m_EquipementIconField.sprite = m_EquipementIcon;// Display the piece's icon
	}

	

	
	public void GetCharacteristics ()
	{
		switch (m_EquipementType) 
		{
		case "Specialist" :
                m_Speciality = TriDataBase.instance.m_SpecialistDico[m_EquipementName].m_Speciality;
                m_SpecialistValue = TriDataBase.instance.m_SpecialistDico[m_EquipementName].m_Value;
                break;

		case "Weapon" :
                m_Damage =   TriDataBase.instance.m_WeaponDico[m_EquipementName].m_Damage;
                m_Range =    TriDataBase.instance.m_WeaponDico[m_EquipementName].m_Range;
                m_Cooldown = TriDataBase.instance.m_WeaponDico[m_EquipementName].m_Cooldown;
                m_ShootType= TriDataBase.instance.m_WeaponDico[m_EquipementName].m_ShootType;
                break;

		case "Gadget" :
                m_Damage =   TriDataBase.instance.m_GadgetDico[m_EquipementName].m_Damage;
                m_Range =    TriDataBase.instance.m_GadgetDico[m_EquipementName].m_Range;
                m_Cooldown = TriDataBase.instance.m_GadgetDico[m_EquipementName].m_Cooldown;
                m_ShootType= TriDataBase.instance.m_GadgetDico[m_EquipementName].m_ShootType;
                break;

            case "Ultimate" :
                m_Damage =   TriDataBase.instance.m_UltimateDico[m_EquipementName].m_Damage;
                m_Range =    TriDataBase.instance.m_UltimateDico[m_EquipementName].m_Range;
                m_Cooldown = TriDataBase.instance.m_UltimateDico[m_EquipementName].m_Cooldown;
                m_ShootType =TriDataBase.instance.m_UltimateDico[m_EquipementName].m_ShootType;
                break;

        }

        if (m_EquipementType == "Specialist")
        {
            m_Description = "Spécialité" + " " + m_Speciality +" "+ "Qualification" + " " + m_SpecialistValue;
        }

        else
        {
            m_Description = "Domages :" + " " + m_Damage + " " + ", Range :" + " " + m_Range + " " + ", CoolDown :" + " " + m_Cooldown + " " + ", Genre de tir :" + m_ShootType;// Display the piece's description like that
        }

    }







}
