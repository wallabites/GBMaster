using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainTrigger : MonoBehaviour



{
    public GameObject SpawnerObject;
    public EnemySpawner ES;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SpawnerObject.SetActive(true);
            ES.StartCoroutine("SpawnEnemies");

        }
    }
}
