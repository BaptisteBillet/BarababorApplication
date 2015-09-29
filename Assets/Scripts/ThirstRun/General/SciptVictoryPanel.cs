using UnityEngine;
using System.Collections;

public class SciptVictoryPanel : MonoBehaviour {

	public void BackHomeMenu ()
    {
        Application.LoadLevel("GeneralInterfaceScene");
    }

    public void Retry()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
