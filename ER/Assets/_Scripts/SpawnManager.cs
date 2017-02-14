using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject Sufferer;

    public float MinSpawnRangeTime = 5.0f;
    public float MaxSpawnRangeTime = 15.0f;

    public int MaxSufferer = 10;

    public int iNowSuffererCnt;

    void SpawnSufferer()
    {
        if (enableSpawn && (MaxSufferer > iNowSuffererCnt))
        {
            iNowSuffererCnt++;
            GameObject sufferer = Instantiate(Sufferer, new Vector3(-12.0f, 0f, 0f), Quaternion.identity);
        }
        float rnd = Random.Range(MinSpawnRangeTime, MaxSpawnRangeTime);
        Invoke("SpawnSufferer", rnd);
    }

    // Use this for initialization
    void Start () {
        iNowSuffererCnt = 0;
        Invoke("SpawnSufferer", 3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

