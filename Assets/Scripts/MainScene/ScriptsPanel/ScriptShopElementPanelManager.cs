using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScriptShopElementPanelManager : MonoBehaviour {

    public GameObject m_Ship;
    ScriptShip m_ScriptShip;

    ScriptBuyableItems m_ScriptBuyableItem;

    public Text m_SpeedField;
    public Text m_DamageField;
    public Text m_CapacityField;
    public Text m_HealthPointField;
    public Text m_VisionField;
    public Text m_RegenerationField;

    public Text m_CostField;

    public ScriptInventory m_ScriptInventory;

    public ScriptGeneralManager m_ScriptGeneralManager;
	// Use this for initialization
	void Start ()
    {
       // m_ScriptShip = m_Ship.GetComponent<ScriptShip>();
	}
	
	public void DisplayInfos(GameObject SelectedItem)
    {
        m_ScriptBuyableItem = SelectedItem.GetComponent<ScriptBuyableItems>();

        
            m_SpeedField.text = "" + m_ScriptBuyableItem.m_ArrayofCharacteristics[0] + "/" + m_ScriptBuyableItem.m_ArrayofCharacteristics[1];
            m_DamageField.text = "" + m_ScriptBuyableItem.m_ArrayofCharacteristics[2] + "/" + m_ScriptBuyableItem.m_ArrayofCharacteristics[3];
            m_CapacityField.text = "" + m_ScriptBuyableItem.m_ArrayofCharacteristics[4] + "/" + m_ScriptBuyableItem.m_ArrayofCharacteristics[5];
            m_HealthPointField.text = "" + m_ScriptBuyableItem.m_ArrayofCharacteristics[6] + "/" + m_ScriptBuyableItem.m_ArrayofCharacteristics[7];
            m_VisionField.text = "" + m_ScriptBuyableItem.m_ArrayofCharacteristics[8] + "/" + m_ScriptBuyableItem.m_ArrayofCharacteristics[9];
            m_RegenerationField.text = "" + m_ScriptBuyableItem.m_ArrayofCharacteristics[10] + "/" + m_ScriptBuyableItem.m_ArrayofCharacteristics[11];

            m_CostField.text = "" + m_ScriptBuyableItem.m_Cost;
        

    }

    public void Buy()
    {

        switch (m_ScriptBuyableItem.m_ItemType)
        {
            case "Bow":
                m_ScriptInventory.m_PossessedSpecialistInventory.Add(m_ScriptBuyableItem.m_ItemName);
                m_ScriptInventory.SaveInventory(m_ScriptInventory.m_PossessedBowInventory, "BowInventory");
                break;

            case "Stern":
                m_ScriptInventory.m_PossessedWeaponInventory.Add(m_ScriptBuyableItem.m_ItemName);
                m_ScriptInventory.SaveInventory(m_ScriptInventory.m_PossessedSternInventory, "SternInventory");
                break;

            case "Keel":
                m_ScriptInventory.m_PossessedGadgetInventory.Add(m_ScriptBuyableItem.m_ItemName);
                m_ScriptInventory.SaveInventory(m_ScriptInventory.m_PossessedKeelInventory, "KeelInventory");
                break;

            case "Mast":
                m_ScriptInventory.m_PossessedUltimateInventory.Add(m_ScriptBuyableItem.m_ItemName);
                m_ScriptInventory.SaveInventory(m_ScriptInventory.m_PossessedMastInventory, "MastInventory");
                break;
        }

        m_ScriptGeneralManager.m_Coins -= m_ScriptBuyableItem.m_Cost;



    }
}
