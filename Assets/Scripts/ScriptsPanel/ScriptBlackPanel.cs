using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScriptBlackPanel : MonoBehaviour {

    public Button m_DisableButton;

    public void Disable ()
    {
        this.enabled = false;
        m_DisableButton.enabled = false;
    }
}
