using UnityEngine;
using System.Collections;

public class ScriptObjectsBehaviour : MonoBehaviour
{
    public GameObject m_Target;
    public GameObject m_Origin;

    public bool m_IsCoconut;

    
    public ScriptThirstMeter m_ScriptThirstMeter;

    public float m_Speed;

    Rigidbody m_RigidBody;

   void Start ()
    {
        ScriptThirstRunManager.e_EndGame += Destruct;

    }

    void FixedUpdate ()
    {    
       this.transform.position += new Vector3(0, 0, -20f)*Time.deltaTime;
            
    }

    void OnTriggerEnter (Collider other)
    {
       if (other.tag=="Captain"||other.tag == "Reciever")
        {
            ScriptThirstRunManager.e_EndGame -= Destruct;
            Destroy(this.gameObject);
        }
        
    }
    
	void Destruct ()
    {
        if (this!=null)
        Destroy(this.gameObject);
    }
	
	
}
