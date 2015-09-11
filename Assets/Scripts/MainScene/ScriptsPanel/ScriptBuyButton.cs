using UnityEngine;
using System.Collections;

public class ScriptBuyButton : MonoBehaviour {

    public GameObject m_BuyButton;

	// Use this for initialization
	void Start () {
	
	}
	
	public void Enabled (bool AlreadyBought)
    {
        m_BuyButton.SetActive(!AlreadyBought);
    }
}
