using UnityEngine;
using System.Collections;

public enum GamePhase
{
    INTRO,
    PLAY,
    END
}

public class GameController : MonoBehaviour {

    public WaveSpawner waveSpawner;
    public PlayerController playerController;

    public float wavePeriod = 10f;

    void Start () {
        waveSpawner = GetComponentInChildren<WaveSpawner>();
        playerController = GetComponentInChildren<PlayerController>();
        NewWave();
    }
	
	void NewWave() {
        ClearScene();
        playerController.SpawnNewPlayers();
        waveSpawner.SpawnWave();
        Invoke("NewWave", wavePeriod);
    }

    void ClearScene()
    {
        playerController.Clear();
        waveSpawner.Clear();
    }
}
