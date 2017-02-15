using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour {

    //struct stWay{
    //    GameObject wayObject;
    //    bool isEmpty;

    //}
    //private stWay[] waypoint;

    public int totalBedCnt = 4;
    private bool[] isEmpty;

    private GameObject[] objPatientList;

    // Use this for initialization
    void Start () {
        //GameObject[] objPatientList = GameObject.FindGameObjectsWithTag("Patient");
    }
	
	// Update is called once per frame
	void Update () {
        objPatientList = GameObject.FindGameObjectsWithTag("Patient");

        foreach (GameObject goTemp in objPatientList)
        {
            MySuffererController.ePhase tempPhase =
                goTemp.GetComponent<MySuffererController>().GetPhase();

        }
    }
}
