using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptTurtle : MonoBehaviour {

    Vector3 m_ScreenPoint;

    Rigidbody m_RB;

    public ScriptTurtleCurlingManager m_ScriptTurtleCurlingManager;

    public GameObject m_Sight;

    Quaternion m_RotationMemory;

    bool m_IsThrown; 
    
    float m_RotationY;

    public Slider m_Slider;

   
   

    // Use this for initialization
    void Start()
    {
        

        m_RB = this.GetComponent<Rigidbody>();


     
    }

   void Update()
    {
       if ((m_IsThrown == true) && (m_RB.velocity.x <= 0.03f) && (m_RB.velocity.x >= 0.03f) && (m_RB.velocity.y <= 0.03f) && (m_RB.velocity.y >= 0.03f) && (m_RB.velocity.z <= 0.03f) && (m_RB.velocity.z >= 0.03f))
          ComeBackTurtle();

    }

    void OnMouseDown()
    {
       

        m_ScreenPoint = Camera.main.WorldToScreenPoint(this.transform.position);

    }

    void OnMouseDrag()
    {

        var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_ScreenPoint.z);



        var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace);


        this.transform.position = curPosition;

       
        if (this.transform.position.z != -9)
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -9f);

        if (this.transform.position.x != 0)
        {
            this.transform.position = new Vector3(0f, this.transform.position.y, this.transform.position.z);
            transform.LookAt(curPosition);
        }


        m_RotationY = this.transform.rotation.eulerAngles.y;


    }

    public void ThrowThatTurtle()
    {
        if(m_IsThrown == false)
        {
            
            m_Sight.SetActive(false);
            m_RotationMemory = this.transform.rotation;
            m_RB.AddForce(new Vector3((Mathf.Sin(m_RotationY * Mathf.Deg2Rad) * 900), 0f, (Mathf.Cos(m_RotationY * Mathf.Deg2Rad) * 900)));
            m_IsThrown = true;
        }
        
    }

    public void ComeBackTurtle()
    {
        
        m_IsThrown = false;
        this.transform.position = new Vector3(0f, -24.9f, -9f);
        this.transform.rotation = m_RotationMemory;
        m_RB.velocity =new Vector3 (0f,0f,0f) ;
        m_RB.angularVelocity = new Vector3(0f, 0f, 0f);

        m_Sight.SetActive(true);


    }

    public void Location()
    {
        switch (m_ScriptTurtleCurlingManager.m_LevelDesign)
        {
            case 0:
                this.transform.position = new Vector3(0f, -24.9f, -8.5f);
                this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                break;

            case 1:
                this.transform.position = new Vector3(0f, -24.9f, -8.5f);
                this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                break;

        }

    }

   

    public void DisplaySpeed ()
    {
        Debug.Log(m_RB.velocity);

    }

   
}


