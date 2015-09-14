﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriDataBase : MonoBehaviour
{
    public Dictionary<string, Element> m_BowDico = new Dictionary<string, Element>();
    public Dictionary<string, Element> m_SternDico = new Dictionary<string, Element>();
    public Dictionary<string, Element> m_KeelDico = new Dictionary<string, Element>();
    public Dictionary<string, Element> m_MastDico = new Dictionary<string, Element>();


    public Dictionary<string, Equipment> m_WeaponDico = new Dictionary<string, Equipment>();
    public Dictionary<string, Specialist> m_SpecialistDico = new Dictionary<string, Specialist>();
    public Dictionary<string, Equipment> m_UltimateDico = new Dictionary<string, Equipment>();
    public Dictionary<string, Equipment> m_GadgetDico = new Dictionary<string, Equipment>();

    #region Singleton
    static private TriDataBase s_Instance;
    static public TriDataBase instance
    {
        get
        {
            return s_Instance;
        }
    }
    #endregion
    void Awake()
    {
        if (s_Instance == null)
            s_Instance = this;
        //DontDestroyOnLoad(this);

        #region Element
        foreach (Google2u.BOWRow row in Google2u.BOW.Instance.Rows)
        {
            Element m_Element = new Element();

            m_Element.m_Capacity = row._Capacity;
            m_Element.m_Damage = row._Damage;
            m_Element.m_HealthPoint = row._HealthPoint;
            m_Element.m_Regeneration = row._Regeneration;
            m_Element.m_Speed = row._Speed;
            m_Element.m_Vision = row._Vision;

            m_Element.m_CapacityUpgrade = row._CapacityUpgrade;
            m_Element.m_DamageUpgrade = row._DamageUpgrade;
            m_Element.m_HealthPointUpgrade = row._HealthPointUpgrade;
            m_Element.m_RegenerationUpgrade = row._RegenerationUpgrade;
            m_Element.m_SpeedUpgrade = row._SpeedUpgrade;
            m_Element.m_VisionUpgrade = row._VisionUpgrade;

            m_Element.m_Description = row._Description;

            m_Element.m_Cost = row._Cost;
            m_Element.m_Grade = row._Grade;
            m_Element.m_Rank = row._Rank;

            m_Element.m_Name = row._Name;

            m_Element.m_ShownName = row._ShownName;

            m_BowDico.Add(m_Element.m_Name, m_Element);
        }

        foreach (Google2u.KEELRow row in Google2u.KEEL.Instance.Rows)
        {
            Element m_Element = new Element();

            m_Element.m_Capacity = row._Capacity;
            m_Element.m_Damage = row._Damage;
            m_Element.m_HealthPoint = row._HealthPoint;
            m_Element.m_Regeneration = row._Regeneration;
            m_Element.m_Speed = row._Speed;
            m_Element.m_Vision = row._Vision;

            m_Element.m_CapacityUpgrade = row._CapacityUpgrade;
            m_Element.m_DamageUpgrade = row._DamageUpgrade;
            m_Element.m_HealthPointUpgrade = row._HealthPointUpgrade;
            m_Element.m_RegenerationUpgrade = row._RegenerationUpgrade;
            m_Element.m_SpeedUpgrade = row._SpeedUpgrade;
            m_Element.m_VisionUpgrade = row._VisionUpgrade;

            m_Element.m_Description = row._Description;

            m_Element.m_Cost = row._Cost;
            m_Element.m_Grade = row._Grade;
            m_Element.m_Rank = row._Rank;

            m_Element.m_Name = row._Name;

            m_Element.m_ShownName = row._ShownName;

            m_KeelDico.Add(m_Element.m_Name, m_Element);
        }

        foreach (Google2u.MASTRow row in Google2u.MAST.Instance.Rows)
        {
            Element m_Element = new Element();

            m_Element.m_Capacity = row._Capacity;
            m_Element.m_Damage = row._Damage;
            m_Element.m_HealthPoint = row._HealthPoint;
            m_Element.m_Regeneration = row._Regeneration;
            m_Element.m_Speed = row._Speed;
            m_Element.m_Vision = row._Vision;

            m_Element.m_CapacityUpgrade = row._CapacityUpgrade;
            m_Element.m_DamageUpgrade = row._DamageUpgrade;
            m_Element.m_HealthPointUpgrade = row._HealthPointUpgrade;
            m_Element.m_RegenerationUpgrade = row._RegenerationUpgrade;
            m_Element.m_SpeedUpgrade = row._SpeedUpgrade;
            m_Element.m_VisionUpgrade = row._VisionUpgrade;

            m_Element.m_Description = row._Description;

            m_Element.m_Cost = row._Cost;
            m_Element.m_Grade = row._Grade;
            m_Element.m_Rank = row._Rank;

            m_Element.m_Name = row._Name;

            m_Element.m_ShownName = row._ShownName;

            m_MastDico.Add(m_Element.m_Name, m_Element);
        }

        foreach (Google2u.STERNRow row in Google2u.STERN.Instance.Rows)
        {
            Element m_Element = new Element();

            m_Element.m_Capacity = row._Capacity;
            m_Element.m_Damage = row._Damage;
            m_Element.m_HealthPoint = row._HealthPoint;
            m_Element.m_Regeneration = row._Regeneration;
            m_Element.m_Speed = row._Speed;
            m_Element.m_Vision = row._Vision;

            m_Element.m_CapacityUpgrade = row._CapacityUpgrade;
            m_Element.m_DamageUpgrade = row._DamageUpgrade;
            m_Element.m_HealthPointUpgrade = row._HealthPointUpgrade;
            m_Element.m_RegenerationUpgrade = row._RegenerationUpgrade;
            m_Element.m_SpeedUpgrade = row._SpeedUpgrade;
            m_Element.m_VisionUpgrade = row._VisionUpgrade;

           m_Element.m_Description = row._Description;

            m_Element.m_Cost = row._Cost;
            m_Element.m_Grade = row._Grade;
            m_Element.m_Rank = row._Rank;

            m_Element.m_Name = row._Name;

            m_Element.m_ShownName = row._ShownName;

            m_SternDico.Add(m_Element.m_Name, m_Element);
        }
        #endregion

        #region Equipement
        foreach (Google2u.WEAPONRow row in Google2u.WEAPON.Instance.Rows)
        {
            Equipment m_Equipement = new Equipment();

            m_Equipement.m_Level = row._Level;
            m_Equipement.m_LevelUp = row._LevelUp;
            m_Equipement.m_Range = Mathf.CeilToInt(row._Range);
            m_Equipement.m_RangeUpgrade = Mathf.CeilToInt(row._RangeUpgrade);
            m_Equipement.m_Cooldown = row._Cooldown;
            m_Equipement.m_CooldownUpgrade = row._CooldownUpgrade;
            m_Equipement.m_ShootType = row._ShootType;
            m_Equipement.m_ShootTypeUpgrade = row._ShootTypeUpgrade;
            m_Equipement.m_Cost = row._Cost;
            m_Equipement.m_Grade = row._Grade;
            m_Equipement.m_Rank = row._Rank;
            m_Equipement.m_State1 = row._State1;
            m_Equipement.m_State2 = row._State2;
            m_Equipement.m_Damage = row._Damage;
            m_Equipement.m_DamageUpgrade = row._DamageUpgrade;
            m_Equipement.m_Description = row._Description;
            m_Equipement.m_Type = row._Type;
            
            m_Equipement.m_Name = row._Name;

            m_Equipement.m_ShownName = row._ShownName;


            m_WeaponDico.Add(m_Equipement.m_Name, m_Equipement);
        }

        foreach (Google2u.ULTIMATERow row in Google2u.ULTIMATE.Instance.Rows)
        {
            Equipment m_Equipement = new Equipment();

            m_Equipement.m_Level = row._Level;
            m_Equipement.m_LevelUp = row._LevelUp;
            m_Equipement.m_Range = Mathf.CeilToInt(row._Range);
            m_Equipement.m_RangeUpgrade = Mathf.CeilToInt(row._RangeUpgrade);
            m_Equipement.m_Cooldown = row._Cooldown;
            m_Equipement.m_CooldownUpgrade = row._CooldownUpgrade;
            m_Equipement.m_ShootType = row._ShootType;
            m_Equipement.m_ShootTypeUpgrade = row._ShootTypeUpgrade;
            m_Equipement.m_Cost = row._Cost;
            m_Equipement.m_Grade = row._Grade;
            m_Equipement.m_Rank = row._Rank;
            m_Equipement.m_State1 = row._State1;
            m_Equipement.m_State2 = row._State2;
            m_Equipement.m_Damage = row._Damage;
            m_Equipement.m_DamageUpgrade = row._DamageUpgrade;
            m_Equipement.m_Description = row._Description;
            m_Equipement.m_Type = row._Type;


            m_Equipement.m_Name = row._Name;

            m_Equipement.m_ShownName = row._ShownName;

            m_UltimateDico.Add(m_Equipement.m_Name, m_Equipement);
        }

        foreach (Google2u.GADGETRow row in Google2u.GADGET.Instance.Rows)
        {
            Equipment m_Equipement = new Equipment();

            m_Equipement.m_Level = row._Level;
            m_Equipement.m_LevelUp = row._LevelUp;
            m_Equipement.m_Range = Mathf.CeilToInt(row._Range);
            m_Equipement.m_RangeUpgrade = Mathf.CeilToInt(row._RangeUpgrade);
            m_Equipement.m_Cooldown = row._Cooldown;
            m_Equipement.m_CooldownUpgrade = row._CooldownUpgrade;
            m_Equipement.m_ShootType = row._ShootType;
            m_Equipement.m_ShootTypeUpgrade = row._ShootTypeUpgrade;
            m_Equipement.m_Cost = row._Cost;
            m_Equipement.m_Grade = row._Grade;
            m_Equipement.m_Rank = row._Rank;
            m_Equipement.m_State1 = row._State1;
            m_Equipement.m_State2 = row._State2;
            m_Equipement.m_Damage = row._Damage;
            m_Equipement.m_DamageUpgrade = row._DamageUpgrade;
            m_Equipement.m_Description = row._Description;
            m_Equipement.m_Type = row._Type;


            m_Equipement.m_Name = row._Name;

            m_Equipement.m_ShownName = row._ShownName;

            m_GadgetDico.Add(m_Equipement.m_Name, m_Equipement);
        }


        foreach (Google2u.SPECIALISTRow row in Google2u.SPECIALIST.Instance.Rows)
        {
            Specialist m_Specialist = new Specialist();

           
            m_Specialist.m_Speciality = row._Speciality;
            m_Specialist.m_Value = row._Value;
            m_Specialist.m_Description = row._Description;
            m_Specialist.m_Cost = row._Cost;
            m_Specialist.m_Type = row._Type;

            m_Specialist.m_Name = row._Name;

            m_Specialist.m_ShownName = row._ShownName;

            m_SpecialistDico.Add(m_Specialist.m_Name, m_Specialist);
        }
        #endregion

    }


}