using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--Feet Contact
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------


public class FeetContact : MonoBehaviour
{
	public APRController APR_Player;
	
    //Alert APR player when feet colliders enter ground object layer
    void OnCollisionEnter(Collision col)
	{
        if(!APR_Player.isJumping && APR_Player.inAir)
        {
            if(col.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                APR_Player.PlayerLanded();
            }
        }
	}
}
