using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptBoathouseManager : MonoBehaviour {

    public GameObject m_BoathousePanel;
    public GameObject m_MainPanel;

	public GameObject m_CurrentPanel;

    public GameObject m_ShipSelectionPanel;
    public GameObject m_ElementPanel;
    public GameObject m_EquipementPanel;
    public GameObject m_CustomizationPanel;
	
	public GameObject m_CurrentSection;

	public GameObject m_SelectedShip;
    ScriptShip m_ScriptShip;

    public GameObject m_ButtonEquip;
    public GameObject m_ButtonEquip1;
    public GameObject m_ButtonEquip2;
    public GameObject m_ButtonEquip3;
    public GameObject m_ButtonEquip4;

    public GameObject m_Captain;
    public int m_NumberofShip;

    public bool m_MultiStorageEnabled;

	// Use this for initialization
	
	
	public void LoadCustomizationMenu ()
	{
		m_ShipSelectionPanel.SetActive (false);
        m_CustomizationPanel.SetActive(true);
		m_ElementPanel.SetActive (true);
        m_SelectedShip.SetActive(true);
		
	}

    public void LoadElementPanel()
    {
        m_EquipementPanel.SetActive(false);
        m_ElementPanel.SetActive(true);

    }

    public void LoadEquipementPanel()
    {
        m_ElementPanel.SetActive(false);
        m_EquipementPanel.SetActive(true);

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
        m_ScriptShip = m_SelectedShip.GetComponent<ScriptShip>();
       
		
	}

	public void MultiStorage (bool Enable)
    {
        m_MultiStorageEnabled = Enable;

        m_ButtonEquip.SetActive (!Enable);
        m_ButtonEquip1.SetActive(Enable);
        m_ButtonEquip2.SetActive(Enable);
        m_ButtonEquip3.SetActive(Enable);
        m_ButtonEquip4.SetActive(Enable);
    }

    public void LaunchSave()
    {
        m_ScriptShip.SaveEquipement();
    }

    public void LaunchSave2(int Saveint)
    {
        m_ScriptShip.SaveEquipement2(Saveint);
    }
   

    public void Back()
    {
        m_SelectedShip.SetActive(false);
        m_ElementPanel.SetActive(false);
        m_EquipementPanel.SetActive(false);
        m_BoathousePanel.SetActive(false);
        m_CustomizationPanel.SetActive(false);

        m_MainPanel.SetActive(true);
        m_Captain.SetActive(true);

    }





}
