using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

    public PLCursor plCursor1;
    public PLCursor plCursor2;

    public GameObject[] spawnablePlayers;

    public List<AbstractCharacter> currentPlayers = new List<AbstractCharacter>();

    public void SpawnNewPlayers()
    {
        SpawnNewPlayer(0);
        SpawnNewPlayer(1);
    }

    public void SpawnNewPlayer(int playerId) { 
        var playerPrefab = ChoosePlayer();
        var playerGo = Spawn(playerPrefab, this.transform.position);
        playerGo.GetComponent<AbstractCharacter>().SetPlayer(playerId);
        currentPlayers.Add(playerGo.GetComponent<AbstractCharacter>());

        if (playerId == 0)
            plCursor1.targetTr = playerGo.transform;
        else
            plCursor2.targetTr = playerGo.transform;

        Debug.Log("SPAWNED PLAYER " + playerId + " " + playerGo.name);
    }


    GameObject Spawn(GameObject spawnPrefab, Vector3 pos)
    {
        GameObject go = Instantiate(spawnPrefab, pos, Quaternion.identity) as GameObject;
        return go;
    }

    public void Clear()
    {
        foreach(var c in currentPlayers)
            Destroy(c.gameObject);
        currentPlayers.Clear();
    }

    GameObject ChoosePlayer()
    {
        return spawnablePlayers[Random.Range(0, spawnablePlayers.Length)];
    }

}
