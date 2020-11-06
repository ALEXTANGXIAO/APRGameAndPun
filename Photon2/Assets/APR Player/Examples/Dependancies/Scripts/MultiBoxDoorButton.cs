using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--MultiBoxDoorButton
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------



public class MultiBoxDoorButton : MonoBehaviour
{
    public MultiBoxButton[] buttons;
    public Animator[] door;
    
    [HideInInspector]
    public int pressedButtons;
    private bool open;
    
    
    void Update()
    {
        if(!open && pressedButtons == buttons.Length)
        {
            open = true;
        }
        
        else if(open && pressedButtons != buttons.Length)
        {
            open = false;
        }
        
        if(open)
        {
            foreach(Animator anim in door)
            {
                if(!anim.GetBool("open"))
                {
                    anim.SetBool("open", true);
                }
            }
        }

        if(!open)
        {
            foreach(Animator anim in door)
            {
                if(anim.GetBool("open"))
                {
                    anim.SetBool("open", false);
                }
            }
        }
        
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

