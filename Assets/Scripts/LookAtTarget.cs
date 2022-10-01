using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    //triba bit null na pocetku
    public GameObject _planetToLookAt = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_planetToLookAt == null)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            gameObject.GetComponent<Camera>().fieldOfView = 60;
        }
        else
        {
            transform.LookAt(_planetToLookAt.transform);
        }
    }
}

  
