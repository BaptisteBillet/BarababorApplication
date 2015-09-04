using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptShopEquipmentPanel : MonoBehaviour {

    public Text m_TitleCharacteristicsField1;
    public Text m_TitleCharacteristicsField2;
    public Text m_TitleCharacteristicsField3;
    public Text m_TitleCharacteristicsField4;
    public Text m_TitleCharacteristicsField5;
    public Text m_TitleCharacteristicsField6;
    public Text m_TitleCharacteristicsField7;

    public Text m_CharacteristicField1;
    public Text m_CharacteristicField2;
    public Text m_CharacteristicField3;
    public Text m_CharacteristicField4;
    public Text m_CharacteristicField5;
    public Text m_CharacteristicField6;
    public Text m_CharacteristicField7;

    public Text m_CostField;

    ScriptBuyableItems m_ScriptBuyableItems;

    // Use this for initialization
    void Start() {

    }

    public void DisplayInfo (GameObject SelectedItem)
    {
        m_ScriptBuyableItems = SelectedItem.GetComponent<ScriptBuyableItems>();

        if (m_ScriptBuyableItems.m_ItemType=="Specialist")
        {
            m_TitleCharacteristicsField1.text = "Spécialité";
            m_CharacteristicField1.text = m_ScriptBuyableItems.m_SpecialistSpeciality;

            m_TitleCharacteristicsField2.text = "Bonus";
            m_CharacteristicField2.text = ""+m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[0];

            m_TitleCharacteristicsField3.enabled = false;
            m_TitleCharacteristicsField4.enabled = false;
            m_TitleCharacteristicsField5.enabled = false;
            m_TitleCharacteristicsField6.enabled = false;
            m_TitleCharacteristicsField7.enabled = false;
            m_CharacteristicField3.enabled = false;
            m_CharacteristicField4.enabled = false;
            m_CharacteristicField5.enabled = false;
            m_CharacteristicField6.enabled = false;
            m_CharacteristicField7.enabled = false;

            m_CostField.text =""+ m_ScriptBuyableItems.m_Cost;
        }

        else
        {
            m_TitleCharacteristicsField3.enabled = true;
            m_TitleCharacteristicsField4.enabled = true;
            m_TitleCharacteristicsField5.enabled = true;
            m_TitleCharacteristicsField6.enabled = true;
            m_TitleCharacteristicsField7.enabled = true;
            m_CharacteristicField3.enabled = true;
            m_CharacteristicField4.enabled = true;
            m_CharacteristicField5.enabled = true;
            m_CharacteristicField6.enabled = true;
            m_CharacteristicField7.enabled = true;

            m_TitleCharacteristicsField1.text = "Niveau";
            m_TitleCharacteristicsField2.text = "Évolution";
            m_TitleCharacteristicsField3.text = "Domages";
            m_TitleCharacteristicsField4.text = "Portée";
            m_TitleCharacteristicsField5.text = "Rechargement";
            m_TitleCharacteristicsField6.text = "Fonctionnement";
            m_TitleCharacteristicsField7.text = "États";

            m_CharacteristicField1.text = "" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[0];
            m_CharacteristicField2.text = "" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[1];
            m_CharacteristicField3.text = "" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[2] + "/" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[3];
            m_CharacteristicField4.text = "" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[4]+ "/" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[5];
            m_CharacteristicField5.text = "" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[6]+"/" + m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[7];
            
            switch (m_ScriptBuyableItems.m_ArrayofEquipmentCharacteristics[8])
            {
                case 0:
                    m_CharacteristicField6.text = "Cône";
                    break;
                case 1:
                    m_CharacteristicField6.text = "Tir Droit";
                    break;
                case 2:
                    m_CharacteristicField6.text = "Aura";
                    break;
                case 3:
                    m_CharacteristicField6.text = "Tir Traversant";
                    break;
                case 4:
                    m_CharacteristicField6.text = "Ciblage";
                    break;
                case 5:
                    m_CharacteristicField6.text = "Zone Distante";
                    break;
                case 6:
                    m_CharacteristicField6.text = "Éperon";
                    break;
                case 7:
                    m_CharacteristicField6.text = "Autre";
                    break;
            }

            m_CharacteristicField7.text = m_ScriptBuyableItems.m_State1 + "/" + m_ScriptBuyableItems.m_State2;

            m_CostField.text = "" + m_ScriptBuyableItems.m_Cost;

        }

    }
}
