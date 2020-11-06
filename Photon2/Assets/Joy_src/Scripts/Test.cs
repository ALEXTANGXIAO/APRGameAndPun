using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int id = 0;
    public Camera m_camera;

    public GameObject prefab;   
    private GameObject instance;
    // Start is called before the first frame update
    void Start()
    {
        //1. Application.targetFrameRate = 10; 

        //2. instance = Instantiate(prefab);
        //Destroy(instance, 10f);

        // 3. GameObject go = new GameObject("GameObjName");

        //4. GameObject prefab = Resources.Load<GameObject>("AC1");
        //instance = Instantiate(prefab);

       // GameObject player = Resources.Load<GameObject>("AC1");
        //instance = Instantiate(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
