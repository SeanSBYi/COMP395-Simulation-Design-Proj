using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySuffererController : MonoBehaviour {

    enum ePhase
    {
        eNone,
        eWaiting,
        eP1,
        eP2
    }

    enum State
    {
        Idle,
        Move
    };

    State currentState = State.Idle;
    ePhase phase = ePhase.eNone;

    public GameObject[] myWayPoints;
    private Vector3 wayPointPos;
    private Vector3 currentPos;
    private float speed = 3.0f;

    private int iHP;

    private float checkTime = 10.0f;
    private float timeSpan = 0.0f;

    // Use this for initialization
    void Start () {
        timeSpan = 0.0f;
        wayPointPos = myWayPoints[0].transform.position;
        currentState = State.Move;
    }
	
	// Update is called once per frame
	void Update () {

        if(currentState == State.Idle)
        {
            timeSpan += Time.deltaTime;
            if (timeSpan > checkTime)
            {
                currentState = State.Move;
                timeSpan = 0;
            }
        }

        if (currentState == State.Move)
        {
            currentPos = transform.position;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(currentPos, wayPointPos, step);

            if (Vector3.Distance(myWayPoints[(int)phase].transform.position, currentPos) == 0f)
            {
                currentState = State.Idle;
                if (phase == ePhase.eNone)
                {
                    phase = ePhase.eWaiting;
                    wayPointPos = myWayPoints[1].transform.position;
                }
            }
        }
    }
}
