﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 2f);
    }
    public void SpawnEnemy()
    {
        Instantiate(enemy, transform);
    }
}
