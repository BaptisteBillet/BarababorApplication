using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptCaptainPartsShapeModification : MonoBehaviour
{
    Slider m_Slider;

    string m_Type;

    string m_Characteristic;

    bool m_DoubleChange;

    Transform m_ParttoChange1;
    Transform m_ParttoChange2;


   public void ModificationLauncher1 (Slider slider)
    {
        m_Slider = slider;
    }

    public void ModificationLauncher2(string type)
    {
        m_Type = type;
        if ((type == "Eyes") || (type == "Eyes") || (type == "Arms") || (type == "Legs") || (type == "Feet"))
        {
            m_DoubleChange = true;
        }
    }

    public void ModificationLauncher3 (string characteristic)
    {
        m_Characteristic = characteristic;
    }

    public void Modification ()
    {

    }

}
/*public ScriptGeneralCaptainCustomizationPanel m_SuperiorScript;


   public GameObject m_CaptainHead;
   ScriptCaptainHead m_ScriptCaptainHead;

   Transform[] m_ArrayofHeadTransform = new Transform[7];

   public Transform[] m_ArrayofBodyTransform = new Transform[7];

   [HideInInspector]
   public float[,] m_ArrayofHeadCharacteristics = new float[5,3];


   [HideInInspector]
   public float[,] m_ArrayofBodyCharacteristics = new float[4, 3];

   public Slider[] m_ArrayofSliderHead = new Slider[15];

   public Slider[] m_ArrayofSliderBody = new Slider[12];

   int m_PanelNumber = 1;

   Slider m_Slider;
   string m_Type;
   int m_IndexSup;
   int m_IndexInf;

   // Use this for initialization
   void Start ()
   {

       m_ScriptCaptainHead = m_CaptainHead.GetComponent<ScriptCaptainHead>();

       for(int i=0;i<m_ArrayofHeadTransform.Length;i++)
       {
           m_ArrayofHeadTransform[i] = m_ScriptCaptainHead.m_HeadParts[i].transform;

       }



       m_SuperiorScript.CaptainScale(m_PanelNumber);
   }

   public void ModificationLauncher1 (Slider slider)
   {
       m_Slider = slider;
   }

   public void ModificationLauncher2 (string type)
   {
       m_Type = type;
   }

   public void ModificationLauncher3 (int indexsup)
   {
       m_IndexSup = indexsup;
   }

   public void ModificationLauncher4 (int indexinf)
   {
       m_IndexInf = indexinf;

       if (m_Type=="Body")
       {
           Modification(m_Slider, m_ArrayofBodyCharacteristics);
       }

       else if (m_Type == "Head")
       {
           Modification(m_Slider,m_ArrayofHeadCharacteristics);
       }


   }

   public void Modification (Slider slider, float[,] Array)
   {
      Array[m_IndexSup, m_IndexInf] = slider.value;
   }



   public void Save()
   {

   }

   public void SliderValueAttribution (Slider[] SliderArray, float [,]ValueArray)
   {
       int dataNumber=SliderArray.Length;

       while(dataNumber>0)
       {
           for (int i =0;i<=ValueArray.GetLength(0);i++)
           {
               for (int j =0; j<=ValueArray.GetLength(1);j++)
               {
                   SliderArray[dataNumber].value = ValueArray[i, j];
                   dataNumber--; 
               }

           } 
       }

   }


   */
