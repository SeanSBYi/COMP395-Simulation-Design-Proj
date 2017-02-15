using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController : MonoBehaviour {

    private new SpriteRenderer renderer;

    private bool isActive;
    private bool inSufferer;

    // Use this for initialization
    void Start () {
        renderer = gameObject.GetComponent<SpriteRenderer>(); //Get the renderer via GetComponent or have it cached previously
        isActive = false;

        renderer.color = new Color(1f, 1f, 1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.DrawRay(transform.position, transform.forward * 100f, Color.green, 20);

            if (Physics.Raycast(ray, out hit))
            {
                // ?: conditional operator.  
                isActive = (isActive == true) ? false : true;

                if (isActive == false)
                {
                    renderer.color = new Color(0.5f, 0.5f, 0.5f, 1f);
                }
            }
        }

        if (inSufferer == true)
        {
            renderer.color = new Color(1f, 0f, 0f, 1f);
        }
    }
}
