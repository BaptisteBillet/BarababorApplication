using UnityEngine;
using System.Collections;
using System.IO;

public class ScriptCaptainMainScene : MonoBehaviour {

    public Transform[] m_ArrayofPartsTransform = new Transform[14];

    public float[] m_ArrayofCharacteristics = new float[27];


	// Use this for initialization
	void Start ()
    {
        LoadCharacteristics();
        CharacteristicsAttribution();
	}
	
	
    public void LoadCharacteristics ()
    {
        StringReader Reader = new StringReader(File.ReadAllText(Application.dataPath + "PhysicalModifications.txt"));

        string s = Reader.ReadLine();

        while (s != null)
        {
            char[] delimiter = { '|' };
            string[] result = s.Split(delimiter);



            for (int i = 0; i < result.Length - 1; i++)
            {

                m_ArrayofCharacteristics[i]= float.Parse(result[i]);
            }



            s = Reader.ReadLine();
        }
    }

    public void CharacteristicsAttribution ()
    {
        float valeurx = new float();
        bool isvaleurx = new bool();

        float valeury = new float();
        bool isvaleury = new bool();

        float valeurz = new float();
        bool isvaleurz = new bool();

        for (int i=0; i < m_ArrayofPartsTransform.Length;i++)
        {

            if ((i == 3) || (i == 5) || (i == 9) || (i == 11) || (i == 13))
            {
                m_ArrayofPartsTransform[i].localScale = m_ArrayofPartsTransform[i - 1].localScale;
            }

            else
            {
                for (int j = 0; j <= 3; j++)
                {
                    if ((isvaleurx == false) && (isvaleury == false) && (isvaleurz == false))
                    {
                        valeurx = m_ArrayofCharacteristics[i + j];

                        if (valeurx <= 0)
                            valeurx = 1;

                        isvaleurx = true;
                    }

                    else if ((isvaleurx == true) && (isvaleury == false) && (isvaleurz == false))
                    {
                        valeury = m_ArrayofCharacteristics[i + j];

                        if (valeury <= 0)
                            valeury = 1;

                        isvaleury = true;
                    }

                    else if ((isvaleurx == true) && (isvaleury == true) && (isvaleurz == false))
                    {
                        valeurz = m_ArrayofCharacteristics[i + j];

                        if (valeurz <= 0)
                            valeurz = 1;

                        isvaleurz = true;
                    }

                }

                m_ArrayofPartsTransform[i].localScale = new Vector3((m_ArrayofPartsTransform[i].localScale.x*valeurx), m_ArrayofPartsTransform[i].localScale.y*valeury, m_ArrayofPartsTransform[i].localScale.z*valeurz);

            }
            
            isvaleurx = false;
            isvaleury = false;
            isvaleurz = false;
        }
    }
}
