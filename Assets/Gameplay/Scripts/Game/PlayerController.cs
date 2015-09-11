using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject[] spawnablePlayers;

    private GameObject currentPlayerGo;

    public void SpawnNewPlayer()
    {
        var playerPrefab = ChoosePlayer();
        currentPlayerGo = Spawn(playerPrefab, this.transform.position);
    }

    GameObject Spawn(GameObject spawnPrefab, Vector3 pos)
    {
        GameObject go = Instantiate(spawnPrefab, pos, Quaternion.identity) as GameObject;
        return go;
    }

    public void Clear()
    {
        Destroy(this.currentPlayerGo);
    }

    GameObject ChoosePlayer()
    {
        return spawnablePlayers[Random.Range(0, spawnablePlayers.Length)];
    }

}
