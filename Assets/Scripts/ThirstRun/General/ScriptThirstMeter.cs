using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScriptThirstMeter : MonoBehaviour {

    public Image m_MeterFilling;
    RectTransform m_Rect;

   
    
        
	// Use this for initialization
	void Start () {
        m_Rect = m_MeterFilling.GetComponent<RectTransform>();

        
	
	}

   public void Fill ()
    {
        
        if (m_MeterFilling.rectTransform.position.x<460f )
         m_MeterFilling.rectTransform.position += new Vector3 (46f,0f,0f); 
        
    }

    public void Empty()
    {
        Debug.Log("OY2");
       
        m_MeterFilling.rectTransform.position -= new Vector3(46f, 0f, 0f);

        if (m_MeterFilling.rectTransform.position.x<0f)
        {
            m_MeterFilling.rectTransform.position = new Vector3(-151f, m_MeterFilling.rectTransform.position.y, m_MeterFilling.rectTransform.position.z) ;
        }
    }


}
