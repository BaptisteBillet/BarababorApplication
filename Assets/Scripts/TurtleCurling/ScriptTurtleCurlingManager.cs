using UnityEngine;
using System.Collections;

public class ScriptTurtleCurlingManager : MonoBehaviour
{
    public GameObject m_WinPanel;

    public ScriptTurtleTimer m_ScriptTurtleTimer;

	// Use this for initialization
	void Start () {
	
	}
	
	public void Win()
    {
        m_ScriptTurtleTimer.WinandLoose();
        m_WinPanel.SetActive(true);
    }
}
