using UnityEngine;
using System.Collections;

public class ScriptTurtleWalls : MonoBehaviour {

    public int m_WallNumber;

    public ScriptTurtleCurlingManager m_ScriptTurtleCurlingManager;

    Quaternion m_Rotation;

    public GameObject[] m_ArrayofWalls;

    

	// Use this for initialization
	void Start ()
    {
        Initialize();

        Location();
    
	}
	
	public void Location ()
    {
        switch (m_ScriptTurtleCurlingManager.m_LevelDesign)
        {
            case 0:
                

                Initialize();

                m_ArrayofWalls[0].transform.position = new Vector3(-4.24f, -24.5f, -1.82f);
                m_ArrayofWalls[0].transform.Rotate (new Vector3(0f, 308.7244f, 0f));
                m_ArrayofWalls[0].transform.localScale = new Vector3(8.5f, 1f, 1f);

                m_ArrayofWalls[1].transform.position = new Vector3(5f, -24.5f, -4.9f);
                m_ArrayofWalls[1].transform.Rotate(new Vector3(0f, 49.90802f, 0f));
                m_ArrayofWalls[1].transform.localScale = new Vector3(1f, 1f, 6f);

                m_ArrayofWalls[2].transform.position = new Vector3(5.75f, -24.5f, 3.73f);
                m_ArrayofWalls[2].transform.Rotate(new Vector3(0f, 149.5583f, 0f));
                m_ArrayofWalls[2].transform.localScale = new Vector3(1f, 1f, 7f);

                m_ArrayofWalls[3].gameObject.SetActive(false);

                m_ArrayofWalls[4].gameObject.SetActive(false);

                m_ArrayofWalls[5].gameObject.SetActive(false);
                      
                
                break;

            case 1:

            

                Initialize();

                m_ArrayofWalls[0].transform.position = new Vector3(4.65f, -24.5f, -1.28f);
                          m_ArrayofWalls[0].transform.Rotate(new Vector3(0f, 0f, 0f));
                          m_ArrayofWalls[0].transform.localScale = new Vector3(4f, 1f, 1f);

                          m_ArrayofWalls[1].transform.position = new Vector3(5.6f, -24.5f, -6.36f);
                          m_ArrayofWalls[1].transform.Rotate(new Vector3(0f, 47.79938f, 0f));
                          m_ArrayofWalls[1].transform.localScale = new Vector3(1f, 1f, 4f);

                          m_ArrayofWalls[2].transform.position = new Vector3(-5.07f, -24.5f, -3.36f);
                          m_ArrayofWalls[2].transform.Rotate(new Vector3(0f, 328.0602f, 0f));
                          m_ArrayofWalls[2].transform.localScale = new Vector3(1f, 1f, 8f);  
                                    
                          m_ArrayofWalls[3].gameObject.SetActive(true);
                          m_ArrayofWalls[3].transform.position = new Vector3(-5.45f, -24.5f, 6.82f);
                          m_ArrayofWalls[3].transform.Rotate(new Vector3(0f, 44.02f, 0f));
                          m_ArrayofWalls[3].transform.localScale = new Vector3(1f, 1f, 5f);
                                      
                          m_ArrayofWalls[4].gameObject.SetActive(true);
                          m_ArrayofWalls[4].transform.position = new Vector3(5.88f, -24.5f, 7.28f);
                          m_ArrayofWalls[4].transform.Rotate(new Vector3(0f, 315.1f, 0f));
                          m_ArrayofWalls[4].transform.localScale = new Vector3(1f, 1f, 3f);
                                      
                          m_ArrayofWalls[5].gameObject.SetActive(true);
                          m_ArrayofWalls[5].transform.position = new Vector3(2.23f, -24.5f, 0.23f);
                          m_ArrayofWalls[5].transform.Rotate(new Vector3(0f, 0f, 0f));
                          m_ArrayofWalls[5].transform.localScale = new Vector3(1f, 1f, 4f);
                      
                break;

            case 2:

              

                Initialize();

                m_ArrayofWalls[0].transform.position = new Vector3(-2.09f, -24.5f, -3.22f);
                          m_ArrayofWalls[0].transform.Rotate(new Vector3(0f, 328.2676f, 0f));
                          m_ArrayofWalls[0].transform.localScale = new Vector3(3f, 1f, 1f);
                     
                          m_ArrayofWalls[1].transform.position = new Vector3(3.35f, -24.5f, 3.15f);
                          m_ArrayofWalls[1].transform.Rotate(new Vector3(0f, 0f, 0f));
                          m_ArrayofWalls[1].transform.localScale = new Vector3(1f, 1f, 4f);
                  
                          m_ArrayofWalls[2].transform.position = new Vector3(-5.05f, -24.5f, -3.95f);
                          m_ArrayofWalls[2].transform.Rotate(new Vector3(0f, 90f, 0f));
                          m_ArrayofWalls[2].transform.localScale = new Vector3(1f, 1f, 4f);
                  
                          m_ArrayofWalls[3].gameObject.SetActive(true);
                          m_ArrayofWalls[3].transform.position = new Vector3(2.74f, -24.5f, 5.53f);
                          m_ArrayofWalls[3].transform.Rotate(new Vector3(0f, 90f, 0f));
                          m_ArrayofWalls[3].transform.localScale = new Vector3(1f, 1f, 8f);
                        
                          m_ArrayofWalls[4].gameObject.SetActive(true);
                          m_ArrayofWalls[4].transform.position = new Vector3(4.9f, -24.5f, -8.87f);
                          m_ArrayofWalls[4].transform.Rotate(new Vector3(0f, 270f, 0f));
                          m_ArrayofWalls[4].transform.localScale = new Vector3(1f, 1f, 4f);
                         
                          m_ArrayofWalls[5].gameObject.SetActive(false);
                       
                
                break;
        }

        
    }

    public void Initialize ()
    {
        foreach (GameObject GO in m_ArrayofWalls)
        {
            GO.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }

  
    
}
