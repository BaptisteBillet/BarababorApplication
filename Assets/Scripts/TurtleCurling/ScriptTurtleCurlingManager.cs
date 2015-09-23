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
        LevelDesignSelection();
	
	}
	
	public void Win()
    {
        m_ScriptTurtleTimer.WinandLoose();
        m_WinPanel.SetActive(true);
    }

    public void LevelDesignSelection()
    {
        m_LevelDesign = Mathf.FloorToInt(Random.Range(0.0f, 2.9f));
    }
   
}
