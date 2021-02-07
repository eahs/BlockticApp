using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	double value=10000;
	double pastValue=10000;
	
	public Text TextObject;
	
    // Start is called before the first frame update
    void Start()
    {
        //textObject = GetComponent.<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (value>0 && value < Convert.ToInt32(pastValue+1))
        {
			pastValue=value;
			TextObject.text=string.Format("Score: {0}", Convert.ToInt32(value));
        }
        value -= Time.deltaTime*10;
    }
}
