using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptDrugsUIPanel : MonoBehaviour
{
    public Image m_HealthMeterFilling;
    RectTransform m_Rect;
    RectTransform m_ParentRect;
    int m_HitCount;

    public GameObject m_VictoryPanel;
    public Text m_YouTook;

    public GameObject m_DefeatPanel;

    public Text m_PillsNumber;

    public int m_InitialNumberofPills;
    int m_NumberofPills;

    public ScriptHand m_ScriptHand;
	
	void Start ()
    {
        m_Rect = m_HealthMeterFilling.GetComponent<RectTransform>();
        m_ParentRect = m_HealthMeterFilling.GetComponentInParent<RectTransform>();

        m_NumberofPills = m_InitialNumberofPills;

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
                m_ScriptHand.m_IsPlaying = false;
                m_VictoryPanel.SetActive(true);
                m_YouTook.text = "" + (m_InitialNumberofPills - m_NumberofPills)+ " " +"Tirs";
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

        if (m_NumberofPills==0)
        {
            m_ScriptHand.m_IsPlaying = false;
            m_DefeatPanel.SetActive(true);
        }
    }
	
}
