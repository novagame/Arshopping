using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;


public class PlaneController : MonoBehaviour
{
    ARPlaneManager m_ar;
    List<ARPlane> existingPlanes = new List<ARPlane>();
    public Text buttonText;

    // Start is called before the first frame update
    private void Awake()
    {
        m_ar = GetComponent<ARPlaneManager>();
    }
    void Start()
    {
        
    }
    public void TogglePlaneDetectionAndVisibility()
    {
        m_ar.enabled = !m_ar.enabled;
        if (m_ar.enabled)
        {
            SetAllPlanesActiveOrDeactive(true);
            buttonText.text = "Rotate / Resize ";
        }
        else
        {
            SetAllPlanesActiveOrDeactive(false);
            buttonText.text = "Move";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetAllPlanesActiveOrDeactive(bool value)
    {
        m_ar.GetAllPlanes(existingPlanes);
        foreach(var plane in existingPlanes)
        {
            plane.gameObject.SetActive(value);
        }


    }
}
