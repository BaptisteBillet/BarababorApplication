using UnityEngine;
using System.Collections;

public class ScriptTurtleCurlingManager : MonoBehaviour
{
    public GameObject m_WinPanel;

    public ScriptTurtleTimer m_ScriptTurtleTimer;

    public int m_LevelDesign;

	// Use this for initialization
	void Awake ()
    {
        m_LevelDesign = 0;
	
	}
	
	public void Win()
    {
        m_ScriptTurtleTimer.WinandLoose();
        m_WinPanel.SetActive(true);
    }
}
