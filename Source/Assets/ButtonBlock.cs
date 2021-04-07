using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBlock : MonoBehaviour
{
	//public Vector3 location = transform.position;
	public SpriteRenderer spriteRenderer;
	public Sprite activeSprite;
	public Sprite inactiveSprite;
	public double timer = 1;
	public double distance = 0;

	public delegate void ClickAction();
	public static event ClickAction OnClicked;

	public bool isTouching = false;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Collider2D[] grabChecks = Physics2D.OverlapCircleAll(transform.position, 2);

		isTouching = false;

		if (Input.GetButtonDown("Interact")) foreach (var grabCheck in grabChecks)
			{
				if (grabCheck.gameObject.tag == "Player")
				{
					spriteRenderer.sprite = activeSprite;
					timer = 0.2;
					if (OnClicked != null) OnClicked();
				}
				if (grabCheck.GetComponent<Collider>() != null && grabCheck.GetComponent<Collider>().tag == "Player")
				{
					isTouching = true;
				}
			}
		if (timer > 0)
		{
			timer -= Time.deltaTime;
		}
		else
		{
			spriteRenderer.sprite = inactiveSprite;
		}

	}
}