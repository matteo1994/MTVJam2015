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

    public float waveDuration = 5f;
    public float wavePause = 2f;

    public float introPause = 3f;


    public float timeScaleIncrease = 0.1f;

    void Start () {
        waveSpawner = GetComponentInChildren<WaveSpawner>();
        playerController = GetComponentInChildren<PlayerController>();

        Invoke("RespawnPlayers", introPause);
        Invoke("NewWave", introPause + wavePause);
    }

    void Update()
    {
        Time.timeScale += timeScaleIncrease * Time.deltaTime;
       // Debug.Log(Time.timeScale);
    }
	
    void RespawnPlayers()
    {
        playerController.Clear();
        playerController.SpawnNewPlayers();
    }

	void NewWave()
    {
        waveSpawner.Clear();
        waveSpawner.SpawnWave();
        Invoke("ClearWave", waveDuration);
        Invoke("NewWave", waveDuration + wavePause);
    }

    void ClearWave()
    {
        waveSpawner.Clear();
    }
}
