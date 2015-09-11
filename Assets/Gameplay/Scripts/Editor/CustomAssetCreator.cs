using UnityEngine;
using UnityEditor;
using System.Collections;
using Cat.Editor;

public class CustomAssetCreator : MonoBehaviour {

    void CreateWave () {
        CustomAssetUtility.CreateAsset<Wave>();
    }
	
}
