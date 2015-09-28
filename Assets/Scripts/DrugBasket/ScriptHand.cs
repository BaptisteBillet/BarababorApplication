using UnityEngine;
using System.Collections;

public class ScriptHand : MonoBehaviour
{
    public float m_Movement;

    [HideInInspector]
    public bool m_Direction;

    public GameObject m_Pill;
    Rigidbody m_PillRB;

    public float m_Shoot;

    bool m_Moving;

    bool m_IsShot;

	

    void Start ()
    {
        m_PillRB = m_Pill.GetComponent<Rigidbody>();
        m_Moving = true;
       
    }


	void Update ()
    {

        if (m_Moving==true)
        {
            if (m_Direction == true)
                this.transform.position += new Vector3(m_Movement, 0f, 0f) * Time.deltaTime;

            else if (m_Direction == false)
                this.transform.position += new Vector3(-m_Movement, 0f, 0f) * Time.deltaTime;

        }
       
       
    }

    public void Shoot()
    {
        if (m_IsShot==false)
        {
            m_Moving = false;
            m_IsShot = true;
            m_PillRB.AddForce(new Vector3(0f, m_Shoot, m_Shoot));
            m_PillRB.useGravity = true;
        }
       

    }
}
