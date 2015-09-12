using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveSpawner : MonoBehaviour {

    Wave[] waves;

    public GameObject wavesGO;

    List<GameObject> spawnedGos = new List<GameObject>();

    void Awake()
    {
        wavesGO.gameObject.SetActiveRecursively(true);
        waves = wavesGO.GetComponentsInChildren<Wave>();
        foreach (var w in waves)
            w.gameObject.SetActive(false);
    }

    public void SpawnWave()
    {
        Wave wave = ChooseWave();
        wave.gameObject.SetActive(true);
        foreach (Transform we in wave.GetComponentInChildren<Transform>())
            Spawn(we.gameObject, we.position, we.rotation);//, new Vector3(Random.Range(-10f, 10f), 10));
        wave.gameObject.SetActive(false);
    }

    void Spawn(GameObject spawnPrefab, Vector3 pos, Quaternion rot)
    {
        GameObject go = Instantiate(spawnPrefab, pos, rot) as GameObject;
        spawnedGos.Add(go);
    }

    public void Clear()
    {
        foreach (var go in spawnedGos)
            Destroy(go);
        spawnedGos.Clear();
    }

    Wave ChooseWave()
    {
        return waves[Random.Range(0, waves.Length)];
    }
}
