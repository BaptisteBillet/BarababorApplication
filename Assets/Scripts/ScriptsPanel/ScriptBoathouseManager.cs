using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptBoathouseManager : MonoBehaviour {

	public GameObject m_CurrentPanel;
	
	public GameObject m_CurrentSection;

	public GameObject m_SelectedShip;

	public int m_NumberofShip;

	GameObject m_SelectedPiece;
	ScriptShipPieces m_ScriptShipPieces;

    public bool m_FirstTime;

	string m_MemorizedKeel;
	string m_MemorizedBow;
	string m_MemorizedStern;
	string m_MemorizedMast;

	public string m_CurrentKeel;
	public string m_CurrentBow;
	public string m_CurrentStern;
	public string m_CurrentMast;

	// Use this for initialization
	void Awake () 
	{
        if (m_FirstTime==true)
        {
            
            PlayerPrefs.SetString("m_MemorizedKeel", "QuilleDefault");
            PlayerPrefs.SetString("m_MemorizedBow", "ProueDefault");
            PlayerPrefs.SetString("m_MemorizedStern", "PoupeDefault");
            PlayerPrefs.SetString("m_MemorizedMast", "VoileDefault");

          

            m_CurrentBow = PlayerPrefs.GetString("m_MemorizedBow");
            m_CurrentKeel = PlayerPrefs.GetString("m_MemorizedKeel");
            m_CurrentStern = PlayerPrefs.GetString("m_MemorizedStern");
            m_CurrentMast = PlayerPrefs.GetString("m_MemorizedMast");

     
        }

        else
        {
            m_CurrentBow = PlayerPrefs.GetString("m_MemorizedBow");
            m_CurrentKeel = PlayerPrefs.GetString("m_MemorizedKeel");
            m_CurrentStern = PlayerPrefs.GetString("m_MemorizedStern");
            m_CurrentMast = PlayerPrefs.GetString("m_MemorizedMast");
        }

       
		
	}

	
	public void ChangePanel (GameObject PanelToLoad)
	{
		m_CurrentPanel.SetActive (false);
		PanelToLoad.SetActive (true);
		m_CurrentPanel = PanelToLoad;
	}
	
	public void ChangeSection (GameObject SectionToLoad)
	{
		m_CurrentSection.SetActive (false);
		SectionToLoad.SetActive (true);
		m_CurrentSection = SectionToLoad;
	}

	public void ShipStorage (GameObject Ship)
	{
		m_SelectedShip = Ship;
		
	}

	public void GetPiece (GameObject PieceSelected)
	{
		m_SelectedPiece = PieceSelected;
		m_ScriptShipPieces = m_SelectedPiece.GetComponent<ScriptShipPieces> ();

       Debug.Log (m_ScriptShipPieces.m_PieceName);

        Debug.Log(m_ScriptShipPieces.m_PieceType);
    }

	public void SavePiece ()
	{

        Debug.Log(m_ScriptShipPieces.m_PieceType);

        switch (m_ScriptShipPieces.m_PieceType) 
		{
		case "Keel":
			PlayerPrefs.SetString ("m_MemorizedKeel", m_ScriptShipPieces.m_PieceName);
            
			break;
			
		case "Bow":
			PlayerPrefs.SetString ("m_MemorizedBow", m_ScriptShipPieces.m_PieceName);
                Debug.Log("OY");
            break;
			
		case "Stern":
			PlayerPrefs.SetString ("m_MemorizedStern", m_ScriptShipPieces.m_PieceName);
			break;
			
		case "Mast":
			PlayerPrefs.SetString ("m_MemorizedMast", m_ScriptShipPieces.m_PieceName);
			break;
		}
        

	}

	public void SaveEquipement ()
	{
		switch (m_ScriptShipPieces.m_PieceType) 
		{
		case "Keel":
			PlayerPrefs.SetString ("CurrentKeel", m_ScriptShipPieces.m_PieceName);
			break;
			
		case "Bow":
			PlayerPrefs.SetString ("CurrentBow", m_ScriptShipPieces.m_PieceName);
			break;
			
		case "Stern":
			PlayerPrefs.SetString ("CurrentStern", m_ScriptShipPieces.m_PieceName);
			break;
			
		case "Mast":
			PlayerPrefs.SetString ("CurrentMast", m_ScriptShipPieces.m_PieceName);
			break;
		}
		
	}





}
