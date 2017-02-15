using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySuffererController : MonoBehaviour {

    public enum ePhase
    {
        eNone,
        eRoom1,
        eRoom2,
        eExit,
    }

    enum eMoveState
    {
        Idle,
        Move
    };

    public enum eCondition
    {
        eDead,
        eGreen,
        eRed,
        eYellow
    }

    eMoveState currentState = eMoveState.Idle;
    ePhase phase = ePhase.eNone;
    eCondition condition = eCondition.eDead;

    public GameObject[] myWayPointsRoom1;
    public GameObject[] myWayPointRoom1SE;

    public GameObject[] myWayPointsRoom2;
    public GameObject[] myWayPointRoom2SE;

    private Vector3 wayPointPos;
    private Vector3 currentPos;
    private float speed = 3.0f;

    private float fHP;

    private float MinSpawnRangeHP = 5.0f;
    private float MaxSpawnRangeHP = 95.0f;

    private float checkTime = 5.0f;
    private float timeSpan = 0.0f;

    private int nowWayPointIdx = 0;
    private int totalWayPointCnt = 0;

    private new SpriteRenderer renderer;

    public ePhase GetPhase()
    {
        return phase;
    }

    public void SetPhase(MySuffererController.ePhase _newPhase)
    {
        if (_newPhase == ePhase.eRoom2)
        {
            wayPointPos = myWayPointRoom2SE[0].transform.position;
            totalWayPointCnt = myWayPointsRoom2.Length;
        }
        else if(_newPhase == ePhase.eExit)
        {
            wayPointPos = myWayPointRoom2SE[1].transform.position;
        }
        nowWayPointIdx = 0;
        phase = _newPhase;
    }

    public void SetCondition(MySuffererController.eCondition _newCondition)
    {
        condition = _newCondition;

        float newMinSpawnHP;
        float newMaxSpawnHP;

        if (condition == eCondition.eGreen)
        {
            newMinSpawnHP = 50.0f;
            newMaxSpawnHP = 90.0f;
        }
        else if(condition == eCondition.eYellow)
        {
            newMinSpawnHP = 25.0f;
            newMaxSpawnHP = 50.0f;
        }
        else if (condition == eCondition.eRed)
        {
            newMinSpawnHP = 10.0f;
            newMaxSpawnHP = 25.0f;
        }
        else
        {
            newMinSpawnHP = MinSpawnRangeHP;
            newMaxSpawnHP = MaxSpawnRangeHP;
        }

        fHP = Random.Range(newMinSpawnHP, newMaxSpawnHP);
    }
    

    // Use this for initialization
    void Start () {
        renderer = gameObject.GetComponent<SpriteRenderer>(); //Get the renderer via GetComponent or have it cached previously
        // Unity Color Code : https://docs.unity3d.com/ScriptReference/Color.html

        totalWayPointCnt = myWayPointsRoom1.Length;

        //iHP = (int)Random.Range(MinSpawnRangeHP, MaxSpawnRangeHP);

        timeSpan = 0.0f;
        wayPointPos = myWayPointRoom1SE[0].transform.position;
        currentState = eMoveState.Move;
    }
	
	// Update is called once per frame
	void Update () {

        if (fHP > 50.0f) // 100 > g > 50
        {
            //renderer.color = new Color(0, 0, 0, 1f); // black
            renderer.color = new Color(0, 1f, 0, 1f); // green
        }
        else if (fHP > 15.0f) // 50 > y > 15
        {
            renderer.color = new Color(1f, 0.92f, 0.016f, 1f); // yellow
        }
        else // 15 > r
        {
            renderer.color = new Color(1, 0f, 0f, 1); // red
        }

        if (currentState == eMoveState.Idle)
        {
            timeSpan += Time.deltaTime;
            if (timeSpan > checkTime)
            {
                currentState = eMoveState.Move;
                timeSpan = 0;

                // TEMP
                checkTime = Random.Range(2.0f, 6.0f);
            }

            // TEMP
            if(phase == ePhase.eRoom2)
            {
                fHP += 0.01f;
            }
        }

        if (currentState == eMoveState.Move)
        {
            currentPos = transform.position;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(currentPos, wayPointPos, step);


            if (Vector3.Distance(wayPointPos, currentPos) == 0f)
            {
                currentState = eMoveState.Idle;
                if (phase == ePhase.eNone)
                {
                    phase = ePhase.eRoom1;
                    wayPointPos = myWayPointsRoom1[0].transform.position;
                }
                else if (phase == ePhase.eRoom1)
                {
                    wayPointPos = myWayPointsRoom1[nowWayPointIdx].transform.position;
                    //nowWayPointIdx++;
                    nowWayPointIdx = Random.Range(0, totalWayPointCnt);
                    nowWayPointIdx = (totalWayPointCnt > nowWayPointIdx) ? nowWayPointIdx : 0;
                }
                else if (phase == ePhase.eRoom2)
                {
                    //wayPointPos = myWayPointsRoom1[nowWayPointIdx].transform.position;
                    //nowWayPointIdx++;
                    //nowWayPointIdx = (totalWayPointCnt > nowWayPointIdx) ? nowWayPointIdx : 0;
                    // 

                    if(fHP >= 100.0f)
                    {
                        phase = ePhase.eExit;
                        wayPointPos = myWayPointsRoom2[1].transform.position;
                    }
                }
                else if (phase == ePhase.eExit)
                {
                    Destroy(this);
                }
            }
        }
    }
}