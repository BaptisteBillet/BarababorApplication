using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptGrade : MonoBehaviour {

	//Visible Elements
	public GameObject m_Grade;
	public Text m_GradeNumber;
	public Text m_GradeName;
	
	//________________________________________________________________________________
	
	//Definition Members
	
	public int m_NumberOfGrade;
	public string m_NameOfGrade;
	public bool m_IsEnabled;
	
	
	
	void Start () 
	{
		
		m_Grade.SetActive (m_IsEnabled);
		m_GradeName.text = m_NameOfGrade;
		m_GradeNumber.text = "" + m_NumberOfGrade;
		
	}
	

}
