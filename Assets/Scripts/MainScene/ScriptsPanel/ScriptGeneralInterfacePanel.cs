using UnityEngine;
using System.Collections;

public class ScriptGeneralInterfacePanel : MonoBehaviour {

    public GameObject m_Ship;
    public GameObject m_CaptainBody;
   

    public GameObject m_ShipSelection;

	// Use this for initialization
	void Start ()
    {
        m_CaptainBody.SetActive(true);
      
        m_Ship.SetActive(false);

        m_CaptainBody.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        m_CaptainBody.transform.position = new Vector3(m_CaptainBody.transform.position.x, -0.1f, m_CaptainBody.transform.position.z);

    }

    public void LoadBoathousePanel ()
    {
        m_ShipSelection.SetActive(true);
    }
	
	
}
