﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killzone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string scene = currentScene.name;
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }
    }
}
