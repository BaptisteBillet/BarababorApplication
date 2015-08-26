using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptBoathouseManager : MonoBehaviour {

	public GameObject m_CurrentPanel;
	
	public GameObject m_CurrentSection;

	public GameObject m_SelectedShip;

	public int m_NumberofShip;
	

	// Use this for initialization
	void Start () 
	{


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
		Debug.Log (m_SelectedShip);
	}
}
