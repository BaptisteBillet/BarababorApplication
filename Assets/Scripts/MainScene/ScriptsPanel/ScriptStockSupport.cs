using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScriptStockSupportEquipment : MonoBehaviour
{
    public ScriptInventory m_ScriptInventory;

    public Text m_DescriptionField;
    public Image m_EquipmentIconField;


    public GameObject m_Prefab;
    GameObject m_PrefabInstance;
    ScriptShipEquipement m_Script;
    RectTransform m_Rect;

    float posx;
    float posy;

    public int m_LineLength;

    int selector;

    

    void Start()
    {
        selector = 0;
        Selection();
        Debug.Log("OY");
    }

    public void Selection()
    {

        switch (selector)
        {
            case 0:
                Construction(m_ScriptInventory.m_PossessedSpecialistInventory);
                Debug.Log("OY2");
                break;


            /*case 1:
                m_List = m_ScriptInventory.m_PossessedWeaponInventory;
                break;

            case 2:
                m_List = m_ScriptInventory.m_PossessedGadgetInventory;
                break;

            case 3:
                m_List = m_ScriptInventory.m_PossessedUltimateInventory;
                break;*/

        }

       
    }


    public void Construction(List<string> m_List)
    {
        Debug.Log("OY3");
        m_Script = m_Prefab.GetComponent<ScriptShipEquipement>();
        m_Rect = m_Prefab.GetComponent<RectTransform>();

        m_Script.m_EquipementIconField = m_EquipmentIconField;
        m_Script.m_DescriptionField = m_DescriptionField;

        posy = 900f;

        int i = m_List.Count;

        int decrementvalue = m_List.Count - i;  

        while (i > 0) 
        {


            for (int j = 0; j < m_LineLength; j++) 
            {
                if (i > 0)
                {
                    decrementvalue = m_List.Count - i;

                    m_Script.m_EquipementName = m_List[decrementvalue];

                    if (j == 0)
                    {
                        posx = 100f;
                    }

                    else  
                    {
                        posx += (m_Rect.rect.width + 15f); 
                    }
                    m_PrefabInstance = Instantiate(m_Prefab, new Vector3(posx, posy), transform.rotation) as GameObject;
                    m_PrefabInstance.transform.SetParent(this.transform);


                    i--;

                }
            }
            posy += -50f;
        }
    }

}
