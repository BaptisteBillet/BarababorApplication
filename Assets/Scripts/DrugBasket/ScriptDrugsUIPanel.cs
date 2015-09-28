using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptDrugsUIPanel : MonoBehaviour
{
    public Image m_HealthMeterFilling;
    RectTransform m_Rect;
    RectTransform m_ParentRect;
    int m_HitCount;


    public Text m_PillsNumber;

    public int m_NumberofPills;

	
	void Start ()
    {
        m_Rect = m_HealthMeterFilling.GetComponent<RectTransform>();
        m_ParentRect = m_HealthMeterFilling.GetComponentInParent<RectTransform>();

        m_PillsNumber.text = "" + m_NumberofPills;
    }
	
    public void FillHealthMeter()
    {
        if (m_Rect.localPosition.x<0f)
        {
            m_Rect.localPosition += new Vector3(m_ParentRect.rect.width / 4, 0f, 0f);
            m_HitCount++;

           
            if (m_HitCount==4)
            {
                Debug.Log("Gagné"); 
            }
        }
       

    }

    public void PillsCounter()
    {
        if (m_NumberofPills>0)
        m_NumberofPills--;

        if (m_NumberofPills<=3)
        {
            m_PillsNumber.color = Color.red;
        }
        m_PillsNumber.text = "" + m_NumberofPills;
    }
	
}
