using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptShopPanel : MonoBehaviour {

    public Text m_CoinsMetersField;
    public Text m_DiamondsMetersField;

    

	// Use this for initialization
	void Start ()
    {

        m_CoinsMetersField.text = "" + PlayerPrefs.GetInt("m_Coins");
        m_DiamondsMetersField.text = "" + PlayerPrefs.GetInt("m_Diamonds");
	
	}
	
	
}
