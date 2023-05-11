using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charAimming : MonoBehaviour
{
    public float turnSpeed = 30;
    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yawCamera = mainCamera.transform.rotation.eulerAngles.y;
        Debug.Log(mainCamera.transform.rotation.eulerAngles);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);

        
    }
}
