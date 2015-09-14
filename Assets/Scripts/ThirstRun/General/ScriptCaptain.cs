using UnityEngine;
using System.Collections;

public class ScriptCaptain : MonoBehaviour {

    public ScriptThirstMeter m_ScriptThirstMeter;


	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Coconut")
        {

           m_ScriptThirstMeter.Fill();
          
        }


        if (other.tag== "BowlingBall")
        {
            m_ScriptThirstMeter.Empty();
        } 
        
    }
}
