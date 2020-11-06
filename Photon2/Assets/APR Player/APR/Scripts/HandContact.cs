using System.Collections;
using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--Hand Contact
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------


public class HandContact : MonoBehaviour
{
    public APRController APR_Player;
    
    //Is left or right hand
	public bool Left;
    
    //Have joint/grabbed
	public bool hasJoint;
	

    void Update()
    {
        if(APR_Player.useControls)
        {
            //Left Hand
            //On input release destroy joint
            if(Left)
            {
                if(hasJoint && Input.GetAxisRaw(APR_Player.reachLeft) == 0)
                {
                    this.gameObject.GetComponent<FixedJoint>().breakForce = 0;
                    hasJoint = false;
                }

                if(hasJoint && this.gameObject.GetComponent<FixedJoint>() == null)
                {
                    hasJoint = false;
                }
            }

            //Right Hand
            //On input release destroy joint
            if(!Left)
            {
                if(hasJoint && Input.GetAxisRaw(APR_Player.reachRight) == 0)
                {
                    this.gameObject.GetComponent<FixedJoint>().breakForce = 0;
                    hasJoint = false;
                }

                if(hasJoint && this.gameObject.GetComponent<FixedJoint>() == null)
                {
                    hasJoint = false;
                }
            }
        }
    }

    //Grab on collision when input is used
    void OnCollisionEnter(Collision col)
    {
        if(APR_Player.useControls)
        {
            //Left Hand
            if(Left)
            {
                if(col.gameObject.tag == "CanBeGrabbed" && col.gameObject.layer != LayerMask.NameToLayer(APR_Player.thisPlayerLayer) && !hasJoint)
                {
                    if(Input.GetAxisRaw(APR_Player.reachLeft) != 0 && !hasJoint && !APR_Player.punchingLeft)
                    {
                        hasJoint = true;
                        this.gameObject.AddComponent<FixedJoint>();
                        this.gameObject.GetComponent<FixedJoint>().breakForce = Mathf.Infinity;
                        this.gameObject.GetComponent<FixedJoint>().connectedBody = col.gameObject.GetComponent<Rigidbody>();
                    }
                }
                
            }

            //Right Hand
            if(!Left)
            {
                if(col.gameObject.tag == "CanBeGrabbed" && col.gameObject.layer != LayerMask.NameToLayer(APR_Player.thisPlayerLayer) && !hasJoint)
                {
                    if(Input.GetAxisRaw(APR_Player.reachRight) != 0 && !hasJoint && !APR_Player.punchingRight)
                    {
                        hasJoint = true;
                        this.gameObject.AddComponent<FixedJoint>();
                        this.gameObject.GetComponent<FixedJoint>().breakForce = Mathf.Infinity;
                        this.gameObject.GetComponent<FixedJoint>().connectedBody = col.gameObject.GetComponent<Rigidbody>();
                    }
                }
            }
        }
    }
}
