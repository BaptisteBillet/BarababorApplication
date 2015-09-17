using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriDataBase : MonoBehaviour
{
    #region ElementandEquipementDicos
    public Dictionary<string, Element> m_BowDico = new Dictionary<string, Element>();
    public Dictionary<string, Element> m_SternDico = new Dictionary<string, Element>();
    public Dictionary<string, Element> m_KeelDico = new Dictionary<string, Element>();
    public Dictionary<string, Element> m_MastDico = new Dictionary<string, Element>();


    public Dictionary<string, Equipment> m_WeaponDico = new Dictionary<string, Equipment>();
    public Dictionary<string, Specialist> m_SpecialistDico = new Dictionary<string, Specialist>();
    public Dictionary<string, Equipment> m_UltimateDico = new Dictionary<string, Equipment>();
    public Dictionary<string, Equipment> m_GadgetDico = new Dictionary<string, Equipment>();
    #endregion


    public Dictionary<string, ScriptCaptainParts> m_NoseDico = new Dictionary<string, ScriptCaptainParts>();
    public Dictionary<string, ScriptCaptainParts> m_EarsDico = new Dictionary<string, ScriptCaptainParts>();
    public Dictionary<string, ScriptCaptainParts> m_EyesDico = new Dictionary<string, ScriptCaptainParts>();
    public Dictionary<string, ScriptCaptainParts> m_MouthDico = new Dictionary<string, ScriptCaptainParts>();

    public Dictionary<string, ScriptCaptainWears> m_JacketDico = new Dictionary<string, ScriptCaptainWears>();
    public Dictionary<string, ScriptCaptainWears> m_HatDico = new Dictionary<string, ScriptCaptainWears>();
    public Dictionary<string, ScriptCaptainWears> m_PantsDico = new Dictionary<string, ScriptCaptainWears>();
    public Dictionary<string, ScriptCaptainWears> m_BootsDico = new Dictionary<string, ScriptCaptainWears>();

    public ScriptMeshLibrary m_ScriptMeshLibrary;

    public ScriptShopPanel m_ScriptShopPanel;


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

        #region CaptainWears

        foreach (Google2u.BOOTSRow row in Google2u.BOOTS.Instance.Rows)
        {
            ScriptCaptainWears m_CaptainWear = new ScriptCaptainWears();


            m_CaptainWear.m_WearName = row._Name;
            m_CaptainWear.m_WearCost = row._Cost;
            m_CaptainWear.m_WearShownName = row._ShownName;
            m_CaptainWear.m_WearAppearance = m_ScriptMeshLibrary.m_BootsList[row._Appearance];
            

           

            m_CaptainWear.m_WearShownName = row._ShownName;

            m_BootsDico.Add(m_CaptainWear.m_WearName, m_CaptainWear);

            m_ScriptShopPanel.m_BootsCatalog.Add(m_CaptainWear.m_WearName);
        }

        foreach (Google2u.JACKETRow row in Google2u.JACKET.Instance.Rows)
        {
            ScriptCaptainWears m_CaptainWear = new ScriptCaptainWears();


            m_CaptainWear.m_WearName = row._Name;
            m_CaptainWear.m_WearCost = row._Cost;
            m_CaptainWear.m_WearShownName = row._ShownName;
            m_CaptainWear.m_WearAppearance = m_ScriptMeshLibrary.m_JacketList[row._Appearance];




            m_CaptainWear.m_WearShownName = row._ShownName;

            m_JacketDico.Add(m_CaptainWear.m_WearName, m_CaptainWear);

            m_ScriptShopPanel.m_JacketCatalog.Add(m_CaptainWear.m_WearName);
        }

        foreach (Google2u.HATRow row in Google2u.HAT.Instance.Rows)
        {
            ScriptCaptainWears m_CaptainWear = new ScriptCaptainWears();


            m_CaptainWear.m_WearName = row._Name;
            m_CaptainWear.m_WearCost = row._Cost;
            m_CaptainWear.m_WearShownName = row._ShownName;
            m_CaptainWear.m_WearAppearance = m_ScriptMeshLibrary.m_HatList[row._Appearance];




            m_CaptainWear.m_WearShownName = row._ShownName;

            m_HatDico.Add(m_CaptainWear.m_WearName, m_CaptainWear);

            m_ScriptShopPanel.m_HatCatalog.Add(m_CaptainWear.m_WearName);
        }

        foreach (Google2u.PANTSRow row in Google2u.PANTS.Instance.Rows)
        {
            ScriptCaptainWears m_CaptainWear = new ScriptCaptainWears();


            m_CaptainWear.m_WearName = row._Name;
            m_CaptainWear.m_WearCost = row._Cost;
            m_CaptainWear.m_WearShownName = row._ShownName;
            m_CaptainWear.m_WearAppearance = m_ScriptMeshLibrary.m_PantsList[row._Appearance];




            m_CaptainWear.m_WearShownName = row._ShownName;

            m_PantsDico.Add(m_CaptainWear.m_WearName, m_CaptainWear);

            m_ScriptShopPanel.m_PantsCatalog.Add(m_CaptainWear.m_WearName);
        }
        #endregion

        foreach (Google2u.NOSERow row in Google2u.NOSE.Instance.Rows)
        {
            ScriptCaptainParts m_CaptainPart = new ScriptCaptainParts();


            m_CaptainPart.m_PartsName = row._Name;
            m_CaptainPart.m_PartsCost = row._Cost;
            m_CaptainPart.m_PartsShownName = row._ShownName;
            m_CaptainPart.m_PartsAppearance = m_ScriptMeshLibrary.m_NoseList[row._Appearance];


            m_NoseDico.Add(m_CaptainPart.m_PartsName, m_CaptainPart);

            m_ScriptShopPanel.m_NoseCatalog.Add(m_CaptainPart.m_PartsName);
        }

        foreach (Google2u.EARSRow row in Google2u.EARS.Instance.Rows)
        {
            ScriptCaptainParts m_CaptainPart = new ScriptCaptainParts();


            m_CaptainPart.m_PartsName = row._Name;
            m_CaptainPart.m_PartsCost = row._Cost;
            m_CaptainPart.m_PartsShownName = row._ShownName;
            m_CaptainPart.m_PartsAppearance = m_ScriptMeshLibrary.m_EarsList[row._Appearance];


            m_EarsDico.Add(m_CaptainPart.m_PartsName, m_CaptainPart);

            m_ScriptShopPanel.m_EarsCatalog.Add(m_CaptainPart.m_PartsName);
        }


        foreach (Google2u.EYESRow row in Google2u.EYES.Instance.Rows)
        {
            ScriptCaptainParts m_CaptainPart = new ScriptCaptainParts();


            m_CaptainPart.m_PartsName = row._Name;
            m_CaptainPart.m_PartsCost = row._Cost;
            m_CaptainPart.m_PartsShownName = row._ShownName;
            m_CaptainPart.m_PartsAppearance = m_ScriptMeshLibrary.m_EyesList[row._Appearance];


            m_EyesDico.Add(m_CaptainPart.m_PartsName, m_CaptainPart);

            m_ScriptShopPanel.m_EyesCatalog.Add(m_CaptainPart.m_PartsName);
        }

        foreach (Google2u.MOUTHRow row in Google2u.MOUTH.Instance.Rows)
        {
            ScriptCaptainParts m_CaptainPart = new ScriptCaptainParts();


            m_CaptainPart.m_PartsName = row._Name;
            m_CaptainPart.m_PartsCost = row._Cost;
            m_CaptainPart.m_PartsShownName = row._ShownName;
            m_CaptainPart.m_PartsAppearance = m_ScriptMeshLibrary.m_MouthList[row._Appearance];


            m_MouthDico.Add(m_CaptainPart.m_PartsName, m_CaptainPart);

            m_ScriptShopPanel.m_MouthCatalog.Add(m_CaptainPart.m_PartsName);
        }

    }


}