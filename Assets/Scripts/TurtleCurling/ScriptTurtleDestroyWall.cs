using UnityEngine;
using System.Collections;

public class ScriptTurtleDestroyWall : MonoBehaviour {

    public ScriptTurtle m_ScriptTurtle;


	void OnTriggerEnter (Collider other)
    {

        m_ScriptTurtle.ComeBackTurtle();
        
    }
}
