using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptGeneralCaptainInfosManager : MonoBehaviour 
{
	//____________________________________________________________________________

	//Panel to use 

	public GameObject m_GeneralInfosPanel;
	public GameObject m_CurrentPanel;

	public GameObject m_InfosPanel;
	public GameObject m_MainPanel;

	//____________________________________________________________________________

	public GameObject m_GeneralManager;

	//____________________________________________________________________________




	// Use this for initialization
	void Start () 
	{
		m_GeneralInfosPanel.SetActive (true);
		m_CurrentPanel = m_GeneralInfosPanel;
	
	}
	
	public void ChangePanel (GameObject PanelToLoad)
	{
		m_CurrentPanel.SetActive (false);
		PanelToLoad.SetActive (true);
		m_CurrentPanel = PanelToLoad;

	}

	public void Back ()
	{
		m_InfosPanel.SetActive (false);
		m_MainPanel.SetActive (true);
		m_GeneralManager.GetComponent<ScriptGeneralManager> ().HungerMeter ();  

	}


}
