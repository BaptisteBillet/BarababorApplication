using UnityEngine;
using System.Collections;

public class ScriptShopDescriptionPanel : MonoBehaviour
{

    ScriptBuyableItems m_ScriptBuyableItems;

    public void Activation(GameObject SelectedItem)
    {
        this.gameObject.SetActive(true);

        m_ScriptBuyableItems = SelectedItem.GetComponent<ScriptBuyableItems>();

    }
	
}
