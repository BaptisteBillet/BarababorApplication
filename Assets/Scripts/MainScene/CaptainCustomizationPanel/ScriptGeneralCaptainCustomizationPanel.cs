using UnityEngine;
using System.Collections;

public class ScriptGeneralCaptainCustomizationPanel : MonoBehaviour {

    public GameObject Captain;


	// Use this for initialization
	void Start ()
    {
        Captain.SetActive(true);
        Captain.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Captain.transform.position = new Vector3(0f, 0.1f, 2.5f);

    }
	
	
}
