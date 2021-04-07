using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	double value=0;
	double pastValue=0;
	
	public Text TextObject;
	
    // Start is called before the first frame update
    void Start()
    {
        //textObject = GetComponent.<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (value > Convert.ToInt32(pastValue+1))
        {
			pastValue=value;
			TextObject.text=string.Format("Time: {0}", Convert.ToInt32(value));
        }
        value += Time.deltaTime*10;
    }
}
