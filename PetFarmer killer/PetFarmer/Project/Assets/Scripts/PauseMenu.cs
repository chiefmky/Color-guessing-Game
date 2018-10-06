using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour 
{
	public static bool Paused = false;

	Canvas pauseCanvas;

	// Use this for initialization
	void Start () 
	{
		pauseCanvas = GetComponent<Canvas> ();
		pauseCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("p"))
		{
			Pause();
		}

		if(Paused)
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}else
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	public void Pause()
	{
		if(Paused == false)
		{
			pauseCanvas.enabled = true;
			Paused = true;
			Time.timeScale = 0;
			print (Paused);

		}else 
		{
			Paused = false;
			Time.timeScale = 1;
			pauseCanvas.enabled = false;
			print (Paused);
		}
	}
}
