using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScriptBuyableCaptainItems : MonoBehaviour {

    [HideInInspector]
    public string m_ItemsName;

    [HideInInspector]
    public int m_ItemsCost;

    [HideInInspector]
    public Mesh m_ItemsAppearance;

    [HideInInspector]
    public string m_ItemsShownName;

    //Members Given by the ScriptDisplayStand

    [HideInInspector]
    public Text m_CostField;

    [HideInInspector]
    public string m_ItemsType;

    [HideInInspector]
    public Image m_ItemsIcon;

    [HideInInspector]
    public ScriptMeshLibrary m_ScriptMeshLibrary;

    public Text m_ShownNameField;

    



	void Start ()
    {
       switch (m_ItemsType)
        {
            case "Nose":
                CharacteristicsCollect(TriDataBase.instance.m_NoseDico);
                break;

            case "Ears":
                CharacteristicsCollect(TriDataBase.instance.m_EarsDico);
                break;

            case "Eyes":
                CharacteristicsCollect(TriDataBase.instance.m_EyesDico);
                break;

            case "Mouth":
                CharacteristicsCollect(TriDataBase.instance.m_MouthDico);
                break;

            case "Jacket":
                CharacteristicsCollectWears(TriDataBase.instance.m_JacketDico);
                break;

            case "Pants":
                CharacteristicsCollectWears(TriDataBase.instance.m_PantsDico);
                break;

            case "Boots":
                CharacteristicsCollectWears(TriDataBase.instance.m_BootsDico);
                break;

            case "Hat":
                CharacteristicsCollectWears(TriDataBase.instance.m_HatDico);
                break;

        }

        m_ShownNameField.text = m_ItemsShownName;

	
	}
	
    public void CharacteristicsCollect (Dictionary<string,ScriptCaptainParts> dico)
    {
        m_ItemsCost = dico[m_ItemsName].m_PartsCost;
        m_ItemsAppearance = dico[m_ItemsName].m_PartsAppearance;
        m_ItemsShownName = dico[m_ItemsName].m_PartsShownName;


    }

    public void CharacteristicsCollectWears(Dictionary<string, ScriptCaptainWears> dico)
    {
        m_ItemsCost = dico[m_ItemsName].m_WearCost;
        m_ItemsAppearance = dico[m_ItemsName].m_WearAppearance;
        m_ItemsShownName = dico[m_ItemsName].m_WearShownName;


    }

    public void CostDisplay()
    {
        m_CostField.text = "" + m_ItemsCost;
    }

}
