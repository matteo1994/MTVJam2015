using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

    public GameObject[] spawnablePlayers;

    private List<GameObject> currentPlayerGos = new List<GameObject>();

    public void SpawnNewPlayers()
    {
        SpawnNewPlayer(0);
        SpawnNewPlayer(1);
    }

    public void SpawnNewPlayer(int playerId) { 
        var playerPrefab = ChoosePlayer();
        var playerGo = Spawn(playerPrefab, this.transform.position);
        playerGo.GetComponent<AbstractCharacter>().playerId = playerId;
        currentPlayerGos.Add(playerGo);
    }

    GameObject Spawn(GameObject spawnPrefab, Vector3 pos)
    {
        GameObject go = Instantiate(spawnPrefab, pos, Quaternion.identity) as GameObject;
        return go;
    }

    public void Clear()
    {
        foreach(var go in currentPlayerGos)
            Destroy(go);
        currentPlayerGos.Clear();
    }

    GameObject ChoosePlayer()
    {
        return spawnablePlayers[Random.Range(0, spawnablePlayers.Length)];
    }

}
