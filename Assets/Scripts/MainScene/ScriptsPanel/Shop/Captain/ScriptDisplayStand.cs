using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScriptDisplayStand : MonoBehaviour {
    public string m_DisplayStandType;

    public ScriptShopPanel m_ScriptShopPanel;

    public ScriptMeshLibrary m_ScriptMeshLibrary;

    public GameObject m_Prefab;
    ScriptBuyableCaptainItems m_PrefabScript;
    RectTransform m_Rect;

    GameObject m_PrefabInstance;
    RectTransform m_RectInstance;

    public Text m_CostField;

    public ScriptCaptainBody m_ScriptCaptainBody;
    public ScriptCaptainHead m_ScriptCaptainHead;

    public int m_LineLength;

    float posx;
    float posy;

    GameObject m_CaptainParttoChange;
    GameObject m_CaptainParttoChange2;

    bool m_DoubleChange;
    // Use this for initialization
    void Start ()
    {
        m_ScriptCaptainBody=m_ScriptShopPanel.m_ScriptCaptainBody;
        m_ScriptCaptainHead=m_ScriptShopPanel.m_ScriptCaptainHead;

        switch (m_DisplayStandType)
        {
            case "Nose":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[0];
                FillingStand(m_ScriptShopPanel.m_NoseCatalog);
                break;

            case "Ears":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[3];
                m_CaptainParttoChange2 = m_ScriptCaptainHead.m_HeadParts[4];
                m_DoubleChange = true;
                FillingStand(m_ScriptShopPanel.m_EarsCatalog);                
                break;

            case "Eyes":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[1];
                m_CaptainParttoChange2 = m_ScriptCaptainHead.m_HeadParts[2];
                m_DoubleChange = true;
                FillingStand(m_ScriptShopPanel.m_EyesCatalog);
                break;

            case "Mouth":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[5];
                FillingStand(m_ScriptShopPanel.m_MouthCatalog);               
                break;

            case "Jacket":
                FillingStand(m_ScriptShopPanel.m_JacketCatalog);
        
                break;

            case "Boots":
                FillingStand(m_ScriptShopPanel.m_BootsCatalog);
     
                break;

            case "Hat":
                FillingStand(m_ScriptShopPanel.m_HatCatalog);
       
                break;

            case "Pants":
                FillingStand(m_ScriptShopPanel.m_PantsCatalog);
      
                break;
        }

        
	
	}

    void FillingStand (List<string> m_List)
    {
        m_PrefabScript = m_Prefab.GetComponent<ScriptBuyableCaptainItems>();
        m_Rect = m_Prefab.GetComponent<RectTransform>();



        posy = 510f;

        int i = m_List.Count;
       
        int decrementvalue = m_List.Count - i;

        while (i > 0)
        {


            for (int j = 0; j < m_LineLength; j++)
            {
                if (i > 0)
                {
                    decrementvalue = m_List.Count - i;

                    

                    m_PrefabScript.m_ItemsType = m_DisplayStandType;
                    m_PrefabScript.m_CostField = m_CostField;
                    m_PrefabScript.m_ScriptMeshLibrary = m_ScriptMeshLibrary;
                    m_PrefabScript.m_ItemsName = m_List[decrementvalue];
                    m_PrefabScript.m_CaptainParttoChange = m_CaptainParttoChange;

                    if(m_DoubleChange== true)
                    {
                        m_PrefabScript.m_CaptainParttoChange2 = m_CaptainParttoChange2;
                        m_PrefabScript.m_DoubleChange = true;
                    }
                       


                    if (j == 0)
                    {
                        posx = -160f;
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
