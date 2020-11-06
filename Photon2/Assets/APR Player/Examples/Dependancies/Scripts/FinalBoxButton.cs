using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--FinalBoxButton
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------


public class FinalBoxButton : MonoBehaviour
{
    public string CorrectBox = "finalbox";
    public GameObject billboard;
    
    private bool correct;
    
    
    void OnTriggerStay(Collider col)
    {
        if(!correct && col.gameObject.name == CorrectBox)
        {
            correct = true;
        }
    }
    
    void OnTriggerExit(Collider col)
    {
        if(correct && col.gameObject.name == CorrectBox)
        {
            correct = false;
        }
    }

    
    void Update()
    {
        if(correct)
        {
            billboard.SetActive(true);
        }
            
        else if(!correct)
        {
            billboard.SetActive(false);
        }
    }
}
