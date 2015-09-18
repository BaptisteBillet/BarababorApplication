using UnityEngine;
using System.Collections;

public class ScriptGeneralCaptainShop : MonoBehaviour {

    public GameObject m_Captain;
    public GameObject m_FirstDisplayStand;

    [HideInInspector]
    public GameObject m_CurrentDisplayStand;

    public GameObject m_CurrentSection;

	
	void Start ()
    {
        m_Captain.SetActive(true);
        m_Captain.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
        m_Captain.transform.position = new Vector3(m_Captain.transform.position.x, 0.50f, m_Captain.transform.position.z);

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

    public void ChangeSection(GameObject Section)
    {
      
        m_CurrentSection.SetActive(false);
        Section.SetActive(true);
        m_CurrentSection = Section;
    }

}
