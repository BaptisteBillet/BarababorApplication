using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoathouseShipEquipementButton : MonoBehaviour {

    public GameObject m_BoathousePanel;
    ScriptBoathouseManager m_ScriptBoathouseManager;

    GameObject m_Ship;
    ScriptShip m_ScriptShip;

    public int m_Index;

    public Text m_EquipementName;

    public GameObject m_BlackPanel;

	// Use this for initialization
	void Start ()
    {
        m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager>();

        m_Ship = m_ScriptBoathouseManager.m_SelectedShip;
        m_ScriptShip = m_Ship.GetComponent<ScriptShip>();

        m_EquipementName.text = m_ScriptShip.m_ArrayofEquipement[m_Index];
        	
	}
	


}
