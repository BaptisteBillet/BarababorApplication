using UnityEngine;
using System.Collections;

public class ScriptBuyButton : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
	
	}
	
	public void Enabled (bool AlreadyBought)
    {
        this.gameObject.SetActive(!AlreadyBought);
    }
}
