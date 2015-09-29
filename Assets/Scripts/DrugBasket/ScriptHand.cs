using UnityEngine;
using System.Collections;

public class ScriptHand : MonoBehaviour
{
    public float m_Movement;

    public ScriptDrugsUIPanel m_ScriptDrugsUIPanel;

    [HideInInspector]
    public bool m_Direction;

    public GameObject m_Pill;
    Rigidbody m_PillRB;

    public float m_Shoot;

    public bool m_Moving;

    public bool m_IsShot;

    bool m_IsReady;

    public bool m_IsPlaying;
	

    void Start ()
    {
        m_IsPlaying = true;
        m_PillRB = m_Pill.GetComponent<Rigidbody>();
        m_Moving = true;
       
    }


	void Update ()
    {
        if(m_IsPlaying==true)
        {
            if (m_Moving == true)
            {
                if (m_Direction == true)
                    this.transform.position += new Vector3(m_Movement, 0f, 0f) * Time.deltaTime;

                else if (m_Direction == false)
                    this.transform.position += new Vector3(-m_Movement, 0f, 0f) * Time.deltaTime;

            }

            if (m_Pill.transform.position.y < -1f)
            {
                ComeBack();
            }
        }
        
    }

    public void OnMouseDown()
    {
        if (m_IsPlaying==true)
        {
            if (m_IsShot == false)
            {
                m_Moving = false;
                m_IsShot = true;

                m_PillRB.AddForce(new Vector3(0f, m_Shoot, m_Shoot));
                m_PillRB.useGravity = true;

                m_ScriptDrugsUIPanel.PillsCounter();
            }
        }
          
    }

 
    public void ComeBack()
    {
        m_PillRB.useGravity = false;
        m_PillRB.velocity = new Vector3(0f, 0f, 0f);
        m_Pill.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.61f, this.transform.position.z + 0.72f);
        m_IsShot = false;
        m_Moving = true;
        
        
    }
}
