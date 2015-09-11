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
        if (posx<308.3512f )
        { posx += 5f; }
        
    }

    public void Empty()
    {
        if (posx>0f)
        posx -= 5f;
    }
	
	
}
