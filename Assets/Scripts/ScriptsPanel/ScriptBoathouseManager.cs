using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptBoathouseManager : MonoBehaviour {

	public GameObject m_CurrentPanel;
	
	public GameObject m_CurrentSection;

	public GameObject m_SelectedShip;

    public GameObject m_ButtonEquip;
    public GameObject m_ButtonEquip1;
    public GameObject m_ButtonEquip2;
    public GameObject m_ButtonEquip3;
    public GameObject m_ButtonEquip4;

    public int m_NumberofShip;

    

	// Use this for initialization
	
	
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

	public void MultiStorage (bool Enable)
    {
        m_ButtonEquip.SetActive (!Enable);
        m_ButtonEquip1.SetActive(Enable);
        m_ButtonEquip2.SetActive(Enable);
        m_ButtonEquip3.SetActive(Enable);
        m_ButtonEquip4.SetActive(Enable);
    }
	





}
