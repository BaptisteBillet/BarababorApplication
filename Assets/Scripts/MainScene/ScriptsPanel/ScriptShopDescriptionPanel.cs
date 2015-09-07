using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptShopDescriptionPanel : MonoBehaviour
{

    ScriptBuyableItems m_ScriptBuyableItems;

    public Text m_DescriptionField;

    public Button m_BackButton;

    public Image m_ItemIcon;


    public void Activation(GameObject SelectedItem)
    {
        this.gameObject.SetActive(true);

        m_ScriptBuyableItems = SelectedItem.GetComponent<ScriptBuyableItems>();

        m_DescriptionField.text = m_ScriptBuyableItems.m_Description;

       

    }
	
    public void Desable ()
    {
        this.gameObject.SetActive(false);

    }
}
