using UnityEngine;
using System.Collections;

public class ScriptTurtleWalls : MonoBehaviour {

    public int m_WallNumber;

    public ScriptTurtleCurlingManager m_ScriptTurtleCurlingManager;

    Quaternion m_Rotation;

    

	// Use this for initialization
	void Start ()
    {
        this.transform.eulerAngles = new Vector3(0f, 0f, 0f);

        Location();
    
	}
	
	public void Location ()
    {
        switch (m_ScriptTurtleCurlingManager.m_LevelDesign)
        {
            case 0:
                switch (m_WallNumber)
                {
                    case 1:
                        this.transform.position = new Vector3(-4.24f, -19.5f, -1.82f);
                        this.transform.Rotate (new Vector3(0f, 308.7244f, 0f));
                        this.transform.localScale = new Vector3(8.5f, 1f, 1f);
                       
                        break;

                    case 2:
                        this.transform.position = new Vector3(5f, -19.5f, -4.9f);
                        this.transform.Rotate(new Vector3(0f, 49.90802f, 0f));
                        this.transform.localScale = new Vector3(1f, 1f, 6f);
                        break;

                    case 3:
                        this.transform.position = new Vector3(5.75f, -19.5f, 3.73f);
                        this.transform.Rotate(new Vector3(0f, 149.5583f, 0f));
                        this.transform.localScale = new Vector3(1f, 1f, 7f);
                        break;

                    case 4:
                        this.gameObject.SetActive(false);
                        break;

                    case 5:
                        this.gameObject.SetActive(false);
                        break;

                    case 6:
                        this.gameObject.SetActive(false);
                        break;
                }
                break;

            case 1:
                switch (m_WallNumber)
                {
                    case 1:
                        this.transform.position = new Vector3(4.65f, -19.5f, -1.28f);
                        this.transform.Rotate(new Vector3(0f, 0f, 0f));
                        this.transform.localScale = new Vector3(4f, 1f, 1f);

                        break;

                    case 2:
                        this.transform.position = new Vector3(5.6f, -19.5f, -6.36f);
                        this.transform.Rotate(new Vector3(0f, 47.79938f, 0f));
                        this.transform.localScale = new Vector3(1f, 1f, 4f);
                        break;

                    case 3:
                        this.transform.position = new Vector3(-4.33f, -19.5f, -4.54f);
                        this.transform.Rotate(new Vector3(0f, 328.0602f, 0f));
                        this.transform.localScale = new Vector3(1f, 1f, 10f);
                        break;

                    case 4:
                        this.transform.position = new Vector3(-5.25f, -19.5f, 7.03f);
                        this.transform.Rotate(new Vector3(0f, 44.02f, 0f));
                        this.transform.localScale = new Vector3(1f, 1f, 5f);
                        break;

                    case 5:
                        this.transform.position = new Vector3(5.88f, -19.5f, 7.28f);
                        this.transform.Rotate(new Vector3(0f, 315.1f, 0f));
                        this.transform.localScale = new Vector3(1f, 1f, 3f);
                        break;

                    case 6:
                        this.transform.position = new Vector3(2.23f, -19.5f, 0.23f);
                        this.transform.Rotate(new Vector3(0f, 0f, 0f));
                        this.transform.localScale = new Vector3(1f, 1f, 4f);
                        break;
                }
                break;
        }
    }
}
