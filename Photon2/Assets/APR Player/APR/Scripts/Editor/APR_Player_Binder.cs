using UnityEngine;
using UnityEditor;


    //-------------------------------------------------------------
    //--APR Player
    //--Editor - Player Binder
    //
    //--Unity Asset Store - Version 1.0
    //
    //--By The Famous Mouse
    //
    //--Twitter @FamousMouse_Dev
    //--Youtube TheFamouseMouse
    //-------------------------------------------------------------


public class APR_Player_Binder : EditorWindow
{
    
    //Editor window
    public Texture tex;
    private static APR_Player_Binder _instance;
    
	//Container
	private GameObject refContainer;
	private GameObject Container;
	
	//COMP
	private GameObject refCOMP;
	
	//Root
	private GameObject refRoot;
	private GameObject RootChildren;
	private GameObject Root;
	
	//Body
	private GameObject refBody;
	private GameObject BodyChildren;
	private GameObject Body;
	
	//Head
	private GameObject refHead;
	private GameObject HeadChildren;
	private GameObject Head;
	
	//UpperRightArm
	private GameObject refUpperRightArm;
	private GameObject UpperRightArmChildren;
	private GameObject UpperRightArm;
	
	//LowerRightArm
	private GameObject refLowerRightArm;
	private GameObject LowerRightArmChildren;
	private GameObject LowerRightArm;
    
    //RightHand
	private GameObject refRightHand;
	private GameObject RightHandChildren;
	private GameObject RightHand;
	
	//UpperLeftArm
	private GameObject refUpperLeftArm;
	private GameObject UpperLeftArmChildren;
	private GameObject UpperLeftArm;
	
	//LowerLeftArm
	private GameObject refLowerLeftArm;
	private GameObject LowerLeftArmChildren;
	private GameObject LowerLeftArm;
    
    //RightHand
	private GameObject refLeftHand;
	private GameObject LeftHandChildren;
	private GameObject LeftHand;
	
	//UpperRightLeg
	private GameObject refUpperRightLeg;
	private GameObject UpperRightLegChildren;
	private GameObject UpperRightLeg;
	
	//LowerRightLeg
	private GameObject refLowerRightLeg;
	private GameObject LowerRightLegChildren;
	private GameObject LowerRightLeg;
	
	//RightFoot
	private GameObject refRightFoot;
	private GameObject RightFootChildren;
	private GameObject RightFoot;
	
	//UpperLeftLeg
	private GameObject refUpperLeftLeg;
	private GameObject UpperLeftLegChildren;
	private GameObject UpperLeftLeg;
	
	//LowerLeftLeg
	private GameObject refLowerLeftLeg;
	private GameObject LowerLeftLegChildren;
	private GameObject LowerLeftLeg;
	
	//LeftFoot
	private GameObject refLeftFoot;
	private GameObject LeftFootChildren;
	private GameObject LeftFoot;
	
    [MenuItem("APR Player/APR Player Binder")]
    static void APRPlayerBinderWindow()
    {
        if(_instance == null)
        {
            APR_Player_Binder window = ScriptableObject.CreateInstance(typeof(APR_Player_Binder)) as APR_Player_Binder;
            window.maxSize = new Vector2(350f, 640f);
            window.minSize = window.maxSize;
            window.ShowUtility();
        }
    }
    
    void OnEnable()
    {
        _instance = this;
    }
    
	
	void TutorialLink()
	{
		Help.BrowseURL("https://www.youtube.com/watch?v=FRGplDfQgLE");
	}
	
