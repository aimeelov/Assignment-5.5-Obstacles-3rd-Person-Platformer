using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Controls")]

    [Tooltip("This acis around which the gameObject is rotating")]
    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;

    [Tooltip("The speed with which the gameObject is rotating. Measured in degrees/frame")]
    [SerializeField]
    private float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
	{
    	transform.Rotate (0,25*Time.deltaTime,0); //rotates 50 degrees per second around z axis
	}
}

