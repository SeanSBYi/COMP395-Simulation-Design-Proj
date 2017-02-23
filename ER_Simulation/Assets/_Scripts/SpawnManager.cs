using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject Sufferer;

    public float MinSpawnRangeTime = 5.0f;
    public float MaxSpawnRangeTime = 15.0f;

    public GameObject RegularSpawnPoint;
    public GameObject EmergencySpawnPoint;

    private Vector3 spawnPointV3;

    public int MaxSufferer = 10;

    public int iNowSuffererCnt;

    private GameObject gb;
    public GameObject sliderPatient;
    private Slider slider1;

    void SpawnSufferer()
    {
        if (enableSpawn && (MaxSufferer > iNowSuffererCnt))
        {
            iNowSuffererCnt++;

            int conditionRnd = Random.Range(0, 100);

            if (conditionRnd > 30)
                spawnPointV3 = RegularSpawnPoint.transform.position;
            else
                spawnPointV3 = EmergencySpawnPoint.transform.position;

            GameObject sufferer = Instantiate(Sufferer, spawnPointV3, Quaternion.identity);

            if (conditionRnd > 65)
            {
                sufferer.GetComponent<MySuffererController>().SetCondition(MySuffererController.eCondition.eGreen);
            }
            else if (conditionRnd > 30)
            {
                sufferer.GetComponent<MySuffererController>().SetCondition(MySuffererController.eCondition.eYellow);
            }
            else
            {
                sufferer.GetComponent<MySuffererController>().SetCondition(MySuffererController.eCondition.eRed);
            }
            
        }

        float rnd = Random.Range(MinSpawnRangeTime, MaxSpawnRangeTime);
        Invoke("SpawnSufferer", rnd);
    }

    public void PatientGoingOut()
    {
        iNowSuffererCnt--;
        
        if(iNowSuffererCnt < 0)
            iNowSuffererCnt = 0;
    }

    // Use this for initialization
    void Start () {
        iNowSuffererCnt = 0;
        Invoke("SpawnSufferer", 3);

        //gb = GameObject.Find("PatientSlider");
        slider1 = sliderPatient.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update () {
        MaxSufferer = (int)slider1.value;
	}
}

