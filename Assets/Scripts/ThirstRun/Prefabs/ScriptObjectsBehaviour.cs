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
       
    }

    void FixedUpdate ()
    {    
       this.transform.position += new Vector3(0, 0, -20f)*Time.deltaTime;
            
    }

    void OnTriggerEnter (Collider other)
    {
       
        Destroy(this.gameObject);
    }
    
	
	
	
}
