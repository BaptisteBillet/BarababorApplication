using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptEndgamePanel : MonoBehaviour
{
    public string m_Type;

    public Text m_YouTook;

    int m_VictoryMinuteTime;
    int m_VictorySecondTime;
    public ScriptTurtleTimer m_ScriptTimer;

	// Use this for initialization
	void Start ()
    {
        if (m_Type == "Victory")
        {
            
            m_VictoryMinuteTime = m_ScriptTimer.m_MinuteCount;

            if (m_ScriptTimer.m_InitialTimeSeconds != 0)
                m_VictorySecondTime = -(m_ScriptTimer.m_InitialTimeSeconds - m_ScriptTimer.m_TimeSeconds);

            else
            {
                m_VictorySecondTime = 60 - m_ScriptTimer.m_TimeSeconds;
            }

            m_YouTook.text = "" + m_VictoryMinuteTime + ":" + m_VictorySecondTime;
        }
	
	}
	
	public void BacktoMenu()
    {
        Application.LoadLevel("GeneralInterfaceScene");
    }

    public void Retry()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
}
