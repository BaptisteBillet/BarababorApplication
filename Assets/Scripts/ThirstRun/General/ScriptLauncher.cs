using UnityEngine;
using System.Collections;

public class ScriptLauncher : MonoBehaviour {

    public GameObject m_Coconut;

    public GameObject m_BowlingBall;

    public ScriptThirstRunManager m_ScriptThirstRunManager;

    public ScriptThirstMeter m_ScriptThirstMeter;

    ScriptObjectsBehaviour m_Objectscript;

    public GameObject m_Target;

	// Use this for initialization
	void Start () {
	
	}
	
    public void Launch (int launch)
    {
        if (launch == 0)
        {

            m_Objectscript = m_Coconut.GetComponent<ScriptObjectsBehaviour>();

            
            m_Objectscript.m_IsCoconut = true;
            m_Objectscript.m_ScriptThirstMeter = m_ScriptThirstMeter;


            Instantiate(m_Coconut, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z-2f), this.transform.rotation);
        }

        else if (launch==1)
        {
            m_Objectscript = m_BowlingBall.GetComponent<ScriptObjectsBehaviour>();


            m_Objectscript.m_IsCoconut = false;
            m_Objectscript.m_ScriptThirstMeter = m_ScriptThirstMeter;


            Instantiate(m_BowlingBall, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z-2f), this.transform.rotation);
        }

        m_ScriptThirstRunManager.PrepareforLaunch();
        
    }
	
}
