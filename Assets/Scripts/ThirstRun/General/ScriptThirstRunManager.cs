using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptThirstRunManager : MonoBehaviour {

    public GameObject m_Launcher1;
    public GameObject m_Launcher2;
    public GameObject m_Launcher3;

    ScriptLauncher m_ScriptLauncher1;
    ScriptLauncher m_ScriptLauncher2;
    ScriptLauncher m_ScriptLauncher3;


    public ScriptTimer m_ScriptTimer;
    public Text m_VictoryTimerField;
    public GameObject m_PanelVictory;

    int m_VictoryMinuteTime;
    int m_VictorySecondTime;


    float m_LaunchTime;

    int m_SelectLauncher;
    int m_ObjectToLaunch;

    int m_Coconut;

    public ScriptThirstMeter m_ScriptThirstManager;
     

    // Use this for initialization
    void Start ()
    {
        m_ScriptLauncher1 = m_Launcher1.GetComponent<ScriptLauncher>();
        m_ScriptLauncher2 = m_Launcher2.GetComponent<ScriptLauncher>();
        m_ScriptLauncher3 = m_Launcher3.GetComponent<ScriptLauncher>();

        PrepareforLaunch();

    }
	
	public void PrepareforLaunch ()
    {
        if (m_ScriptTimer.m_IsPlaying)            
        StartCoroutine(C_PrepareforLaunch());
    }

    IEnumerator C_PrepareforLaunch ()
    {
       
            m_LaunchTime = Random.Range(1f, 2f);
            m_SelectLauncher = Mathf.CeilToInt(Random.Range(0.1f, 2.9f));
            m_ObjectToLaunch = Mathf.FloorToInt(Random.Range(0.1f, 0.9f));
            yield return new WaitForSeconds(m_LaunchTime);
            
            switch (m_SelectLauncher)
            {
                case 1:
                m_ScriptLauncher1.Launch(m_ObjectToLaunch);
                break;

            case 2:
                m_ScriptLauncher2.Launch(m_ObjectToLaunch);
                break;

            case 3:
                m_ScriptLauncher3.Launch(m_ObjectToLaunch);
                break;
            }

             
    }

    //________________________________________________________________________________________________________________

    public void CoconutCount(bool Coconut)
    {
        if (Coconut == true)
        {
            m_Coconut++;
            m_ScriptThirstManager.Fill();
        }


        if (Coconut == false)
        { 
            m_Coconut--;
            m_ScriptThirstManager.Empty();
        }

        if (m_Coconut == 10)
            Win();

    }

    //________________________________________________________________________________________________________________

   

    public void Win ()
    {
        m_ScriptTimer.WinandLoose();

        StopCoroutine(C_PrepareforLaunch());
        m_PanelVictory.SetActive(true);

        m_VictoryMinuteTime = m_ScriptTimer.m_InitialTimeMinutes - m_ScriptTimer.m_TimeMinutes;

        if (m_ScriptTimer.m_InitialTimeSeconds!=0)
        m_VictorySecondTime = -(m_ScriptTimer.m_InitialTimeSeconds - m_ScriptTimer.m_TimeSeconds);

        else
        {
            m_VictorySecondTime = 60- m_ScriptTimer.m_TimeSeconds;
        }

        m_VictoryTimerField.text = "" + m_VictoryMinuteTime + ":" + m_VictorySecondTime;
    }

    public void Loose ()
    {

    }

    //______________________________________________________________________________________________________________________
}
