using UnityEngine;
using System.Collections;

public class ScriptDrugsStop : MonoBehaviour
{
    public string m_Side;

    public GameObject m_Hand;
    ScriptHand m_ScriptHand;
   
	// Use this for initialization
	void Start ()
    {
        m_ScriptHand = m_Hand.GetComponent<ScriptHand>();
	}
	
	public void OnTriggerEnter(Collider Other)
    {
       
        if (m_Side == "Left")
            m_ScriptHand.m_Direction = false;

        else if (m_Side == "Right")
            m_ScriptHand.m_Direction = true;


    }
}
