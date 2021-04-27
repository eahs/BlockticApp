using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipG : MonoBehaviour
{
	// Start is called before the first frame update
	private bool m_FacingRight = true;
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

    }
	
	void flip()
	{
		GetComponent<Rigidbody2D>().gravityScale *= -1;
		if (GetComponent<Rigidbody2D>().gravityScale <= -1)
		{
			m_FacingRight = false;
			transform.localRotation = Quaternion.Euler(180, 0, 0);
		}
		else
		{
			m_FacingRight = true;
			transform.localRotation = Quaternion.Euler(0, 0, 0);
		}
	}
}
