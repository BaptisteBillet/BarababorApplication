using UnityEngine;
using System.Collections;

public class ScriptCaptain : MonoBehaviour {

    public ScriptThirstRunManager m_ScriptThirstRunManager;

    Vector3 m_ScreenPoint;
    Vector3 m_Offset;

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Coconut")
        {

            m_ScriptThirstRunManager.CoconutCount(true);
          
        }


        if (other.tag== "BowlingBall")
        {
            m_ScriptThirstRunManager.CoconutCount(false);
        } 
        
    }

    void OnMouseDown()
    {
        m_ScreenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        //m_Offset = this.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_ScreenPoint.z));

    }

    void OnMouseDrag()
    {
        //keep track of the mouse position
        var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_ScreenPoint.z);

        //convert the screen mouse position to world point and adjust with offset
        var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace);

        //update the position of the object in the world
        this.transform.position = curPosition;

        if (this.transform.position.y != 3.34f)
            this.transform.position = new Vector3(this.transform.position.x, -3.34f, this.transform.position.z);


        if (this.transform.position.x < -1.5f)
            this.transform.position = new Vector3(-2.85f, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.x > -1.5f && this.transform.position.x < 1.5f)
            this.transform.position = new Vector3(0f, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.x > 1.5f)
            this.transform.position = new Vector3(2.85f, this.transform.position.y, this.transform.position.z);
    }
}
