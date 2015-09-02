using UnityEngine;
using System.Collections;

public class ScriptSplashScreenManager : MonoBehaviour {

	public void LoadNextScene()
    {
        Application.LoadLevel("GeneralInterfaceScene");
    }
}
