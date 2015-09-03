using UnityEngine;
using System.Collections;

public class ScriptBuyableItems : MonoBehaviour
{

    public bool m_IsElement;

    public string m_ItemName;
    public string m_ItemType;

    public int m_Cost;

    public int[] m_ArrayofCharacteristics = new int[12];

    public int[] m_ArrayofEquipmentCharacteristics = new int[12];

    public Mesh m_ItemAppearance;

	// Use this for initialization
	void Start ()
    {
	    if (m_IsElement==true)
        {
            switch (m_ItemType)
            {
                case "Bow":
                     m_ArrayofCharacteristics[0] = TriDataBase.instance.m_BowDico[m_ItemName].m_Speed;
                     m_ArrayofCharacteristics[1] = TriDataBase.instance.m_BowDico[m_ItemName].m_SpeedUpgrade;
                     m_ArrayofCharacteristics[2] = TriDataBase.instance.m_BowDico[m_ItemName].m_Damage;
                     m_ArrayofCharacteristics[3] = TriDataBase.instance.m_BowDico[m_ItemName].m_DamageUpgrade;
                     m_ArrayofCharacteristics[4] = TriDataBase.instance.m_BowDico[m_ItemName].m_Capacity;
                     m_ArrayofCharacteristics[5] = TriDataBase.instance.m_BowDico[m_ItemName].m_CapacityUpgrade;
                     m_ArrayofCharacteristics[6] = TriDataBase.instance.m_BowDico[m_ItemName].m_HealthPoint;
                     m_ArrayofCharacteristics[7] = TriDataBase.instance.m_BowDico[m_ItemName].m_HealthPointUpgrade;
                     m_ArrayofCharacteristics[8] = TriDataBase.instance.m_BowDico[m_ItemName].m_Regeneration;
                     m_ArrayofCharacteristics[9] = TriDataBase.instance.m_BowDico[m_ItemName].m_RegenerationUpgrade;
                    m_ArrayofCharacteristics[10] = TriDataBase.instance.m_BowDico[m_ItemName].m_Vision;
                    m_ArrayofCharacteristics[11] = TriDataBase.instance.m_BowDico[m_ItemName].m_VisionUpgrade;

                    m_Cost = TriDataBase.instance.m_BowDico[m_ItemName].m_Cost;
                    break;

                case "Stern":
                    m_ArrayofCharacteristics[0] = TriDataBase.instance.m_SternDico[m_ItemName].m_Speed;
                    m_ArrayofCharacteristics[1] = TriDataBase.instance.m_SternDico[m_ItemName].m_SpeedUpgrade;
                    m_ArrayofCharacteristics[2] = TriDataBase.instance.m_SternDico[m_ItemName].m_Damage;
                    m_ArrayofCharacteristics[3] = TriDataBase.instance.m_SternDico[m_ItemName].m_DamageUpgrade;
                    m_ArrayofCharacteristics[4] = TriDataBase.instance.m_SternDico[m_ItemName].m_Capacity;
                    m_ArrayofCharacteristics[5] = TriDataBase.instance.m_SternDico[m_ItemName].m_CapacityUpgrade;
                    m_ArrayofCharacteristics[6] = TriDataBase.instance.m_SternDico[m_ItemName].m_HealthPoint;
                    m_ArrayofCharacteristics[7] = TriDataBase.instance.m_SternDico[m_ItemName].m_HealthPointUpgrade;
                    m_ArrayofCharacteristics[8] = TriDataBase.instance.m_SternDico[m_ItemName].m_Regeneration;
                    m_ArrayofCharacteristics[9] = TriDataBase.instance.m_SternDico[m_ItemName].m_RegenerationUpgrade;
                   m_ArrayofCharacteristics[10] = TriDataBase.instance.m_SternDico[m_ItemName].m_Vision;
                   m_ArrayofCharacteristics[11] = TriDataBase.instance.m_SternDico[m_ItemName].m_VisionUpgrade;

                   m_Cost = TriDataBase.instance.m_SternDico[m_ItemName].m_Cost;
                    break;

                case "Keel":
                    m_ArrayofCharacteristics[0] = TriDataBase.instance.m_KeelDico[m_ItemName].m_Speed;
                    m_ArrayofCharacteristics[1] = TriDataBase.instance.m_KeelDico[m_ItemName].m_SpeedUpgrade;
                    m_ArrayofCharacteristics[2] = TriDataBase.instance.m_KeelDico[m_ItemName].m_Damage;
                    m_ArrayofCharacteristics[3] = TriDataBase.instance.m_KeelDico[m_ItemName].m_DamageUpgrade;
                    m_ArrayofCharacteristics[4] = TriDataBase.instance.m_KeelDico[m_ItemName].m_Capacity;
                    m_ArrayofCharacteristics[5] = TriDataBase.instance.m_KeelDico[m_ItemName].m_CapacityUpgrade;
                    m_ArrayofCharacteristics[6] = TriDataBase.instance.m_KeelDico[m_ItemName].m_HealthPoint;
                    m_ArrayofCharacteristics[7] = TriDataBase.instance.m_KeelDico[m_ItemName].m_HealthPointUpgrade;
                    m_ArrayofCharacteristics[8] = TriDataBase.instance.m_KeelDico[m_ItemName].m_Regeneration;
                    m_ArrayofCharacteristics[9] = TriDataBase.instance.m_KeelDico[m_ItemName].m_RegenerationUpgrade;
                   m_ArrayofCharacteristics[10] = TriDataBase.instance.m_KeelDico[m_ItemName].m_Vision;
                   m_ArrayofCharacteristics[11] = TriDataBase.instance.m_KeelDico[m_ItemName].m_VisionUpgrade;
                                                                         
                   m_Cost = TriDataBase.instance.m_KeelDico[m_ItemName].m_Cost;
                    break;

                case "Mast":

                    m_ArrayofCharacteristics[0] = TriDataBase.instance.m_MastDico[m_ItemName].m_Speed;
                    m_ArrayofCharacteristics[1] = TriDataBase.instance.m_MastDico[m_ItemName].m_SpeedUpgrade;
                    m_ArrayofCharacteristics[2] = TriDataBase.instance.m_MastDico[m_ItemName].m_Damage;
                    m_ArrayofCharacteristics[3] = TriDataBase.instance.m_MastDico[m_ItemName].m_DamageUpgrade;
                    m_ArrayofCharacteristics[4] = TriDataBase.instance.m_MastDico[m_ItemName].m_Capacity;
                    m_ArrayofCharacteristics[5] = TriDataBase.instance.m_MastDico[m_ItemName].m_CapacityUpgrade;
                    m_ArrayofCharacteristics[6] = TriDataBase.instance.m_MastDico[m_ItemName].m_HealthPoint;
                    m_ArrayofCharacteristics[7] = TriDataBase.instance.m_MastDico[m_ItemName].m_HealthPointUpgrade;
                    m_ArrayofCharacteristics[8] = TriDataBase.instance.m_MastDico[m_ItemName].m_Regeneration;
                    m_ArrayofCharacteristics[9] = TriDataBase.instance.m_MastDico[m_ItemName].m_RegenerationUpgrade;
                   m_ArrayofCharacteristics[10] = TriDataBase.instance.m_MastDico[m_ItemName].m_Vision;
                   m_ArrayofCharacteristics[11] = TriDataBase.instance.m_MastDico[m_ItemName].m_VisionUpgrade;

                    m_Cost = TriDataBase.instance.m_MastDico[m_ItemName].m_Cost;
                    break;
                
            }
        }
	}
	
	
}
