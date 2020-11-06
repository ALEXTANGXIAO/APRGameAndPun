using UnityEngine;


    //-------------------------------------------------------------
    //--APR Player
    //--Object Out Of Bounds
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------



public class ObjectOutOfBound : MonoBehaviour
{
    public Transform objResetPoint;
    private Rigidbody rb;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.layer != LayerMask.NameToLayer("Player_1"))
        {
            if(col.gameObject.GetComponent<Rigidbody>() != null)
            {
                rb = col.gameObject.GetComponent<Rigidbody>();
                rb.transform.position = objResetPoint.position;
            }
        }
    }
}
