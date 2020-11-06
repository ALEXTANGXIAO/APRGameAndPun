using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--SingleBoxDoorButton
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------



public class SingleBoxDoorButton : MonoBehaviour
{
    public Animator[] door;
    
    void OnTriggerStay(Collider col)
    {
        foreach(Animator anim in door)
        {
            if(!anim.GetBool("open"))
            {
                anim.SetBool("open", true);
            }
        }
    }
    
    void OnTriggerExit(Collider col)
    {
        foreach(Animator anim in door)
        {
            if(anim.GetBool("open"))
            {
                anim.SetBool("open", false);
            }
        }
    }
    
    void Update()
    {
        foreach(Animator anim in door)
        {
            if(anim.GetBool("open"))
            {
                if(anim.GetFloat("state") < 1)
                {
                    anim.SetFloat("state", anim.GetFloat("state") + 0.02f);
                }
            }
            
            else if(!anim.GetBool("open"))
            {
                if(anim.GetFloat("state") > 0)
                {
                    anim.SetFloat("state", anim.GetFloat("state") - 0.02f);
                }
            }
        }
    }
}
