using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScriptThirstMeter : MonoBehaviour {

    public Image m_MeterFilling;
    RectTransform m_Rect;

    public RectTransform m_AreatoFill;
    Rect m_AreatoFillRect;

    


    // Use this for initialization
    void Start () {
        m_Rect = m_MeterFilling.GetComponent<RectTransform>();

        m_AreatoFillRect = m_AreatoFill.rect;

    }

   public void Fill ()
    {
                
        if (m_MeterFilling.rectTransform.position.x<270f )
         m_MeterFilling.rectTransform.position += new Vector3 (m_AreatoFillRect.width/10,0f,0f); 
        
    }

    public void Empty()
    {
        
        if (m_MeterFilling.rectTransform.position.x <= -150f)
        {
            m_MeterFilling.rectTransform.position = new Vector3(-151f, m_MeterFilling.rectTransform.position.y, m_MeterFilling.rectTransform.position.z);
        }

        else
        {
            m_MeterFilling.rectTransform.position -= new Vector3(m_AreatoFillRect.width / 10, 0f, 0f);
        }
        

        
    }


}
