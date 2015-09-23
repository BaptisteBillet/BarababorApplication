using UnityEngine;
using System.Collections;

public class ScriptTurtleCurlingManager : MonoBehaviour
{
    public GameObject m_WinPanel;

    public GameObject m_DefeatPanel;

    public ScriptTurtleTimer m_ScriptTurtleTimer;

    

    public int m_LevelDesign;

    int m_PreviousLevelDesign;

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

    public void Loose()
    {
        m_ScriptTurtleTimer.WinandLoose();
        m_DefeatPanel.SetActive(true);
    }

    public void LevelDesignSelection()
    {
    
        m_LevelDesign = Mathf.FloorToInt(Random.Range(0.0f, 2.9f));

        while (m_LevelDesign==m_PreviousLevelDesign)
        {
            m_LevelDesign = Mathf.FloorToInt(Random.Range(0.0f, 2.9f));
        }

      
            m_PreviousLevelDesign = m_LevelDesign;
        

        Debug.Log(m_PreviousLevelDesign);
    }
   
}
