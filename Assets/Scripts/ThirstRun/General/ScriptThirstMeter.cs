using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScriptThirstMeter : MonoBehaviour {

    public Image m_MeterFilling;
    RectTransform m_Rect;

    float posx;
    
        
	// Use this for initialization
	void Start () {
        m_Rect = m_MeterFilling.GetComponent<RectTransform>();

        posx = m_Rect.position.x;
	
	}

   public void Fill ()
    {
        
        //if (m_MeterFilling.rectTransform.position.x<308.3512f )
         m_MeterFilling.rectTransform.position = new Vector3 (120f,0f,0f); 
        
    }

    public void Empty()
    {
        Debug.Log("OY2");
        if (posx>0f)
        posx -= 5f;
    }
	
	
}
