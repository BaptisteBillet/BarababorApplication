using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptTimer : MonoBehaviour {

    public Text m_Timer;

    public int m_InitialTimeMinutes;
    public int m_InitialTimeSeconds;

    [HideInInspector]
    public int m_TimeMinutes;
    [HideInInspector]
    public int m_TimeSeconds;

    public bool m_IsPlaying=true;
    
	void Start ()
    {
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

                if (m_TimeSeconds < 10)
                    {
                        if (m_TimeMinutes==0)
                        { m_Timer.color = Color.red; }
                       


                        m_Timer.text = "" + m_TimeMinutes + ":" + "0" + m_TimeSeconds;
                    }
                    yield return new WaitForSeconds(1);
                    m_TimeSeconds--;
                    m_Timer.text = "" + m_TimeMinutes + ":" + m_TimeSeconds;
             }



            m_TimeMinutes--;
            m_TimeSeconds = 60;

            yield return new WaitForEndOfFrame();
        }
        
        
    }

    public void WinandLoose()
    {
        StopCoroutine(CoroutineTimer());
    }
}
