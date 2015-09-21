using UnityEngine;
using System.Collections;

public class ScriptCookingPot : MonoBehaviour {

    public ScriptTurtleHungerbarManager m_ScriptTurtleHungerBarManager;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other)
    {
       
        m_ScriptTurtleHungerBarManager.Fill();
    }
     
}
