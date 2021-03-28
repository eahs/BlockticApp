using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipG : MonoBehaviour
{
	
	public double timer = 4;
    // Start is called before the first frame update
    void Start()
    {
        
		ButtonBlock.OnClicked += flip;
		//Debug.Log("init");
    }
	
	void onEnable()
	{
		ButtonBlock.OnClicked += flip;
		//Debug.Log("init");
	}

	void onDisable()
	{
		ButtonBlock.OnClicked -= flip;
	}

    // Update is called once per frame
    void Update()
    {
		/*if(timer>0){
			timer-=Time.deltaTime;
		}else{
			timer+=4;
			flip();
		}*/
    }
	
	void flip()
	{
		GetComponent<Rigidbody2D>().gravityScale *= -1;
	}
}
