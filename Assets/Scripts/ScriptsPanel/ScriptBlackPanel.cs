using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScriptBlackPanel : MonoBehaviour {

    public Button m_DisableButton;

    public GameObject m_EquipButton;
    public GameObject m_EquipButton1;
    public GameObject m_EquipButton2;
    public GameObject m_EquipButton3;
    public GameObject m_EquipButton4;
    public GameObject m_ShopButton;
    public GameObject m_BackButton;
    public GameObject m_ElementButton;

    public GameObject m_BoathousePanel;
    ScriptBoathouseManager m_ScriptBoathouseManager;


    GameObject m_Ship;

    void Start ()
    {
        m_ScriptBoathouseManager = m_BoathousePanel.GetComponent<ScriptBoathouseManager>();

        m_Ship = m_ScriptBoathouseManager.m_SelectedShip;

    }
    public void Disable ()
    {
        if (m_ScriptBoathouseManager.m_MultiStorageEnabled == false)
        {
            m_EquipButton.SetActive(true);
        }

        else if (m_ScriptBoathouseManager.m_MultiStorageEnabled == true)
        {
            m_EquipButton1.SetActive(true);
            m_EquipButton2.SetActive(true);
            m_EquipButton3.SetActive(true);
            m_EquipButton4.SetActive(true);
        }

        m_ShopButton.SetActive(true);
        m_BackButton.SetActive(true);
        m_ElementButton.SetActive(true);
              m_Ship.SetActive(true);

        this.gameObject.SetActive(false);
        m_DisableButton.enabled = false;

    }
}
