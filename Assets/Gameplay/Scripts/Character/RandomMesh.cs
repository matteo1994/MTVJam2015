using UnityEngine;
using System.Collections;

public class RandomMesh : MonoBehaviour {

    public Mesh[] meshes;

    void Awake()
    {
        this.GetComponentInChildren<MeshFilter>().sharedMesh = meshes[Random.Range(0, meshes.Length)];
    }

}
