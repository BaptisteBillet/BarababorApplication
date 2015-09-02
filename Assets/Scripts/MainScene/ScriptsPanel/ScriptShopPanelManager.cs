using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptShopPanelManager : MonoBehaviour {

    public GameObject m_Ship;
    ScriptShip m_ScriptShip;

    List<string> m_PossessedWeapons = new List<string>();

	// Use this for initialization
	void Start ()
    {
        m_ScriptShip = m_Ship.GetComponent<ScriptShip>();
	}
	
	
}
