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
	public GameObject block;
	public GameObject player;
	/*public Vector3 location1=player.transform.position;
	public Vector3 location2=block.transform.position;*/
	public double timer = 1;
	public double distance=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		distance=Math.Sqrt(Math.Pow(player.transform.position.x-block.transform.position.x+3, 2f) + Math.Pow(player.transform.position.y-block.transform.position.y, 2f));
		if (Input.GetButtonDown("Interact") && 8>distance){
			spriteRenderer.sprite=activeSprite;
			timer=0.2;
		}else{
			if(timer>0){
				timer-=Time.deltaTime;
			}else{
				spriteRenderer.sprite=inactiveSprite;
			}
		}
    }
}
