using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank2Movement : MonoBehaviour {

    public GameObject plankLocal;

    // Use this for initialization
    void Start () {

        //this.plankLocal = GameObject.Find("SpringSprite");
        //foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
        //{
        //    if (gameObj.name == "SpringSprite")
        //    {
        //        this.plankLocal = gameObj;
        //    }
        //}

    }
	
	// Update is called once per frame
	void Update () {
        float x = plankLocal.transform.position.x;
        float y = plankLocal.transform.position.y;
        float z = plankLocal.transform.position.z;
        this.transform.position = new Vector3(x, y, z);
    }
}
