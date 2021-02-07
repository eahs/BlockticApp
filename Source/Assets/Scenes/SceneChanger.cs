using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToScores()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToLevels ()
	{
		SceneManager.LoadScene(2);
	}

    public void GoToGame ()
	{
		SceneManager.LoadScene(3);
	}
}
