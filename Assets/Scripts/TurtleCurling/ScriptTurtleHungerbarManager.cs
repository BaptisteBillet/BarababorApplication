using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptTurtleHungerbarManager : MonoBehaviour
{
    RectTransform HungerBartoFill;

    Rect HungerBartoFillRect;

 
    RectTransform m_RectTransform;


	// Use this for initialization
	void Start ()
    {
        m_RectTransform = this.GetComponent<RectTransform>();

        HungerBartoFill = this.GetComponentInParent<RectTransform>();

        HungerBartoFillRect = HungerBartoFill.rect;

        
	
	}
	
	public void Fill()
    {
        if (m_RectTransform.position.x < HungerBartoFillRect.width)
        {
            m_RectTransform.position += new Vector3((HungerBartoFillRect.width / 4), 0f, 0f);
        }
    }
}
