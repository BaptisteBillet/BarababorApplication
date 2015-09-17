using UnityEngine;
using System.Collections;

public class ScriptGeneralCaptainShop : MonoBehaviour {

    public GameObject m_Captain;
    public GameObject m_FirstDisplayStand;

    GameObject m_CurrentDisplayStand;

    public GameObject[] m_ArrayofCaptainParts = new GameObject[11];

	// Use this for initialization
	void Start ()
    {
        m_Captain.SetActive(true);
        m_Captain.transform.localScale = new Vector3 (0.43f, 0.43f, 0.43f);
        m_Captain.transform.position = new Vector3(m_Captain.transform.position.x, 0.46f, m_Captain.transform.position.z);

        LoadDisplayStand(m_FirstDisplayStand);
	}

    public void LoadDisplayStand(GameObject DisplayStand)
    {
        DisplayStand.SetActive(true);
        m_CurrentDisplayStand = DisplayStand;
    }
	
    public void UnloadDisplayStand ()
    {
        m_CurrentDisplayStand.SetActive(false);
    }
	
}
