using UnityEngine;
using System.Collections;

public class ScriptCookingPot : MonoBehaviour {

    public ScriptTurtleHungerbarManager m_ScriptTurtleHungerBarManager;

    public ScriptTurtleCurlingManager m_ScriptTurtleCurlingManager;

	// Use this for initialization
	void Start ()
    {
        Location();
	
	}
	
	void OnTriggerEnter(Collider other)
    {
        
        m_ScriptTurtleHungerBarManager.Fill();
    }

    public void Location()
    {
        switch (m_ScriptTurtleCurlingManager.m_LevelDesign)
        {
            case 0:
                this.transform.position = new Vector3(-3.12f, -19.5f, 6.94f);
                break;

            case 1:
                this.transform.position = new Vector3(4.66f, -19.5f, 0.89f);
                break;

            case 2:
                this.transform.position = new Vector3(-2.36f, -19.5f, 1.66f);
                break;

        }

    }
     
}
