using UnityEngine;
using System.Collections;

public class ScriptGeneralCaptainCustomizationPanel : MonoBehaviour {

    public GameObject Captain;

    public GameObject m_CaptainHead;

    public int m_PanelNumber;

    GameObject m_CurrentPanel;


	// Use this for initialization
	void Start ()
    {
        m_CurrentPanel = this.gameObject;
        m_PanelNumber = 0;
        Captain.SetActive(true);
        //CaptainScale(m_PanelNumber);

    }
	
    public void CaptainScale(int panel)
    {
        switch (panel)
        {
            case 0:
                Captain.transform.localScale = new Vector3(1f, 1f, 1f);
                Captain.transform.position = new Vector3(0f, 0.1f, 2.5f);
                break;

            case 1:
            
                Captain.transform.localScale = new Vector3(1f, 1f, 1f);
                Captain.transform.position = new Vector3(0f, 0.6f, 2.5f);
                break;

        }
    }

    public void ChangePanel(GameObject Panel)
    {
        m_CurrentPanel.SetActive(false);
        Panel.SetActive(true);
        m_CurrentPanel = Panel;

    }
	
}
