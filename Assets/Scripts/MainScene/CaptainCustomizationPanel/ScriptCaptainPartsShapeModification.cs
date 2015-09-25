using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptCaptainPartsShapeModification : MonoBehaviour
{
    Slider m_Slider;

    public ScriptGeneralCaptainCustomizationPanel m_SuperiorScript;

    int m_PanelNumber = 1;

    bool m_DoubleChange;

    Transform m_ParttoChange1;
    Transform m_ParttoChange2;

    public Vector3 m_Transformation;

    public Transform[] m_ArrayofHeadTransform = new Transform[7];

    public Transform[] m_ArrayofBodyTransform = new Transform[7];


    void Start()
    {
        
        m_SuperiorScript.CaptainScale(m_PanelNumber);
    }

    public void GiveSlider (Slider slider)
    {
        m_Slider = slider;
    }

    public void GiveType(string type)
    {
      
        if ((type == "Eyes") || (type == "Ears") || (type == "Arms") || (type == "Legs") || (type == "Feet"))
        {
            m_DoubleChange = true;
        }

        else
        {
            m_DoubleChange = false;
        }

        switch (type)
        {
            case "Head":
                m_ParttoChange1 = m_ArrayofHeadTransform[0];
                m_ParttoChange2 = null;
                break;

            case "Nose":
                m_ParttoChange1 = m_ArrayofHeadTransform[1];
                m_ParttoChange2 = null;
                break;

            case "Ears":
                m_ParttoChange1 = m_ArrayofHeadTransform[2];
                m_ParttoChange2 = m_ArrayofHeadTransform[3];
                break;

            case "Eyes":
                m_ParttoChange1 = m_ArrayofHeadTransform[4];
                m_ParttoChange2 = m_ArrayofHeadTransform[5];
                break;

            case "Mouth":
                m_ParttoChange1 = m_ArrayofHeadTransform[6];
                m_ParttoChange2 = null;
                break;

            case "Body":
                m_ParttoChange1 = m_ArrayofBodyTransform[0];
                m_ParttoChange2 = null;
                break;

            case "Legs":
                m_ParttoChange1 = m_ArrayofBodyTransform[1];
                m_ParttoChange2 = m_ArrayofBodyTransform[2];
                break;

            case "Feet":
                m_ParttoChange1 = m_ArrayofBodyTransform[3];
                m_ParttoChange2 = m_ArrayofBodyTransform[4];
                break;

            case "Arms":
                m_ParttoChange1 = m_ArrayofBodyTransform[5];
                m_ParttoChange2 = m_ArrayofBodyTransform[6];
                break;

        }
    }

    public void GiveCharacteristic (string characteristic)
    {
       

        switch (characteristic)
        {
            case "Length":
                m_Transformation = new Vector3(m_ParttoChange1.localScale.x, m_Slider.value, m_ParttoChange1.localScale.z);
                break;

            case "Width":
                m_Transformation = new Vector3(m_Slider.value, m_ParttoChange1.localScale.y, m_ParttoChange1.localScale.z);
                break;

            case "Depth":
                m_Transformation = new Vector3(m_ParttoChange1.localScale.x, m_ParttoChange1.localScale.y, m_Slider.value);
                break;

        }

        Modification();
    }

    public void Modification ()
    {
        m_ParttoChange1.localScale = m_Transformation;

        if (m_DoubleChange == true)
        {
            if (m_ParttoChange2!=null)
            {
                m_ParttoChange2.localScale = m_Transformation;
            }
        }

    }



}
