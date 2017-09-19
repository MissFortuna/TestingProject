using System.Collections;
using UnityEngine;
using DragonBones;

public class TestAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Load Data	
        UnityFactory.factory.LoadDragonBonesData("testAnimation/Rabbit_ske");
        UnityFactory.factory.LoadTextureAtlasData("testAnimation/Rabbit_tex");
        //Create armature

        UnityArmatureComponent armatureComponent = UnityFactory.factory.BuildArmatureComponent("Armature");
       // UnityArmatureComponent armatureComponent = GetComponent<UnityArmatureComponent>;
        if (armatureComponent == null)
        {
            Debug.Log("BadNews");
        }
        armatureComponent.animation.Play("jump");
    
        armatureComponent.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
