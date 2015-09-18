using UnityEngine;
using System.Collections;

public class ScriptBuyButton : MonoBehaviour {

    public ScriptGeneralCaptainShop m_ScriptGeneralCaptainShop;

    GameObject m_DisplayStand;
    ScriptDisplayStand m_ScriptDisplayStand;


	// Use this for initialization
	void Start () {
	
	}
	
	public void Enabled (bool AlreadyBought)
    {
        this.gameObject.SetActive(!AlreadyBought);
    }

    public void LaunchBuy()
    {
        m_DisplayStand = m_ScriptGeneralCaptainShop.m_CurrentDisplayStand;
        m_ScriptDisplayStand = m_DisplayStand.GetComponent<ScriptDisplayStand>();

        m_ScriptDisplayStand.Buy(true);

    }
    
}
