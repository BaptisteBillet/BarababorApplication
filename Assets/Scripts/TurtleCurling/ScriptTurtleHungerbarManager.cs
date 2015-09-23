using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptTurtleHungerbarManager : MonoBehaviour
{
    RectTransform HungerBartoFill;

    Rect HungerBartoFillRect;

 
    RectTransform m_RectTransform;

    public ScriptTurtleCurlingManager m_ScriptTurtleCurlingManager;

    int m_FillingCount;


	// Use this for initialization
	void Start ()
    {
        m_FillingCount = 0;

        m_RectTransform = this.GetComponent<RectTransform>();

        HungerBartoFill = this.GetComponentInParent<RectTransform>();

        HungerBartoFillRect = HungerBartoFill.rect;

        
	
	}
	
	public void Fill()
    {
        if (m_RectTransform.position.x < 156)
        {
            m_RectTransform.position += new Vector3((HungerBartoFillRect.width / 4), 0f, 0f);
            m_FillingCount++;
            if (m_FillingCount == 4)
            {
                m_ScriptTurtleCurlingManager.Win();
            }
            
        }
    }
}
