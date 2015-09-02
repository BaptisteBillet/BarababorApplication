using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptBadgePanelManager : MonoBehaviour {

	// Bool to Enable Badges
	public bool m_Badge1;
//________________________________________________________________________________________________

	//Badges' Images 

	public Image m_ImageBadge1; 

	public Text m_Badge1Number;
	// Use this for initialization
	void Start () 
	{

		m_ImageBadge1.enabled = m_Badge1;
	
	}
	

}
