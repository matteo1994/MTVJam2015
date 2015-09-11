using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveSpawner : MonoBehaviour {

    public Wave[] waves;

    List<GameObject> spawnedGos = new List<GameObject>();

    public void SpawnWave()
    {
        Wave wave = ChooseWave();
        foreach (var we in wave.waveGos)
            Spawn(we, new Vector3(Random.Range(-10f, 10f), 10));
    }

    void Spawn(GameObject spawnPrefab, Vector3 pos)
    {
        GameObject go = Instantiate(spawnPrefab, pos, Quaternion.identity) as GameObject;
        spawnedGos.Add(go);
    }

    void Clear()
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
