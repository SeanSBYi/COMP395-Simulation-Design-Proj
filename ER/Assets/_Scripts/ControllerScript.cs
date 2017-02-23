using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScript : MonoBehaviour {

	[SerializeField]
	private GameObject patient;

	private GameObject gb;
	private Slider slider;

    public Text timerText;
    private float startTime;

	// Use this for initialization
	void Start () {
		gb = GameObject.Find ("SpeedSlider");
		slider = gb.GetComponent<Slider> ();

        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.T)) {
//			Time.timeScale = 5.0f;
//		}
//		if (Input.GetKeyDown (KeyCode.A)) {
//			Time.timeScale = 1.0f;
//		}
		Time.timeScale = slider.value;

		Debug.Log (Time.time);

        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        timerText.text = minutes + ":" + seconds;

	}


}