	void OnGUI()
	{
		GUI.skin.label.wordWrap = true;
        GUILayout.ExpandWidth (false);
		
        EditorGUILayout.Space();
        GUILayout.Label(tex);
		
		EditorGUILayout.Space();
		GUILayout.Label("Import the APR_Player into the scene, align and scale it to fit your model, then link the respective bones of your model below");
        
        EditorGUILayout.Space();
		GUILayout.Label("Note: The APR_Player box model will represent your colliders as well");
		
		EditorGUILayout.Space();
		GUILayout.Label("Here is a tutorial video link of this process:");
		if(GUILayout.Button("Watch Tutorial Video"))
		{
			TutorialLink();
		}
		
		
		
		//New Model fields
		EditorGUILayout.Space();
        EditorGUILayout.Space();
		
		//Container
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Model Container");
		Container = (GameObject)EditorGUILayout.ObjectField(Container, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//Root
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Root Bone");
		Root = (GameObject)EditorGUILayout.ObjectField(Root, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//body
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Body Bone");
		Body = (GameObject)EditorGUILayout.ObjectField(Body, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//Head
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Head Bone");
		Head = (GameObject)EditorGUILayout.ObjectField(Head, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//UpperRightArm
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Upper Right Arm Bone");
		UpperRightArm = (GameObject)EditorGUILayout.ObjectField(UpperRightArm, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//LowerRightArm
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Lower Right Arm Bone");
		LowerRightArm = (GameObject)EditorGUILayout.ObjectField(LowerRightArm, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
        //RightHand
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Right Hand Bone");
		RightHand = (GameObject)EditorGUILayout.ObjectField(RightHand, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//UpperLeftArm
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Upper Left Arm Bone");
		UpperLeftArm = (GameObject)EditorGUILayout.ObjectField(UpperLeftArm, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//LowerLeftArm
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Lower Left Arm Bone");
		LowerLeftArm = (GameObject)EditorGUILayout.ObjectField(LowerLeftArm, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
        //LeftHand
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Left Hand Bone");
		LeftHand = (GameObject)EditorGUILayout.ObjectField(LeftHand, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//UpperRightLeg
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Upper Right Leg Bone");
		UpperRightLeg = (GameObject)EditorGUILayout.ObjectField(UpperRightLeg, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//LowerRightLeg
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Lower Right Leg Bone");
		LowerRightLeg = (GameObject)EditorGUILayout.ObjectField(LowerRightLeg, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//RightFoot
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Right Foot Bone");
		RightFoot = (GameObject)EditorGUILayout.ObjectField(RightFoot, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//UpperLeftLeg
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Upper Left Leg Bone");
		UpperLeftLeg = (GameObject)EditorGUILayout.ObjectField(UpperLeftLeg, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//LowerLeftLeg
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Lower Left Leg Bone");
		LowerLeftLeg = (GameObject)EditorGUILayout.ObjectField(LowerLeftLeg, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		//LeftFoot
		EditorGUILayout.BeginHorizontal();
		GUILayout.Label("Left Foot Bone");
		LeftFoot = (GameObject)EditorGUILayout.ObjectField(LeftFoot, typeof(GameObject), true, GUILayout.Width(180));
		EditorGUILayout.EndHorizontal();
		
		//Button
		EditorGUILayout.Space();
		EditorGUILayout.Space();
		
		if(GUILayout.Button("Bind Active Physics Ragdoll Player"))
		{
			BindRagdoll();
		}
	}
	
	void BindRagdoll()
	{
		//Find active physics ragdoll player
        refContainer = GameObject.Find("APR_Player");
        
        if(PrefabUtility.GetPrefabInstanceStatus(refContainer) != PrefabInstanceStatus.NotAPrefab)
        {
            PrefabUtility.UnpackPrefabInstance(refContainer, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);
        }
        
        if(PrefabUtility.GetPrefabInstanceStatus(Container) != PrefabInstanceStatus.NotAPrefab)
        {
            PrefabUtility.UnpackPrefabInstance(Container, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);
        }
        
		refRoot = GameObject.Find("APR_Root");
		refBody = GameObject.Find("APR_Body");
		refHead = GameObject.Find("APR_Head");
		refUpperRightArm = GameObject.Find("APR_UpperRightArm");
		refLowerRightArm = GameObject.Find("APR_LowerRightArm");
        refRightHand = GameObject.Find("APR_RightHand");
        refUpperLeftArm = GameObject.Find("APR_UpperLeftArm");
		refLowerLeftArm = GameObject.Find("APR_LowerLeftArm");
        refLeftHand = GameObject.Find("APR_LeftHand");
		refUpperRightLeg = GameObject.Find("APR_UpperRightLeg");
		refLowerRightLeg = GameObject.Find("APR_LowerRightLeg");
		refRightFoot = GameObject.Find("APR_RightFoot");
        refUpperLeftLeg = GameObject.Find("APR_UpperLeftLeg");
		refLowerLeftLeg = GameObject.Find("APR_LowerLeftLeg");
		refLeftFoot = GameObject.Find("APR_LeftFoot");
		refCOMP = GameObject.Find("APR_COMP");
		
		
		//Root
		RootChildren = Root.transform.gameObject;
		refRoot.transform.parent = Root.transform.parent;
		RootChildren.transform.parent = refRoot.transform;
		DestroyImmediate(refRoot.GetComponent<MeshRenderer>());
		DestroyImmediate(refRoot.GetComponent<MeshFilter>());
		
		//Body
		BodyChildren = Body.transform.gameObject;
		refBody.transform.parent = Body.transform.parent;
		BodyChildren.transform.parent = refBody.transform;
		DestroyImmediate(refBody.GetComponent<MeshRenderer>());
		DestroyImmediate(refBody.GetComponent<MeshFilter>());
		
		//Head
		HeadChildren = Head.transform.gameObject;
		refHead.transform.parent = Head.transform.parent;
		HeadChildren.transform.parent = refHead.transform;
		DestroyImmediate(refHead.GetComponent<MeshRenderer>());
		DestroyImmediate(refHead.GetComponent<MeshFilter>());
		
		//UpperRightArm
		UpperRightArmChildren = UpperRightArm.transform.gameObject;
		refUpperRightArm.transform.parent = UpperRightArm.transform.parent;
		UpperRightArmChildren.transform.parent = refUpperRightArm.transform;
		DestroyImmediate(refUpperRightArm.GetComponent<MeshRenderer>());
		DestroyImmediate(refUpperRightArm.GetComponent<MeshFilter>());
		
		//LowerRightArm
		LowerRightArmChildren = LowerRightArm.transform.gameObject;
		refLowerRightArm.transform.parent = LowerRightArm.transform.parent;
		LowerRightArmChildren.transform.parent = refLowerRightArm.transform;
		DestroyImmediate(refLowerRightArm.GetComponent<MeshRenderer>());
		DestroyImmediate(refLowerRightArm.GetComponent<MeshFilter>());
        
        //RightHand
		RightHandChildren = RightHand.transform.gameObject;
		refRightHand.transform.parent = RightHand.transform.parent;
		RightHandChildren.transform.parent = refRightHand.transform;
		DestroyImmediate(refRightHand.GetComponent<MeshRenderer>());
		DestroyImmediate(refRightHand.GetComponent<MeshFilter>());
		
		//UpperLeftArm
		UpperLeftArmChildren = UpperLeftArm.transform.gameObject;
		refUpperLeftArm.transform.parent = UpperLeftArm.transform.parent;
		UpperLeftArmChildren.transform.parent = refUpperLeftArm.transform;
		DestroyImmediate(refUpperLeftArm.GetComponent<MeshRenderer>());
		DestroyImmediate(refUpperLeftArm.GetComponent<MeshFilter>());
		
		//LowerLeftArm
		LowerLeftArmChildren = LowerLeftArm.transform.gameObject;
		refLowerLeftArm.transform.parent = LowerLeftArm.transform.parent;
		LowerLeftArmChildren.transform.parent = refLowerLeftArm.transform;
		DestroyImmediate(refLowerLeftArm.GetComponent<MeshRenderer>());
		DestroyImmediate(refLowerLeftArm.GetComponent<MeshFilter>());
        
        //LeftHand
		LeftHandChildren = LeftHand.transform.gameObject;
		refLeftHand.transform.parent = LeftHand.transform.parent;
		LeftHandChildren.transform.parent = refLeftHand.transform;
		DestroyImmediate(refLeftHand.GetComponent<MeshRenderer>());
		DestroyImmediate(refLeftHand.GetComponent<MeshFilter>());
		
		//UpperRightLeg
		UpperRightLegChildren = UpperRightLeg.transform.gameObject;
		refUpperRightLeg.transform.parent = UpperRightLeg.transform.parent;
		UpperRightLegChildren.transform.parent = refUpperRightLeg.transform;
		DestroyImmediate(refUpperRightLeg.GetComponent<MeshRenderer>());
		DestroyImmediate(refUpperRightLeg.GetComponent<MeshFilter>());
		
		//LowerRightLeg
		LowerRightLegChildren = LowerRightLeg.transform.gameObject;
		refLowerRightLeg.transform.parent = LowerRightLeg.transform.parent;
		LowerRightLegChildren.transform.parent = refLowerRightLeg.transform;
		DestroyImmediate(refLowerRightLeg.GetComponent<MeshRenderer>());
		DestroyImmediate(refLowerRightLeg.GetComponent<MeshFilter>());
		
		//RightFoot
		RightFootChildren = RightFoot.transform.gameObject;
		refRightFoot.transform.parent = RightFoot.transform.parent;
		RightFootChildren.transform.parent = refRightFoot.transform;
		DestroyImmediate(refRightFoot.GetComponent<MeshRenderer>());
		DestroyImmediate(refRightFoot.GetComponent<MeshFilter>());
		
		//UpperLeftLeg
		UpperLeftLegChildren = UpperLeftLeg.transform.gameObject;
		refUpperLeftLeg.transform.parent = UpperLeftLeg.transform.parent;
		UpperLeftLegChildren.transform.parent = refUpperLeftLeg.transform;
		DestroyImmediate(refUpperLeftLeg.GetComponent<MeshRenderer>());
		DestroyImmediate(refUpperLeftLeg.GetComponent<MeshFilter>());
		
		//LowerLeftLeg
		LowerLeftLegChildren = LowerLeftLeg.transform.gameObject;
		refLowerLeftLeg.transform.parent = LowerLeftLeg.transform.parent;
		LowerLeftLegChildren.transform.parent = refLowerLeftLeg.transform;
		DestroyImmediate(refLowerLeftLeg.GetComponent<MeshRenderer>());
		DestroyImmediate(refLowerLeftLeg.GetComponent<MeshFilter>());
		
		//LeftFoot
		LeftFootChildren = LeftFoot.transform.gameObject;
		refLeftFoot.transform.parent = LeftFoot.transform.parent;
		LeftFootChildren.transform.parent = refLeftFoot.transform;
		DestroyImmediate(refLeftFoot.GetComponent<MeshRenderer>());
		DestroyImmediate(refLeftFoot.GetComponent<MeshFilter>());
		
		//COMP
		refCOMP.transform.parent = Root.transform.root;
		
		//Container
		Container.transform.parent = refContainer.transform;
		
		Debug.Log("APR_Player has been binded");
        
        this.Close();
	}
    
    void OnDisable()
    {
        _instance = null;
    }
}
