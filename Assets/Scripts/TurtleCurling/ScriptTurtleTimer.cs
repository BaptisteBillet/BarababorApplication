using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptTurtleTimer : MonoBehaviour {

    public Text m_Timer;

    public int m_InitialTimeMinutes;
    public int m_InitialTimeSeconds;

    public int m_MinuteCount;
    bool m_FirstMinute;

    public ScriptTurtleCurlingManager m_ScriptTurtleCurlingManager;

    public GameObject m_GameInterface;


    [HideInInspector]
    public int m_TimeMinutes;
    [HideInInspector]
    public int m_TimeSeconds;

    public bool m_IsPlaying=true;
    
	void Start ()
    {
        m_FirstMinute = true;
        m_TimeMinutes = m_InitialTimeMinutes;
        m_TimeSeconds = m_InitialTimeSeconds;

        m_Timer.text = "" + m_TimeMinutes + ":" + m_TimeSeconds;
        Timer();
    }

	
	public void Timer ()
    {
        
        StartCoroutine(CoroutineTimer());
    }

    IEnumerator CoroutineTimer ()
    {
        
        while (m_TimeMinutes>=0)
        {
            if (m_IsPlaying == false)
                break;

            while (m_TimeSeconds >= 1)
            {
                if (m_IsPlaying == false)
                    break;

                yield return new WaitForSeconds(1);
                m_TimeSeconds--;

                if (m_TimeSeconds < 10)
                    {
                      
                        m_Timer.text = "" + m_TimeMinutes + ":" + "0" + m_TimeSeconds;

                        if (m_TimeMinutes==0)
                            {
                                m_Timer.color = Color.red;

                                if (m_TimeSeconds <= 0)
                                 {
                                    
                                  
                                    WinandLoose();
                                    m_ScriptTurtleCurlingManager.Loose();
                                 }


                            }
                       


                       

                    
                     }


                 if (m_TimeSeconds > 10)
                    {
                        m_Timer.text = "" + m_TimeMinutes + ":" + m_TimeSeconds;
                    }
             }

            if (m_FirstMinute==false)
            { m_MinuteCount++; }

            else
            {
                m_FirstMinute = false;
            }
            
            m_TimeMinutes--;
            m_TimeSeconds = 60;

            yield return new WaitForEndOfFrame();
        }

        
        
        
    }

    public void WinandLoose()
    {
        m_IsPlaying=false;
        m_GameInterface.SetActive(false);
    }
}
