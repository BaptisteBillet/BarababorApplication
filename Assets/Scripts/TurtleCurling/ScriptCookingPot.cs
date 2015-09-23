using UnityEngine;
using System.Collections;

public class ScriptCookingPot : MonoBehaviour {

    public ScriptTurtleHungerbarManager m_ScriptTurtleHungerBarManager;

    public ScriptTurtleCurlingManager m_ScriptTurtleCurlingManager;

    public ScriptTurtleWalls m_ScriptTurtleWalls;

 

    // Use this for initialization
    void Start ()
    {
      Location();
    }
	
	void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Turtle")
        m_ScriptTurtleHungerBarManager.Fill();
        m_ScriptTurtleCurlingManager.LevelDesignSelection();
        m_ScriptTurtleWalls.Location();
        Location();
    }

    public void Location()
    {
        switch (m_ScriptTurtleCurlingManager.m_LevelDesign)
        {
            case 0:
                this.transform.position = new Vector3(-3.12f, -24.5f, 6.94f);
                break;

            case 1:
                this.transform.position = new Vector3(4.66f, -24.5f, 0.89f);
                break;

            case 2:
                this.transform.position = new Vector3(-2.36f, -24.5f, 1.66f);
                break;

        }

    }

    

}
