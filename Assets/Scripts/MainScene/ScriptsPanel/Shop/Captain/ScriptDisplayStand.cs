using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScriptDisplayStand : MonoBehaviour {
    public string m_DisplayStandType;

    public ScriptShopPanel m_ScriptShopPanel;

    public GameObject m_Prefab;
    ScriptBuyableCaptainItems m_PrefabScript;
    RectTransform m_Rect;

    GameObject m_PrefabInstance;
    RectTransform m_RectInstance;

    public Text m_CostField;

    public int m_LineLength;

    public float posx;
    public float posy;

    string m_Type;

	// Use this for initialization
	void Start ()
    {
        switch (m_DisplayStandType)
        {
            case "Nose":
                FillingStand(m_ScriptShopPanel.m_NoseCatalog);
                m_Type = "Nose";
                break;

            case "Ears":
                FillingStand(m_ScriptShopPanel.m_EarsCatalog);
                m_Type = "Ears";
                break;

            case "Eyes":
                FillingStand(m_ScriptShopPanel.m_EyesCatalog);
                m_Type = "Eyes";
                break;

            case "Mouth":
                FillingStand(m_ScriptShopPanel.m_MouthCatalog);
                m_Type = "Mouth";
                break;

            case "Jacket":
                FillingStand(m_ScriptShopPanel.m_JacketCatalog);
                m_Type = "Jacket";
                break;

            case "Boots":
                FillingStand(m_ScriptShopPanel.m_BootsCatalog);
                m_Type = "Boots";
                break;

            case "Hat":
                FillingStand(m_ScriptShopPanel.m_HatCatalog);
                m_Type = "Hat";
                break;

            case "Pants":
                FillingStand(m_ScriptShopPanel.m_PantsCatalog);
                m_Type = "Pants";
                break;
        }

       
	
	}

    void FillingStand (List<string> m_List)
    {
        m_PrefabScript = m_Prefab.GetComponent<ScriptBuyableCaptainItems>();
        m_Rect = m_Prefab.GetComponent<RectTransform>();



        posy = 410f;

        int i = m_List.Count;

        int decrementvalue = m_List.Count - i;

        while (i > 0)
        {


            for (int j = 0; j < m_LineLength; j++)
            {
                if (i > 0)
                {
                    decrementvalue = m_List.Count - i;

                    m_PrefabScript.m_ItemsName = m_List[decrementvalue];
                    m_PrefabScript.m_CostField = m_CostField;
                    m_PrefabScript.m_ItemsType = m_Type;
                   

                    if (j == 0)
                    {
                        posx = -200f;
                    }

                    else
                    {
                        posx += (m_Rect.rect.width + 35f);
                    }
                    m_PrefabInstance = Instantiate(m_Prefab, new Vector3(0, 0, 0), transform.rotation) as GameObject;

                    m_Rect.localScale = new Vector3(0.15f, 0.15f, 1f);
                    m_PrefabInstance.transform.SetParent(this.transform);
                    m_RectInstance = m_PrefabInstance.GetComponent<RectTransform>();
                    m_RectInstance.transform.localPosition = new Vector3(posx, posy, 0f);



                    i--;

                }
            }
            posy -= 50f;
        }
    }
	
	
}
