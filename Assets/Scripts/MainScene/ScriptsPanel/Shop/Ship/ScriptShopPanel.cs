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


    // Use this for initialization
    void Start ()
    {
        CurrencyMetersUpdate();
	}
	
	public void CurrencyMetersUpdate()
    {
        
        m_CoinsMetersField.text = "" + PlayerPrefs.GetInt("m_Coins");
        m_DiamondsMetersField.text = "" + PlayerPrefs.GetInt("m_Diamonds");
    }
}
