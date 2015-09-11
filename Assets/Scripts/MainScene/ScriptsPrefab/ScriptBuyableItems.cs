using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScriptBuyableItems : MonoBehaviour
{
    public string m_ItemName;
    public string m_ItemType;

    public int m_Cost;

    public int[] m_ArrayofCharacteristics = new int[12];

    public int[] m_ArrayofEquipmentCharacteristics = new int[9];
    public string m_State1;
    public string m_State2;

    public string m_SpecialistSpeciality;

    public Text m_NameField;
    public string m_ShownItemName;

    public string m_Description;

    public Mesh m_ItemAppearance;

    public bool m_IsBought;

    public ScriptInventory m_Inventory;

    List<string> m_List;

    public ScriptBuyButton m_ScriptBuyButton;

	// Use this for initialization
	void Start ()
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

                    m_Description = TriDataBase.instance.m_BowDico[m_ItemName].m_Description;

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

                m_Description = TriDataBase.instance.m_SternDico[m_ItemName].m_Description;

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

                m_Description = TriDataBase.instance.m_KeelDico[m_ItemName].m_Description;

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

                m_Description = TriDataBase.instance.m_MastDico[m_ItemName].m_Description;

                m_Cost = TriDataBase.instance.m_MastDico[m_ItemName].m_Cost;
                    break;
                
            }
        

        
            switch (m_ItemType)
            {
                case "Specialist":
                    m_SpecialistSpeciality = TriDataBase.instance.m_SpecialistDico[m_ItemName].m_Speciality;

                    m_ArrayofEquipmentCharacteristics[0] = TriDataBase.instance.m_SpecialistDico[m_ItemName].m_Value;

                    m_Cost = TriDataBase.instance.m_SpecialistDico[m_ItemName].m_Cost;

                m_Description = TriDataBase.instance.m_SpecialistDico[m_ItemName].m_Description;

                break;

                case "Weapon":

                    m_ArrayofEquipmentCharacteristics[0] = TriDataBase.instance.m_WeaponDico[m_ItemName].m_Level;
                    m_ArrayofEquipmentCharacteristics[1] = TriDataBase.instance.m_WeaponDico[m_ItemName].m_LevelUp;
                    m_ArrayofEquipmentCharacteristics[2] = TriDataBase.instance.m_WeaponDico[m_ItemName].m_Damage;
                    m_ArrayofEquipmentCharacteristics[3] = TriDataBase.instance.m_WeaponDico[m_ItemName].m_DamageUpgrade;
                    m_ArrayofEquipmentCharacteristics[4] = TriDataBase.instance.m_WeaponDico[m_ItemName].m_Range;
                    m_ArrayofEquipmentCharacteristics[5] = TriDataBase.instance.m_WeaponDico[m_ItemName].m_RangeUpgrade;
                    m_ArrayofEquipmentCharacteristics[6] = Mathf.CeilToInt(TriDataBase.instance.m_WeaponDico[m_ItemName].m_Cooldown);
                    m_ArrayofEquipmentCharacteristics[7] = Mathf.CeilToInt(TriDataBase.instance.m_WeaponDico[m_ItemName].m_CooldownUpgrade);
                    m_ArrayofEquipmentCharacteristics[8] = TriDataBase.instance.m_WeaponDico[m_ItemName].m_ShootType;

                    m_State1 = TriDataBase.instance.m_WeaponDico[m_ItemName].m_State1;
                    m_State2 = TriDataBase.instance.m_WeaponDico[m_ItemName].m_State2;

                m_Description = TriDataBase.instance.m_WeaponDico[m_ItemName].m_Description;

                m_Cost = TriDataBase.instance.m_WeaponDico[m_ItemName].m_Cost;
                    break;

                case "Gadget":

                    m_ArrayofEquipmentCharacteristics[0] = TriDataBase.instance.m_GadgetDico[m_ItemName].m_Level;
                    m_ArrayofEquipmentCharacteristics[1] = TriDataBase.instance.m_GadgetDico[m_ItemName].m_LevelUp;
                    m_ArrayofEquipmentCharacteristics[2] = TriDataBase.instance.m_GadgetDico[m_ItemName].m_Damage;
                    m_ArrayofEquipmentCharacteristics[3] = TriDataBase.instance.m_GadgetDico[m_ItemName].m_DamageUpgrade;
                    m_ArrayofEquipmentCharacteristics[4] = TriDataBase.instance.m_GadgetDico[m_ItemName].m_Range;
                    m_ArrayofEquipmentCharacteristics[5] = TriDataBase.instance.m_GadgetDico[m_ItemName].m_RangeUpgrade;
                    m_ArrayofEquipmentCharacteristics[6] = Mathf.CeilToInt(TriDataBase.instance.m_GadgetDico[m_ItemName].m_Cooldown);
                    m_ArrayofEquipmentCharacteristics[7] = Mathf.CeilToInt(TriDataBase.instance.m_GadgetDico[m_ItemName].m_CooldownUpgrade);
                    m_ArrayofEquipmentCharacteristics[8] = TriDataBase.instance.m_GadgetDico[m_ItemName].m_ShootType;

                    m_State1 = TriDataBase.instance.m_GadgetDico[m_ItemName].m_State1;
                    m_State2 = TriDataBase.instance.m_GadgetDico[m_ItemName].m_State2;

                m_Description = TriDataBase.instance.m_GadgetDico[m_ItemName].m_Description;

                m_Cost = TriDataBase.instance.m_GadgetDico[m_ItemName].m_Cost;
                    break;

                case "Ultimate":

                    m_ArrayofEquipmentCharacteristics[0] = TriDataBase.instance.m_UltimateDico[m_ItemName].m_Level;
                    m_ArrayofEquipmentCharacteristics[1] = TriDataBase.instance.m_UltimateDico[m_ItemName].m_LevelUp;
                    m_ArrayofEquipmentCharacteristics[2] = TriDataBase.instance.m_UltimateDico[m_ItemName].m_Damage;
                    m_ArrayofEquipmentCharacteristics[3] = TriDataBase.instance.m_UltimateDico[m_ItemName].m_DamageUpgrade;
                    m_ArrayofEquipmentCharacteristics[4] = TriDataBase.instance.m_UltimateDico[m_ItemName].m_Range;
                    m_ArrayofEquipmentCharacteristics[5] = TriDataBase.instance.m_UltimateDico[m_ItemName].m_RangeUpgrade;
                    m_ArrayofEquipmentCharacteristics[6] = Mathf.CeilToInt(TriDataBase.instance.m_UltimateDico[m_ItemName].m_Cooldown);
                    m_ArrayofEquipmentCharacteristics[7] = Mathf.CeilToInt(TriDataBase.instance.m_UltimateDico[m_ItemName].m_CooldownUpgrade);
                    m_ArrayofEquipmentCharacteristics[8] = TriDataBase.instance.m_UltimateDico[m_ItemName].m_ShootType;

                    m_State1 = TriDataBase.instance.m_UltimateDico[m_ItemName].m_State1;
                    m_State2 = TriDataBase.instance.m_UltimateDico[m_ItemName].m_State2;

                m_Description = TriDataBase.instance.m_UltimateDico[m_ItemName].m_Description;

                m_Cost = TriDataBase.instance.m_UltimateDico[m_ItemName].m_Cost;
                    break;


            }

        CheckBought();

        m_NameField.text = m_ShownItemName;
	}
	
    public void AlreadyBought ()
    {
        m_ScriptBuyButton.Enabled(m_IsBought);
    }
	
    public void CheckBought ()
    {
        
         
        switch (m_ItemType)
        {
            case "Bow":

                m_List = m_Inventory.m_PossessedBowInventory;
                break;

            case "Stern":
                m_List = m_Inventory.m_PossessedSternInventory;
                break;

            case "Keel":
                m_List = m_Inventory.m_PossessedKeelInventory;
                break;

            case "Mast":
                m_List = m_Inventory.m_PossessedMastInventory;
                break;

            case "Specialist":

                m_List = m_Inventory.m_PossessedSpecialistInventory;

                break;

            case "Weapon":
                m_List = m_Inventory.m_PossessedWeaponInventory;
                break;

            case "Gadget":
                m_List = m_Inventory.m_PossessedGadgetInventory;
                break;

            case "Ultimate":
                m_List = m_Inventory.m_PossessedUltimateInventory;
                break;
        }

        foreach( string Name in m_List)
        {
            if (m_ItemName==Name)
            {
                m_IsBought = true;
            }
        } 
    }
}
