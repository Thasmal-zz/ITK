// Smooth towards the target
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smooth : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camera;
    
    void Start()
    {
        camera = GameObject.Find("Main Camera");
        head = camera.GetComponent<StereoComtroller>;
        Transform tf = GetComponent<Transform>();
        privateVector3 offset;
    }
    
    void Update()
    {
        transform.rotation = camera.transform.rotation;
      //  Debug.Log(transform.rotation);
        Debug.Log(camera.transform.rotation);
    }
}

/*
public class ExampleClass : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
} 
*/