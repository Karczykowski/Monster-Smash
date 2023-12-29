using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float respawnDelay;
    private float respawnDelayConst;
    [SerializeField] private GameObject Enemy;
    private Transform playerLocation;
    private void Start()
    {
        respawnDelayConst = respawnDelay;
        playerLocation = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        if (playerLocation != null)

        {
            if (respawnDelay > 0)
            {
                respawnDelay -= Time.deltaTime;
            }
            else
            {
                Instantiate(Enemy, transform.position, Quaternion.identity);
                respawnDelay = respawnDelayConst;
            }
        }
    }
}
