using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	void onEnable()
	{
		ButtonBlock.OnClicked += flip;
	}

	void onDisable()
	{
		ButtonBlock.OnClicked -= flip;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void flip()
	{
		GetComponent<Rigidbody2D>().gravityScale *= -1;
	}
}
