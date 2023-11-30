using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Vector3 playerSpawnPoint;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void SetCheckpoint(CheckPoint checkpoint)
    {
        playerSpawnPoint = checkpoint.checkPointPosition;
    }

    public void RespawnPlayer(GameObject player)
    {
        player.transform.position = playerSpawnPoint;
    }
}
