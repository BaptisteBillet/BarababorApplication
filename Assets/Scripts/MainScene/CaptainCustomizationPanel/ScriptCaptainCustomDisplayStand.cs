﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptCaptainCustomDisplayStand : MonoBehaviour {

    public string m_DisplayStandType;

   public ScriptMeshLibrary m_ScriptMeshLibrary;

    public GameObject m_Prefab;
    ScriptBuyableCaptainItems m_PrefabScript;
    RectTransform m_Rect;

    GameObject m_PrefabInstance;
    RectTransform m_RectInstance;

    [HideInInspector]
    public ScriptCaptainBody m_ScriptCaptainBody;

    [HideInInspector]
    public ScriptCaptainHead m_ScriptCaptainHead;

    public int m_LineLength;

    float posx;
    float posy;

    GameObject m_CaptainParttoChange;
    GameObject m_CaptainParttoChange2;

    public ScriptInventory m_Inventory;
  
    bool m_DoubleChange;

    public ScriptGeneralCaptainCustomizationPanel m_SuperiorScript;

    void Start()
    {
        m_ScriptCaptainBody = m_SuperiorScript.Captain.GetComponent<ScriptCaptainBody>();
        m_ScriptCaptainHead = m_SuperiorScript.m_CaptainHead.GetComponent<ScriptCaptainHead>();

        switch (m_DisplayStandType)
        {
            case "Nose":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[0];
                FillingStand(m_Inventory.m_PossessedNoseInventory);
                break;

            case "Ears":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[3];
                m_CaptainParttoChange2 = m_ScriptCaptainHead.m_HeadParts[4];
                m_DoubleChange = true;
                FillingStand(m_Inventory.m_PossessedEarsInventory);
                break;

            case "Eyes":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[1];
                m_CaptainParttoChange2 = m_ScriptCaptainHead.m_HeadParts[2];
                m_DoubleChange = true;
                FillingStand(m_Inventory.m_PossessedEyesInventory);
                break;

            case "Mouth":

                m_CaptainParttoChange = m_ScriptCaptainHead.m_HeadParts[5];
                FillingStand(m_Inventory.m_PossessedMouthInventory);
                break;

            case "Jacket":

                m_CaptainParttoChange = m_ScriptCaptainBody.m_ArrayofWears[5];
                FillingStand(m_Inventory.m_PossessedJacketInventory);

                break;

            case "Boots":
                m_CaptainParttoChange = m_ScriptCaptainBody.m_ArrayofWears[3];
                m_CaptainParttoChange2 = m_ScriptCaptainBody.m_ArrayofWears[4];
                m_DoubleChange = true;
                FillingStand(m_Inventory.m_PossessedBootsInventory);

                break;

            case "Hat":
                m_CaptainParttoChange = m_ScriptCaptainBody.m_ArrayofWears[0];
                FillingStand(m_Inventory.m_PossessedHatInventory);

                break;

            case "Pants":
                m_CaptainParttoChange = m_ScriptCaptainBody.m_ArrayofWears[1];
                m_CaptainParttoChange2 = m_ScriptCaptainBody.m_ArrayofWears[2];
                m_DoubleChange = true;
                FillingStand(m_Inventory.m_PossessedPantsInventory);

                break;
        }



    }

    void FillingStand(List<string> m_List)
    {
        m_PrefabScript = m_Prefab.GetComponent<ScriptBuyableCaptainItems>();
        m_Rect = m_Prefab.GetComponent<RectTransform>();



        posy = 450f;

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
                    m_PrefabScript.m_ScriptMeshLibrary = m_ScriptMeshLibrary;
                    m_PrefabScript.m_ItemsName = m_List[decrementvalue];
                    m_PrefabScript.m_CaptainParttoChange = m_CaptainParttoChange;
                    m_PrefabScript.m_Inventory = m_Inventory;
                    m_PrefabScript.m_DisplayStand = this.gameObject;



                    if (m_DoubleChange == true)
                    {
                        m_PrefabScript.m_CaptainParttoChange2 = m_CaptainParttoChange2;
                        m_PrefabScript.m_DoubleChange = true;
                    }

                    else
                    {
                        m_PrefabScript.m_CaptainParttoChange2 = null;
                        m_PrefabScript.m_DoubleChange = false;
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
