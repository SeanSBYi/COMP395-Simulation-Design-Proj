using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adddocter : MonoBehaviour {
    public Button yourButton;
    public GameObject drObj;
    public GameObject fDoctor;
    public GameObject spawnPositionObj;

    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        int index = Random.Range(1, 100);
        if(index < 25)
        {
            GameObject dr = Instantiate(drObj, spawnPositionObj.transform.position, Quaternion.identity);
        }
        else
        {
            GameObject dr = Instantiate(fDoctor, spawnPositionObj.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log("You have clicked the button!");
    }
}
