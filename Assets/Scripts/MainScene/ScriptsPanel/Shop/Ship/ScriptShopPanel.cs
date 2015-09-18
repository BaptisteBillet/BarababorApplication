using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScriptShopPanel : MonoBehaviour {

    public Text m_CoinsMetersField;
    public Text m_DiamondsMetersField;

    public List<string> m_NoseCatalog = new List<string>();
    public List<string> m_EarsCatalog = new List<string>();
    public List<string> m_EyesCatalog = new List<string>();
    public List<string> m_MouthCatalog = new List<string>();

    public List<string> m_JacketCatalog = new List<string>();
    public List<string> m_BootsCatalog = new List<string>();
    public List<string> m_PantsCatalog = new List<string>();
    public List<string> m_HatCatalog = new List<string>();

    public GameObject m_CaptainBody;
    public GameObject m_CaptainHead;

    [HideInInspector]
    public ScriptCaptainBody m_ScriptCaptainBody;

    [HideInInspector]
    public ScriptCaptainHead m_ScriptCaptainHead;

    public GameObject m_CurrentSection;

    public GameObject m_ShipPanel;
    public GameObject m_CaptainPanel;


    // Use this for initialization
    void Start ()
    {
        CurrencyMetersUpdate();

        m_ScriptCaptainBody = m_CaptainBody.GetComponent<ScriptCaptainBody>();
        m_ScriptCaptainHead = m_CaptainHead.GetComponent<ScriptCaptainHead>();
    }
	
	public void CurrencyMetersUpdate()
    {
        
        m_CoinsMetersField.text = "" + PlayerPrefs.GetInt("m_Coins");
        m_DiamondsMetersField.text = "" + PlayerPrefs.GetInt("m_Diamonds");
    }

    public void ChangeSection(GameObject Section)
    {
        m_CurrentSection.SetActive(false);
        Section.SetActive(true);
        m_CurrentSection = Section;

        if (m_CurrentSection==m_ShipPanel)
        {
            m_CaptainBody.SetActive(false);
            m_CaptainHead.SetActive(false);
        }

        if (m_CurrentSection == m_CaptainPanel)
        {
            m_CaptainBody.SetActive(true);
            m_CaptainHead.SetActive(true);
        }
    }

    public void Back (GameObject backdestination)
    {
        this.gameObject.SetActive(false);
        backdestination.SetActive(true);

    }

    

}
