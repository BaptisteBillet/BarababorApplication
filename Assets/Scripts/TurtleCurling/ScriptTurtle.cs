using UnityEngine;
using System.Collections;

public class ScriptTurtle : MonoBehaviour {

    Vector3 m_ScreenPoint;

    Rigidbody m_RB;


    Quaternion m_RotationMemory;

    float m_RotationY;


    // Use this for initialization
    void Start()
    {
        m_RB = this.GetComponent<Rigidbody>();


     
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
        m_RotationMemory = this.transform.rotation;
        m_RB.AddForce(new Vector3((Mathf.Sin(m_RotationY * Mathf.Deg2Rad)*900), 0f, (Mathf.Cos(m_RotationY * Mathf.Deg2Rad)*900)));
       
    }

    public void ComeBackTurtle()
    {
        this.transform.position = new Vector3(0f, -19.9f, -9f);
        this.transform.rotation = m_RotationMemory;
        m_RB.velocity =new Vector3 (0f,0f,0f) ;
        m_RB.angularVelocity = new Vector3(0f, 0f, 0f);


    }
}


