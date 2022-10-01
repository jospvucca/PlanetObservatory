using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickLookAtTarget : MonoBehaviour
{
    public GameObject _cameraMain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            _cameraMain.GetComponent<LookAtTarget>()._planetToLookAt = null;
        }
    }

    void OnMouseDown()
    {
        _cameraMain.GetComponent<LookAtTarget>()._planetToLookAt = gameObject;
        if(name == "Sun")
        {
            _cameraMain.GetComponent<Camera>().fieldOfView = 90;
        }
        if(name == "Earth")
        {
            _cameraMain.GetComponent<Camera>().fieldOfView = 45;
        }
        if(name == "Moon")
        {
            _cameraMain.GetComponent<Camera>().fieldOfView = 30;
        }
    }
}
