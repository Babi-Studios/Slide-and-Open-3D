using System.Collections;
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
        GameObject nextBall = BallTypeRandomizer();
        yield return new WaitForSeconds(IntervalRandomizer());
        Instantiate(nextBall, transform);
        avaliableToBeBorn = true;
    }

    private GameObject BallTypeRandomizer()
    {
        float randomizerFactor = Random.Range(0f, 100f);
        if(randomizerFactor < EnemySpawnProbability)
        {
            return enemy;
        }
        if(randomizerFactor < EnemySpawnProbability + FriendSpawnProbability)
        {
            return friend;
        }
        if(randomizerFactor < EnemySpawnProbability + FriendSpawnProbability + HeartSpawnProbability)
        {
            return heart;
        }
        return joker;
    }
}
