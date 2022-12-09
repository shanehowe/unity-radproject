using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] Transform cameraHolder;
    float verticalLookRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move screen on x and y axis with mouse
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X"));
        verticalLookRotation -= Input.GetAxisRaw("Mouse Y");
        
        // Stop camera from doing full 360
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0, 0);
    }
}
