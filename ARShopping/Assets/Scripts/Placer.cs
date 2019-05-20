﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

public class Placer : MonoBehaviour

{
    ARSessionOrigin arSessionOrigin;
    List<ARRaycastHit> raycast_hits = new List<ARRaycastHit>();
    public GameObject PortalPrefab;
    private GameObject spawnedPortal;

    private void Awake()
    {
        arSessionOrigin = GetComponent<ARSessionOrigin>();

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (arSessionOrigin.Raycast(touch.position, raycast_hits, TrackableType.PlaneWithinPolygon))
            {
                Pose pose = raycast_hits[0].pose;
                if (spawnedPortal == null)
                {
                    spawnedPortal = Instantiate(PortalPrefab, pose.position, Quaternion.Euler(0, 0, 0));
                    var rotationOfPortal = spawnedPortal.transform.rotation.eulerAngles;
                    spawnedPortal.transform.eulerAngles = new Vector3(rotationOfPortal.x, Camera.main.transform.rotation.eulerAngles.y, rotationOfPortal.z);
                }
                else
                {
                    spawnedPortal.transform.position = pose.position;
                    var rotationOfPortal = spawnedPortal.transform.rotation.eulerAngles;
                    spawnedPortal.transform.eulerAngles = new Vector3(rotationOfPortal.x, Camera.main.transform.rotation.eulerAngles.y, rotationOfPortal.z);
                }

            }
        }

    }
}