using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipG : MonoBehaviour
{
	// Start is called before the first frame update
	private bool m_FacingRight = true;
	public float coolDown = 1;
	public float coolDownTimer;
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
		if(coolDownTimer > 0)
		{
			coolDownTimer -= Time.deltaTime;
		}
		if(coolDownTimer <0)
        {
			coolDownTimer = 0;
        }
    }
	void flip()
	{
		if (coolDownTimer == 0)
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
			coolDownTimer = 3;
		}
	}
}

