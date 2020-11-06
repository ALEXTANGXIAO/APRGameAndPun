using UnityEngine;
using Photon.Pun;
using UnityStandardAssets.CrossPlatformInput;

//-------------------------------------------------------------
//--APR Player
//--Camera Controller
//
//--Unity Asset Store - Version 1.0
//
//--By The Famous Mouse
//
//--Twitter @FamousMouse_Dev
//--Youtube TheFamouseMouse
//-------------------------------------------------------------


public class CameraController : MonoBehaviourPun
{
    [Header("Player To Follow")]
    //Player root
    public Transform APRRoot;
    
    [Header("Follow Properties")]
    //Follow values
    public float distance = 10.0f; //The distance is only used when "rotateCamera" is enabled, when disabled the camera offset is used
    public float smoothness = 0.15f;
    
    [Header("Rotation Properties")]
    //Rotate with input
    public bool rotateCamera = true;
    public float rotateSpeed = 5.0f;
    
    //Min & max camera angle
    public float minAngle = -45.0f;
    public float maxAngle = -10.0f;
    
    
    //Private variables
    private Camera cam;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private Quaternion rotation;
    private Vector3 dir;
    private Vector3 offset;


    //Lock and hide cursor
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        
        cam = Camera.main;
        
        offset = cam.transform.position;
    }


    //Camera mouse input and (clamping for rotation)
    void Update()
    {
        currentX = currentX + CrossPlatformInputManager.GetAxis("Mouse X") * rotateSpeed;
        currentY = currentY + CrossPlatformInputManager.GetAxis("Mouse Y") * rotateSpeed;

        currentY = Mathf.Clamp(currentY, minAngle, maxAngle);
    }
    
    
    //Camera follow and rotation
    void FixedUpdate()
    {
        if(rotateCamera)
        {
            dir = new Vector3(0, 0, -distance);
            rotation = Quaternion.Euler(-currentY, currentX, 0);
            cam.transform.position = Vector3.Lerp (cam.transform.position, APRRoot.position + rotation * dir, smoothness);
            cam.transform.LookAt(APRRoot.position);
        }
        
        if(!rotateCamera)
        {
            var targetRotation = Quaternion.LookRotation(APRRoot.position - cam.transform.position);
            cam.transform.position = Vector3.Lerp (cam.transform.position, APRRoot.position + offset, smoothness);
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, targetRotation, smoothness);
        }
    }

}
