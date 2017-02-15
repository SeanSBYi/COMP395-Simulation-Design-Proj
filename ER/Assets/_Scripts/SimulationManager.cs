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
    private bool[] isOccupy = new bool[4];

    private GameObject[] objPatientList;

    public void SetEmptyBedStatus(int _idx, bool _isOccupy)
    {
        isOccupy[_idx] = _isOccupy;
    }

    public void ToggleEmptyBed(int _idx)
    {
        isOccupy[_idx] = (isOccupy[_idx] == true) ? false : true;
    }

    // Use this for initialization
    void Start () {
        //GameObject[] objPatientList = GameObject.FindGameObjectsWithTag("Patient");
    }
	
	// Update is called once per frame
	void Update () {
        objPatientList = GameObject.FindGameObjectsWithTag("Patient");

        // NULL Check
        if (objPatientList.Length > 0)
        {
            foreach (GameObject goTemp in objPatientList)
            {
                if (goTemp == null)
                    break;

                MySuffererController.ePhase tempPhase =
                    goTemp.GetComponent<MySuffererController>().GetPhase();


                for (int i = 0; i < isOccupy.Length; i++)
                {
                    if (tempPhase == MySuffererController.ePhase.eRoom1 && isOccupy[i] == false)
                    {
                        isOccupy[i] = true;
                        goTemp.GetComponent<MySuffererController>().SetPhase(MySuffererController.ePhase.eRoom2Pre, i);
                        break;
                    }
                }
            }
        }
    }
}
