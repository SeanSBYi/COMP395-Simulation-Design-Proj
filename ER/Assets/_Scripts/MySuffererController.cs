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
    public GameObject[] myWayPoints2;
    private Vector3 wayPointPos;
    private Vector3 currentPos;
    private float speed = 3.0f;

    private int iHP;

    private float MinSpawnRangeHP = 5.0f;
    private float MaxSpawnRangeHP = 95.0f;

    private float checkTime = 10.0f;
    private float timeSpan = 0.0f;

    private new SpriteRenderer renderer;

    // Use this for initialization
    void Start () {
        renderer = gameObject.GetComponent<SpriteRenderer>(); //Get the renderer via GetComponent or have it cached previously
        // Unity Color Code : https://docs.unity3d.com/ScriptReference/Color.html

        iHP = (int)Random.Range(MinSpawnRangeHP, MaxSpawnRangeHP);

        timeSpan = 0.0f;
        wayPointPos = myWayPoints[0].transform.position;
        currentState = State.Move;
    }
	
	// Update is called once per frame
	void Update () {

        if(iHP > 50 ) // 100 > g > 50
        {
            //renderer.color = new Color(0, 0, 0, 1f); // black
            renderer.color = new Color(0, 1f, 0, 1f); // green
        }
        else if (iHP > 15) // 50 > y > 15
        {
            renderer.color = new Color(1f, 0.92f, 0.016f, 1f); // yellow
        }
        else // 15 > r
        {
            renderer.color = new Color(1, 0f, 0f, 1); // red
        }

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
