using UnityEngine;
using System.Collections;

public class ScriptObjectsBehaviour : MonoBehaviour
{
    public GameObject m_Target;
    public GameObject m_Origin;

    public bool m_IsCoconut;

    public GameObject m_Itself;

    public ScriptThirstMeter m_ScriptThirstMeter;

    public float m_Speed;

    Rigidbody m_RigidBody;

   void Start ()
    {
        m_RigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        m_RigidBody.AddForce(0f, 0f, -15f);

        if(m_Itself.transform.position.y !=-3.35f)
        {
            m_Itself.transform.position = new Vector3(this.transform.position.x,-3.35f, this.transform.position.z);
        }
    }

    void OnCollisionEnter (Collision other)
    {
       
        if (other.collider.tag == "Captain")
        {
           
            if (m_IsCoconut == true)
                m_ScriptThirstMeter.Fill();

            if (m_IsCoconut == false)
                m_ScriptThirstMeter.Empty();            
        }

        Destroy(this.gameObject);
    }
    
	
	
	
}
