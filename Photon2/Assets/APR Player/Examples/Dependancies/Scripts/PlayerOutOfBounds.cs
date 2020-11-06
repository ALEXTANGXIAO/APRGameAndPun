using System.Collections;
using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--Player Out Of Bounds
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------


public class PlayerOutOfBounds : MonoBehaviour
{
    //Player container
    public GameObject APR_Player;
    
    //Player APR Root
    public GameObject APR_Root;
    
    //Reset point, empty game object
    public Transform resetPoint;
    
    //Instant camera reset or lerp from last seen
    public bool instantCameraUpdate = false;
    
    //Main Camera
    private Camera cam;
    
    //Check trigger once
    private bool checkedTrigger;
    
    //Player Rigidbodies
    private Rigidbody[] PlayerPhysics;
    
    //Rigidbody stored velocity
    private Vector3 storedVelocity;
    
    
    void Awake()
    {
        cam = Camera.main;
    }
    
    
    void OnTriggerEnter(Collider col)
    {
        if(!checkedTrigger)
        {
            if(col.gameObject.layer == LayerMask.NameToLayer(APR_Player.GetComponent<APRController>().thisPlayerLayer))
            {
                checkedTrigger = true;
                
                if(APR_Player != null)
                {
                    PlayerPhysics = APR_Player.GetComponentsInChildren<Rigidbody>();
                    
                    //Deactivate physics and store velocity
                    foreach (Rigidbody physics in PlayerPhysics)
                    {
                        storedVelocity = physics.velocity;
                        physics.isKinematic = true;
                    }
                    
                    //Record camera current offset
                    var cameraOffset = new Vector3(cam.transform.position.x - APR_Root.transform.position.x, cam.transform.position.y - APR_Root.transform.position.y, cam.transform.position.z - APR_Root.transform.position.z);
                    
                    
                    //Set player to new position
                    APR_Root.transform.localPosition = Vector3.zero;
                    APR_Player.transform.position = resetPoint.position;
                    
                    //Re-activate physics and apply stored velocity
                    foreach (Rigidbody physics in PlayerPhysics)
                    {
                        physics.isKinematic = false;
                        physics.velocity = storedVelocity;
                    }
                    
                    
                    //Apply camera offset to new position
                    if(instantCameraUpdate)
                    {
                        cam.transform.position = APR_Root.transform.position + cameraOffset;
                    }
                }
                
                checkedTrigger = false;
            }
        }
    }
}
