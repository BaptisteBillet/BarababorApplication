using UnityEngine;
using System.Collections;

public class ScriptThirstRunManager : MonoBehaviour {

    public GameObject m_Launcher1;
    public GameObject m_Launcher2;
    public GameObject m_Launcher3;

    ScriptLauncher m_ScriptLauncher1;
    ScriptLauncher m_ScriptLauncher2;
    ScriptLauncher m_ScriptLauncher3;


    float m_LaunchTime;

    int m_SelectLauncher;
    int m_ObjectToLaunch;
     

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
        StartCoroutine(C_PrepareforLaunch());
    }

    IEnumerator C_PrepareforLaunch ()
    {
       
            m_LaunchTime = Random.Range(1f, 2f);
            m_SelectLauncher = Mathf.CeilToInt(Random.Range(0.1f, 2.9f));
            m_ObjectToLaunch = Mathf.FloorToInt(Random.Range(0.1f, 1.9f));
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
}
