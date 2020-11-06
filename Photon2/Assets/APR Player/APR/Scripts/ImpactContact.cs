using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--Impact Contact
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------


public class ImpactContact : MonoBehaviour
{
	public APRController APR_Player;
    
    //Alert APR Player when collision enters with specified force amount
	void OnCollisionEnter(Collision col)
	{
        
        //Knockout by impact
		if(APR_Player.canBeKnockoutByImpact && col.relativeVelocity.magnitude > APR_Player.requiredForceToBeKO)
		{
			APR_Player.ActivateRagdoll();
            
            if(APR_Player.SoundSource != null)
            {
                if(!APR_Player.SoundSource.isPlaying && APR_Player.Hits != null)
                {
                    int i = Random.Range(0, APR_Player.Hits.Length);
                    APR_Player.SoundSource.clip = APR_Player.Hits[i];
                    APR_Player.SoundSource.Play();
                }
            }
		}
        
        //Sound on impact
        if(col.relativeVelocity.magnitude > APR_Player.ImpactForce)
        {
            
            if(APR_Player.SoundSource != null)
            {
                if(!APR_Player.SoundSource.isPlaying && APR_Player.Impacts != null)
                {
                    int i = Random.Range(0, APR_Player.Impacts.Length);
                    APR_Player.SoundSource.clip = APR_Player.Impacts[i];
                    APR_Player.SoundSource.Play();
                }
            }
        }
	}
}
