using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public GameObject carPrefab; // 要生成的預置物
    public GameObject truckPrefab;
    
    public float minSpawnTime = 1f; // 隨機秒數範圍的下限
    public float maxSpawnTime = 5f; // 隨機秒數範圍的上限
    private float timer = 0f;

    public List<GameObject> roads = new List<GameObject>();
    
    void Update()
    {
        float waitTime = Random.Range(minSpawnTime, maxSpawnTime);
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {
            float spawnY = roads[Random.Range(0, roads.Count)].GetComponent<Transform>().position.y;
            float spawnX = Random.value > 0.5f ? 12f : -12f;
            Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);

            GameObject finalPrefab = Random.value > 0.5f ? carPrefab : truckPrefab;
            Instantiate(finalPrefab, spawnPos, Quaternion.identity);

            timer = 0f;
        }
    }
}
