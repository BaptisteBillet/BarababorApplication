using UnityEngine;
using System.Collections;

public class ScriptDrugsBasket : MonoBehaviour
{
    public ScriptHand m_ScriptHand;
    public ScriptDrugsUIPanel m_ScriptDrugsUIPanel;

    void Start ()
    {
        Location();
    }

    void OnTriggerEnter (Collider other)
    {
        m_ScriptDrugsUIPanel.FillHealthMeter();
        m_ScriptHand.ComeBack();
        Location();
    }
	
    public void Location()
    {
        this.transform.position =new Vector3 (Random.Range(-1.5f, 1.5f),-1.5f,20.36f);
    }
}
