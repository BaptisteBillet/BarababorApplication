using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScriptStockSupportEquipment : MonoBehaviour
{
    public ScriptInventory m_ScriptInventory;

    public Text m_DescriptionField;
    public Image m_EquipmentIconField;

    public GameObject m_Ship;
    public ScriptShip m_ScriptShip; 

    public GameObject m_Prefab;
    GameObject m_PrefabInstance;
    ScriptShipEquipement m_Script;
    RectTransform m_Rect;
    RectTransform m_RectInstance;

    public ScriptBoathouseManager m_ScriptBoathouseManager;

    string m_Type;

    float posx;
    float posy;

    public int m_LineLength;

    



    void Start()
    {
        m_Ship = m_ScriptBoathouseManager.m_SelectedShip;
        m_ScriptShip = m_Ship.GetComponent<ScriptShip>();

              
    }

    public void Selection(int selector)
    {

        switch (selector)
        {
            case 0:

                m_Type = "Specialist";
                Construction(m_ScriptInventory.m_PossessedSpecialistInventory);
                break;


                case 1:
                m_Type = "Weapon";
                Construction(m_ScriptInventory.m_PossessedWeaponInventory);
                break;

                case 2:
                m_Type = "Gadget";
                Construction(m_ScriptInventory.m_PossessedGadgetInventory);
                break;

                case 3:
                m_Type = "Ultimate";
                Construction(m_ScriptInventory.m_PossessedUltimateInventory);
                break;

        }


    }


    public void Construction(List<string> m_List)
    {
       
        m_Script = m_Prefab.GetComponent<ScriptShipEquipement>();
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

                    m_Script.m_EquipementName = m_List[decrementvalue];
                    m_Script.m_DescriptionField = m_DescriptionField;
                    m_Script.m_EquipmentIconField = m_EquipmentIconField;
                    m_Script.m_EquipementType = m_Type;
                    m_Script.m_ScriptShip = m_ScriptShip;

                    if (j == 0)
                    {
                        posx = -200f;
                    }

                    else
                    {
                        posx += (m_Rect.rect.width+35f);
                    }
                    m_PrefabInstance = Instantiate(m_Prefab, new Vector3(0, 0,0), transform.rotation) as GameObject;
                    
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
