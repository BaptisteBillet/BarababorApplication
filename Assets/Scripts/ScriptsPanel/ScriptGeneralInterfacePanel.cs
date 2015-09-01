using UnityEngine;
using System.Collections;

public class ScriptGeneralInterfacePanel : MonoBehaviour {

    public GameObject m_Ship;
    public GameObject m_Captain;

    public GameObject m_ShipSelection;

	// Use this for initialization
	void Start ()
    {
        m_Captain.SetActive(true);
        m_Ship.SetActive(false);
	
	}

    public void LoadBoathousePanel ()
    {
        m_ShipSelection.SetActive(true);
    }
	
	
}
