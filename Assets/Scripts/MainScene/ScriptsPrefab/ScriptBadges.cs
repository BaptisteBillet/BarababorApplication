using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScriptBadges : MonoBehaviour {

	//Visible Elements
	public GameObject m_Badge;
	public Text m_BadgeNumber;
	public Text m_BadgeName;

	//________________________________________________________________________________

	//Definition Members

	public int m_NumberOfBadge;
	public string m_NameOfBadge;
	public bool m_IsEnabled;



	void Start () 
	{

		m_Badge.SetActive (m_IsEnabled);
		m_BadgeName.text = m_NameOfBadge;
		m_BadgeNumber.text = "" + m_NumberOfBadge;
	
	}
	

}
