using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComida : MonoBehaviour
{
    public GameObject[] FrutasPrefab;
    public float spawnRangeD = 15.0f;
    public float spawnRangeI = -15.0f;
    private float startdelay = 1f;
    private float spawnInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCARROS", startdelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCARROS()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeI, spawnRangeD), 10, 0);
        int carIndex = Random.Range(0, FrutasPrefab.Length);
        Instantiate(FrutasPrefab[carIndex], spawnPos, FrutasPrefab[carIndex].transform.rotation);
    }
}
