using UnityEngine;
using System.Collections;

public class Singleton : MonoBehaviour {
	public bool paused=false;
	public Texture2D heart;
	public Texture2D emptyHeart;
	public AudioClip myHurt;
	public AudioClip lockSound;
	public float timer;
	public static int finalTime;
	public bool timerStart=false;
	public bool lastLevel = false;
	public float hSliderValue = 3.0f;
	private static Singleton _instance = null;
	public static Singleton Instance
	{
		get { return _instance; }	
	}
	
	void Awake()
	{
		GameObject.Find("Player").SendMessage("setHP");
		if(_instance != null && _instance !=this)
		{
			Destroy(gameObject);

		}
		else
		{
			_instance = this;	

		}
		
		DontDestroyOnLoad(gameObject);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		keyInput();
		AudioListener.volume = hSliderValue/10.0f;
		score();
	}

	void OnGUI()
	{
		if(!lastLevel)
		{
			if(GUI.Button(new Rect(0,0,140,40), "Restart Level"))
			{
				GameObject.Find("LevelManager").SendMessage("RestartLevel");
			}
			/*if(GUI.Button(new Rect(0,70,140,40), "Next Level"))
			{
				GameObject.Find("LevelManager").SendMessage("NextLevel");
			}*/
			if(PlayerAI.getHp() ==3)
			{
				GUI.Box(new Rect(Screen.width-100, 100, 100,100), heart);
				GUI.Box(new Rect(Screen.width-100, 200, 100,100), heart);
				GUI.Box(new Rect(Screen.width-100, 300, 100,100), heart);
			}
			if(PlayerAI.getHp() ==2)
			{
				GUI.Box(new Rect(Screen.width-100, 100, 100,100), heart);
				GUI.Box(new Rect(Screen.width-100, 200, 100,100), heart);
				GUI.Box(new Rect(Screen.width-100, 300, 100,100), emptyHeart);
			}
			if(PlayerAI.getHp() ==1)
			{
				GUI.Box(new Rect(Screen.width-100, 100, 100,100), heart);
				GUI.Box(new Rect(Screen.width-100, 200, 100,100), emptyHeart);
				GUI.Box(new Rect(Screen.width-100, 300, 100,100), emptyHeart);
			}
			if(timerStart)
			{
				GUI.Box(new Rect(Screen.width-100, 0.0f, 100.0f ,50.0f), ""+timer);
			}

			hSliderValue = GUI.HorizontalSlider(new Rect (0, Screen.height/2, 100, 150), hSliderValue, 0.0f, 10.0f);
		}
		if(lastLevel)
		{
			if(!timerStart)
			{
				GUI.Box(new Rect(Screen.width/2, Screen.height/2 - 200, 300.0f ,50.0f), "Your Score: "+finalTime);
			}
		}

	}
	
	void keyInput()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();	
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(!paused)
			{
				paused=true;
				Time.timeScale=0;
			}
			else
			{
				paused=false;
				Time.timeScale=1;
			}
		}
	}

	void wasHurt()
	{

		audio.PlayOneShot(myHurt);
	}

	void playLockSound()
	{
		audio.PlayOneShot(lockSound);
	}
	void setLastLevel()
	{
		lastLevel = true;
	}

	void score()
	{
		if(timerStart)
		{
			timer = timer + 1*Time.deltaTime;
		}
	}

	void startTimer()
	{
		timerStart = true;
	}

	void stopTimer()
	{
		timerStart=false;
		timer = timer*1000;
		finalTime = Mathf.RoundToInt(timer);
		KongregateAPI.SubmitData("Time Score", finalTime);

	}
	public static int passTime()
	{
		return finalTime;
	}
}


