using UnityEngine;
using System.Collections;

public class ScriptDefeatPanel : MonoBehaviour {

	public void Retry()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
	
	public void BackHomeMenu ()
    {
        Application.LoadLevel("GeneralInterfaceScene");
    }
}
