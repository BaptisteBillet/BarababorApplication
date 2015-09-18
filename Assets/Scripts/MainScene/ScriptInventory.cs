using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class ScriptInventory : MonoBehaviour
{
    #region MemberDeclaration
    [HideInInspector]
    public List<string> m_PossessedBowInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedSternInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedKeelInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedMastInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedSpecialistInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedWeaponInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedGadgetInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedUltimateInventory = new List<string>();


    [HideInInspector]
    public List<string> m_PossessedNoseInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedEarsInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedEyesInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedMouthInventory = new List<string>();


    [HideInInspector]
    public List<string> m_PossessedJacketInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedPantsInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedBootsInventory = new List<string>();

    [HideInInspector]
    public List<string> m_PossessedHatInventory = new List<string>();



    [HideInInspector]
    public int m_BowInventoryAvailability;

    [HideInInspector]
    public int m_SternInventoryAvailability;

    [HideInInspector]
    public int m_KeelInventoryAvailability;

    [HideInInspector]
    public int m_MastInventoryAvailability;

    [HideInInspector]
    public int m_SpecialistInventoryAvailability;

    [HideInInspector]
    public int m_WeaponInventoryAvailability;

    [HideInInspector]
    public int m_GadgetInventoryAvailability;

    [HideInInspector]
    public int m_UltimateInventoryAvailability;

    [HideInInspector]
    public int m_NoseInventoryAvailability;

    [HideInInspector]
    public int m_EarsInventoryAvailability;

    [HideInInspector]
    public int m_EyesInventoryAvailability;

    [HideInInspector]
    public int m_MouthInventoryAvailability;

    [HideInInspector]
    public int m_JacketInventoryAvailability;

    [HideInInspector]
    public int m_BootsInventoryAvailability;

    [HideInInspector]
    public int m_PantsInventoryAvailability;

    [HideInInspector]
    public int m_HatInventoryAvailability;

    string m_SaveString;

    public List<string> StringTest = new List<string>();
    #endregion

    void Awake ()
    {
       if (PlayerPrefs.GetInt("m_BowInventoryAvailability")!=0)
        { Load(m_PossessedBowInventory, "BowInventory"); }

        if (PlayerPrefs.GetInt("m_SternInventoryAvailability") != 0)
        { Load(m_PossessedSternInventory, "SternInventory"); }

        if (PlayerPrefs.GetInt("m_KeelInventoryAvailability") != 0)
        { Load(m_PossessedKeelInventory, "KeelInventory"); }

        if (PlayerPrefs.GetInt("m_MastInventoryAvailability") != 0)
        { Load(m_PossessedMastInventory, "MastInventory"); }


        if (PlayerPrefs.GetInt("m_SpecialistInventoryAvailability") != 0)
        { Load(m_PossessedSpecialistInventory, "SpecialistInventory"); }

        if (PlayerPrefs.GetInt("m_WeaponInventoryAvailability") != 0)
        { Load(m_PossessedWeaponInventory, "WeaponInventory"); }

        if (PlayerPrefs.GetInt("m_GadgetInventoryAvailability") != 0)
        { Load(m_PossessedGadgetInventory, "GadgetInventory"); }

        if (PlayerPrefs.GetInt("m_UltimateInventoryAvailability") != 0)
        { Load(m_PossessedUltimateInventory, "UltimateInventory"); }


        Debug.Log(PlayerPrefs.GetInt("m_NoseInventoryAvailability"));
        if (PlayerPrefs.GetInt("m_NoseInventoryAvailability") != 0)
        { Load(m_PossessedNoseInventory, "NoseInventory"); }

        if (PlayerPrefs.GetInt("m_EarsInventoryAvailability") != 0)
        { Load(m_PossessedEarsInventory, "EarsInventory"); }

        if (PlayerPrefs.GetInt("m_EyesInventoryAvailability") != 0)
        { Load(m_PossessedEyesInventory, "EyesInventory"); }

        if (PlayerPrefs.GetInt("m_MouthInventoryAvailability") != 0)
        { Load(m_PossessedMouthInventory, "MouthInventory"); }


        if (PlayerPrefs.GetInt("m_JacketInventoryAvailability") != 0)
        { Load(m_PossessedJacketInventory, "JacketInventory"); }

        if (PlayerPrefs.GetInt("m_BootsInventoryAvailability") != 0)
        { Load(m_PossessedBootsInventory, "BootsInventory"); }

        if (PlayerPrefs.GetInt("m_PantsInventoryAvailability") != 0)
        { Load(m_PossessedPantsInventory, "PantsInventory"); }

        if (PlayerPrefs.GetInt("m_HatInventoryAvailability") != 0)
        { Load(m_PossessedHatInventory, "HatInventory"); }


    }
	
   

#region Save 

    public void SaveInventory(List<string> m_List, string m_File)
    {
        StringTest = m_List;

            foreach (string data in m_List)
            {
                m_SaveString += data + "|";
            }
        
        
        File.WriteAllText(Application.dataPath + m_File + ".txt", m_SaveString);
                  
    }
#endregion

    public void Load (List<string> m_List,string m_File)
    {
        StringReader Reader = new StringReader(File.ReadAllText(Application.dataPath + m_File +".txt"));

        string s = Reader.ReadLine();
       
        while (s != null)
        {
            char[] delimiter = { '|' };
            string[] result = s.Split(delimiter);

            

            for (int i=0; i<result.Length-1; i++)
            {
               
                m_List.Add(result[i]);
            }
            

            
            s = Reader.ReadLine();
        }

    }

  
}
