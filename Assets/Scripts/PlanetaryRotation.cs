using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryRotation : MonoBehaviour
{
    public float _rotationSpeed = 0.1f;
    public GameObject _parentPlanet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(_parentPlanet.transform.position, new Vector3(0, 1, 0), _rotationSpeed * Time.deltaTime);
    }
}
