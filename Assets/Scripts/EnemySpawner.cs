using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject friend;
    public GameObject heart;
    public GameObject joker;

    float spawnIntervalRandomizer;
    float maxInterval = 5f;
    float minInterval = 1f;
    bool avaliableToBeBorn = true;

    bool isEnemyToBeBorn=false;
    bool isFriendToBeBorn=false;
    bool isHeartToBeBorn=false;
    bool isJokerToBeBorn=false;

    public float EnemySpawnProbability;
    public float FriendSpawnProbability;
    public float HeartSpawnProbability;
    public float JokerSpawnProbability;

    private void Update()
    {
        if (avaliableToBeBorn)
        {
            StartCoroutine(SpawnEnemyCoroutine());
        }
    }
    private float IntervalRandomizer()
    {
        spawnIntervalRandomizer = Random.Range(minInterval, maxInterval);
        return spawnIntervalRandomizer;
    }

    private IEnumerator SpawnEnemyCoroutine()
    {
        avaliableToBeBorn = false;
        BallTypeRandomizer();
        yield return new WaitForSeconds(IntervalRandomizer());
        if(isEnemyToBeBorn)
        {
            Instantiate(enemy, transform);
            isEnemyToBeBorn = false;
        }
        if (isFriendToBeBorn)
        {
            Instantiate(friend, transform);
            isFriendToBeBorn = false;
        }
        if (isHeartToBeBorn)
        {
            Instantiate(heart, transform);
            isHeartToBeBorn = false;
        }
        if (isJokerToBeBorn)
        {
            Instantiate(joker, transform);
            isJokerToBeBorn = false;
        }
        avaliableToBeBorn = true;
    }

    private void BallTypeRandomizer()
    {
        float randomizerFactor = Random.Range(0f, 100f);
        if(randomizerFactor<EnemySpawnProbability)
        {
            isEnemyToBeBorn = true;
        }
        else if(randomizerFactor<EnemySpawnProbability+FriendSpawnProbability)
        {
            isFriendToBeBorn = true;
        }
        else if(randomizerFactor < EnemySpawnProbability + FriendSpawnProbability+HeartSpawnProbability)
        {
            isHeartToBeBorn = true;
        }
        else
        {
            isJokerToBeBorn = true;
        }
    }
}
