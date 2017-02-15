using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject Sufferer;

    public float MinSpawnRangeTime = 5.0f;
    public float MaxSpawnRangeTime = 15.0f;

    public GameObject RegularSpawnPoint;
    public GameObject EmergencySpawnPoint;

    public int MaxSufferer = 10;

    public int iNowSuffererCnt;

    void SpawnSufferer()
    {
        if (enableSpawn && (MaxSufferer > iNowSuffererCnt))
        {
            iNowSuffererCnt++;
            GameObject sufferer = Instantiate(Sufferer, new Vector3(-12.0f, 0f, 0f), Quaternion.identity);

            int conditionRnd = Random.Range(0, 100);
            if (conditionRnd > 50) // 100 > g > 50
            {
                sufferer.GetComponent<MySuffererController>().SetCondition(MySuffererController.eCondition.eGreen);
            }
            else if (conditionRnd > 15) // 50 > y > 15
            {
                sufferer.GetComponent<MySuffererController>().SetCondition(MySuffererController.eCondition.eYellow);
            }
            else // 15 > r
            {
                sufferer.GetComponent<MySuffererController>().SetCondition(MySuffererController.eCondition.eRed);
            }
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

