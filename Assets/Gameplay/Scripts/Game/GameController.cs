using UnityEngine;
using System.Collections;

public enum GamePhase
{
    INTRO,
    PLAY,
    END
}

public class GameController : MonoBehaviour {

    public static GameController Instance;

    public void Awake()
    {
        Instance = this;
    }

    public WaveSpawner waveSpawner;
    public PlayerController playerController;

    public float waveDuration = 5f;
    public float wavePause = 2f;

    public float introPause = 3f;

    public float respawnDelay = 2.0f;

    public float startTimeScale = 1;


    public int pl1Life = 3;
    public int pl2Life = 3;


    public float timeScaleIncrease = 0.1f;

    void Start () {
        waveSpawner = GetComponentInChildren<WaveSpawner>();
        playerController = GetComponentInChildren<PlayerController>();
        Time.timeScale = startTimeScale;

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

    public void KillPlayer(int id)
    {
        if (id == 0)
        {
            pl1Life--;
            Debug.Log("PLAYER 0 LIFE " + pl1Life);
            Invoke("RespawnPlayer1", respawnDelay);
        }
        else
        {
            pl2Life--;
            Debug.Log("PLAYER 1 LIFE " + pl2Life);
            Invoke("RespawnPlayer2", respawnDelay);
        }
    }

    void RespawnPlayer1()
    {
        Debug.Log("RESPAWN PLAYER 0");
        playerController.SpawnNewPlayer(0);
    }
    void RespawnPlayer2()
    {
        Debug.Log("RESPAWN PLAYER 1");
        playerController.SpawnNewPlayer(1);
    }

    public Flash flash;
    void NewWave()
    {
        waveSpawner.Clear();
        flash.DoFlash();

        waveSpawner.SpawnWave();
        Invoke("ClearWave", waveDuration);
        Invoke("NewWave", waveDuration + wavePause);
    }

    void ClearWave()
    {
        waveSpawner.Clear();
    }
}
