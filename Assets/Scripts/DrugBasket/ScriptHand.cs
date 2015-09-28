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

    public bool m_Moving;

    public bool m_IsShot;

    bool m_IsReady;
	

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
       
       if (m_Pill.transform.position.y<-1f)
        {
            ComeBack();
        }
    }

    public void Shoot()
    {
      
           
            Debug.Log(m_IsShot);
            if (m_IsShot == false)
            {

                m_Moving = false;
                m_IsShot = true;

                m_PillRB.AddForce(new Vector3(0f, m_Shoot, m_Shoot));
                Debug.Log(m_Shoot);

                m_PillRB.useGravity = true;
            }

        

    }

   /* public void OnMouseUp()
    {
        m_IsReady = true;
    }
    */
    public void ComeBack()
    {
        m_PillRB.useGravity = false;
        m_Pill.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.61f, this.transform.position.z + 0.72f);
        m_IsShot = false;
        m_Moving = true;
        
        
    }
}
