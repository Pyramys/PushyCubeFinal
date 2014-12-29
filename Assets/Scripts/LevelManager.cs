using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public bool red = false;
	public bool yellow = false;
	public bool blue = false;
	public bool green = false;
    public bool rainbow = false;
	public bool ryb = false;
	public bool wall1Up =false;
	public bool wall2Up = false;
	
	public string tapToMove = "Tap to Move";
	public string tapPlayer = "Tap player to drop crystal";
	public string placeCrystals = "Move crystals to their position to advance";
	public string avoidTraps = "Avoid everything!";
	public string musicVolume = "Change Volume with this slider";
	public int levelIndex;
	public int currentLevel;
	public string watchTime = "Watch the Timer in the top right corner!";
	public float textTop;
	public float textLeft;
	public float textWidth=240;
	public float textHeight;
	
	private static LevelManager _instance = null;
	public static LevelManager Instance
	{
		get { return _instance; }	
	}
	
	void Awake()
	{
		
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
		currentLevel=0;
		green=true;
	}
	
	// Update is called once per frame
	void Update () {
		Ryb ();
	}
	
	void RestartLevel()
	{
		switch(currentLevel)
		{
		case 0:
		{
			Application.LoadLevel("IntroLevel");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 1:
		{
			Application.LoadLevel("LevelOne");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 2:
		{
			Application.LoadLevel("LevelTwo");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 3:
		{
			Application.LoadLevel("LevelThree");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			
			levelIndex++;
			break;
		}
		case 4:
		{
			Application.LoadLevel("LevelFour");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 5:
		{
			Application.LoadLevel("LevelFive");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 6:
		{
			Application.LoadLevel("LevelSix");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 7:
		{
			Application.LoadLevel("LevelSeven");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 8:
		{
			Application.LoadLevel("LevelEight");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 9:
		{
			Application.LoadLevel("LevelNine");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 10:
		{
			Application.LoadLevel("LevelTen");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 11:
		{
			Application.LoadLevel("LevelEleven");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 12:
		{
			Application.LoadLevel("LevelTwelve");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 13:
		{
			Application.LoadLevel("LevelThirteen");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		case 14:
		{
			Application.LoadLevel("Fourteen");
            red = false;
            blue = false;
            yellow = false;
            green = false;
			levelIndex++;
			break;
		}
		}	
	}
	
	void NextLevel()
	{
		switch(currentLevel)
		{
			case 0:
			{
				Application.LoadLevel("LevelOne");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 1:
			{
				Application.LoadLevel("LevelTwo");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 2:
			{
				Application.LoadLevel("LevelThree");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 3:
			{
				Application.LoadLevel("LevelFour");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 4:
			{
				Application.LoadLevel("LevelFive");
				red=false;
				blue=false;
				yellow=false;
			 	green = false;
				levelIndex++;
				break;
			}
			case 5:
			{
				Application.LoadLevel("LevelSix");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 6:
			{
				Application.LoadLevel("LevelSeven");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 7:
			{
				Application.LoadLevel("LevelEight");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 8:
			{
				Application.LoadLevel("LevelNine");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 9:
			{
				Application.LoadLevel("LevelTen");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 10:
			{
				Application.LoadLevel("LevelEleven");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 11:
			{
				Application.LoadLevel("LevelTwelve");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 12:
			{
				Application.LoadLevel("LevelThirteen");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 13:
			{
				Application.LoadLevel("LevelFourteen");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
			case 14:
			{
				Application.LoadLevel("Ending");
				red=false;
				blue=false;
				yellow=false;
				levelIndex++;
				break;
			}
						
		}
		
	}

    void setRed()
    {
        red = true;
        switch (currentLevel)
        {
            case 0:
                {

                    break;
                }
            case 1:
                {

                    break;
                }
            case 2:
                {
                    GameObject.Find("BlueSwitch").SendMessage("Activate");
                    GameObject.Find("YellowSwitch").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner1").SendMessage("spawnArcaneBlast");
                    GameObject.Find("ArcaneSpawner2").SendMessage("spawnArcaneBlast");
                    GameObject.Find("ArcaneSpawner3").SendMessage("spawnArcaneBlast");
                    GameObject.Find("ArcaneSpawner4").SendMessage("spawnArcaneBlast");
                    GameObject.Find("ArcaneSpawner5").SendMessage("spawnArcaneBlast");
                    break;
                }
            case 3:
                {
                    if (wall1Up)
                    {
                        GameObject.Find("PopupWall1").SendMessage("Deactivate");
                        wall1Up = false;
                    }
                    else if (!wall1Up)
                    {
                        GameObject.Find("PopupWall1").SendMessage("Activate");
                        wall1Up = true;
                    }
                    break;
                }
            case 4:
                {
                    GameObject.Find("BlueSwitch").SendMessage("Activate");
                    GameObject.Find("YellowSwitch").SendMessage("Activate");
                    GameObject.Find("LightningTrap1").SendMessage("Activate");
                    GameObject.Find("LightningTrap2").SendMessage("Activate");
                    GameObject.Find("LightningTrap3").SendMessage("Activate");
                    GameObject.Find("LightningTrap4").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
                    GameObject.Find("BlueCube").SendMessage("Activate");
                    GameObject.Find("YellowCube").SendMessage("Activate");
                    break;
                }
            case 5:
                {

                    break;
                }
            case 6:
                {

                    break;
                }
            case 7:
                {
                    GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
                    GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
                    GameObject.Find("LightningTrap1").SendMessage("Activate");
                    GameObject.Find("LightningTrap2").SendMessage("Activate");
                    break;
                }
            case 8:
                {

                    break;
                }
            case 9:
                {
                    GameObject.Find("Zombie").SendMessage("Activate");
                    break;
                }
            case 10:
                {

                    break;
                }
            case 11:
                {

                    break;
                }
            case 12:
                {

                    break;
                }
            case 13:
                {

                    break;
                }
            case 14:
                {

                    break;
                }
        }
    }
	
	void setBlue()
	{
		blue=true;	
        switch(currentLevel)
		{
			case 0:
			{
				
				break;
			}
			case 1:
			{
				
				break;
			}
			case 2:
			{
				
				break;
			}
			case 3:
			{
                if (wall1Up)
                {
                    GameObject.Find("PopupWall1").SendMessage("Deactivate");
                    wall1Up = false;
                }
                else if (!wall1Up)
                {
                    GameObject.Find("PopupWall1").SendMessage("Activate");
                    wall1Up = true;
                }
				break;
			}
			case 4:
			{
                GameObject.Find("PopDownWall").SendMessage("Activate");
				break;
			}
			case 5:
			{
				
				break;
			}
			case 6:
			{
				
				break;
			}
			case 7:
			{
                GameObject.Find("Zombie").SendMessage("Activate");
				break;
			}
			case 8:
			{
				
				break;
			}
			case 9:
			{
                GameObject.Find("LightningTrap1").SendMessage("Activate");
                GameObject.Find("LightningTrap2").SendMessage("Activate");
                GameObject.Find("LightningTrap3").SendMessage("Activate");
                GameObject.Find("LightningTrap4").SendMessage("Activate");
				break;
			}
			case 10:
			{
				
				break;
			}
			case 11:
			{
				
				break;
			}
			case 12:
			{
				
				break;
			}
			case 13:
			{
				
				break;
			}
			case 14:
			{
				
				break;
			}
	}
	}
	
	void setYellow()
	{
		yellow=true;
	    switch(currentLevel)
		{
			case 0:
			{
				
				break;
			}
			case 1:
			{
				
				break;
			}
			case 2:
			{
				
				break;
			}
			case 3:
			{
                if (wall1Up)
                {
                    GameObject.Find("PopupWall1").SendMessage("Deactivate");
                    wall1Up = false;
                }
                else if (!wall1Up)
                {
                    GameObject.Find("PopupWall1").SendMessage("Activate");
                    wall1Up = true;
                }
				break;
			}
			case 4:
			{
				
				break;
			}
			case 5:
			{
				
				break;
			}
			case 6:
			{
				
				break;
			}
			case 7:
			{
				
				break;
			}
			case 8:
			{
				
				break;
			}
			case 9:
			{
                GameObject.Find("FireballSpawner1").SendMessage("Activate");
                GameObject.Find("FireballSpawner2").SendMessage("Activate");
                GameObject.Find("FireballSpawner3").SendMessage("Activate");
                GameObject.Find("FireballSpawner4").SendMessage("Activate");
                GameObject.Find("FireballSpawner5").SendMessage("Activate");
                GameObject.Find("FireballSpawner6").SendMessage("Activate");
                GameObject.Find("FireballSpawner7").SendMessage("Activate");
                GameObject.Find("FireballSpawner8").SendMessage("Activate");
                GameObject.Find("FireballSpawner9").SendMessage("Activate");
				break;
			}
			case 10:
			{
				
				break;
			}
			case 11:
			{
				
				break;
			}
			case 12:
			{
				
				break;
			}
			case 13:
			{
				
				break;
			}
			case 14:
			{
				
				break;
			}
	}
	}

    void setGreen()
    {
        green = true;
        switch(currentLevel)
		{
			case 0:
			{
				
				break;
			}
			case 1:
			{
				
				break;
			}
			case 2:
			{
				
				break;
			}
			case 3:
			{
                if (wall1Up)
                {
                    GameObject.Find("PopupWall1").SendMessage("Deactivate");
                    wall1Up = false;
                }
                else if (!wall1Up)
                {
                    GameObject.Find("PopupWall1").SendMessage("Activate");
                    wall1Up = true;
                }
				break;
			}
			case 4:
			{
				
				break;
			}
			case 5:
			{
				
				break;
			}
			case 6:
			{
				
				break;
			}
			case 7:
			{
				
				break;
			}
			case 8:
			{
				
				break;
			}
			case 9:
			{
                GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner7").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner8").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner9").SendMessage("Activate");
				break;
			}
			case 10:
			{
                red = true;
                yellow = true;
                blue = true;
				break;
			}
			case 11:
			{
                red = true;
                yellow = true;
                green = true;
                GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner4").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner5").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner6").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner7").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner8").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner9").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner10").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner11").SendMessage("Activate");
                GameObject.Find("ArcaneSpawner12").SendMessage("Activate");
				break;
			}
			case 12:
			{
                red = true;
                blue = true;
                green = true;
                GameObject.Find("LightningTrap1").SendMessage("Activate");
                GameObject.Find("LightningTrap2").SendMessage("Activate");
                GameObject.Find("LightningTrap3").SendMessage("Activate");
                GameObject.Find("LightningTrap4").SendMessage("Activate");
                GameObject.Find("LightningTrap5").SendMessage("Activate");
                GameObject.Find("LightningTrap6").SendMessage("Activate");
                GameObject.Find("LightningTrap7").SendMessage("Activate");
                GameObject.Find("LightningTrap8").SendMessage("Activate");
				break;
			}
			case 13:
			{
                blue = true;
                yellow = true;
                green = true;
                GameObject.Find("FireballSpawner1").SendMessage("Activate");
                GameObject.Find("FireballSpawner2").SendMessage("Activate");
                GameObject.Find("FireballSpawner3").SendMessage("Activate");
                GameObject.Find("FireballSpawner4").SendMessage("Activate");
                GameObject.Find("FireballSpawner5").SendMessage("Activate");
                GameObject.Find("FireballSpawner6").SendMessage("Activate");
                GameObject.Find("FireballSpawner7").SendMessage("Activate");
                GameObject.Find("FireballSpawner8").SendMessage("Activate");
                GameObject.Find("FireballSpawner9").SendMessage("Activate");
                GameObject.Find("FireballSpawner10").SendMessage("Activate");
                GameObject.Find("FireballSpawner11").SendMessage("Activate");
                GameObject.Find("FireballSpawner12").SendMessage("Activate");
                GameObject.Find("FireballSpawner13").SendMessage("Activate");
                GameObject.Find("FireballSpawner14").SendMessage("Activate");
                GameObject.Find("FireballSpawner15").SendMessage("Activate");
                GameObject.Find("FireballSpawner16").SendMessage("Activate");
                GameObject.Find("FireballSpawner17").SendMessage("Activate");
                GameObject.Find("FireballSpawner18").SendMessage("Activate");
				break;
			}
			case 14:
			{
				
				break;
			}
	}
    }
    void setRainbow()
    {
        GameObject.Find("Plane").SendMessage("Activate");
    }
	void Ryb()
	{
        if(currentLevel==6)
        {
            if (red && green)
            {
                GameObject.Find("PermanentLightningTrap1").SendMessage("Deactivate");
            }

        }
        if (currentLevel == 14)
        {
            if (rainbow)
            {
                NextLevel();
            }
        }
		if( red && yellow && blue && green)
		{
			NextLevel();
		}	

	}
	
	void OnGUI()
	{
		if(currentLevel==0)
		{
			GUI.TextField(new Rect(0, 300, 200, 40), musicVolume);
			GUI.TextField(new Rect(0, 350, 140, 40), tapToMove);
			GUI.TextField(new Rect(0, 400, 180, 40), tapPlayer); 	
			GUI.TextField(new Rect(0, 450, 250, 40), placeCrystals); 	
			GUI.TextField(new Rect(0, 500, 140, 40), avoidTraps); 
		}
		else if(currentLevel==1)
		{
			GUI.TextField(new Rect(Screen.width-textWidth,50,textWidth,25), watchTime);
		}
	}
	
	void levelElements()
	{
        currentLevel = levelIndex;
		switch(currentLevel)
		{
		case 0:
		{
			
			break;
		}
		case 1:
		{
			GameObject.Find("ArcaneSpawner1").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner2").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner3").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner4").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner5").SendMessage("spawnArcaneBlast");
			GameObject.Find("Singleton").SendMessage("startTimer");
            green = true;
			break;
		}
		case 2:
		{
			
            green = true;
			
			break;
		}
		case 3:
		{
			GameObject.Find("LightningTrap1").SendMessage("Activate");
			GameObject.Find("LightningTrap2").SendMessage("Activate");
			GameObject.Find("LightningTrap3").SendMessage("Activate");
			GameObject.Find("LightningTrap4").SendMessage("Activate");
			GameObject.Find("ArcaneSpawner1").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner2").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner3").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner4").SendMessage("spawnArcaneBlast");
			GameObject.Find("ArcaneSpawner5").SendMessage("spawnArcaneBlast");
			
			break;
		}
		case 4:
		{
            green = true;
			break;
		}
		case 5:
		{
            GameObject.Find("LightningTrap1").SendMessage("Activate");
            GameObject.Find("LightningTrap2").SendMessage("Activate");
            GameObject.Find("LightningTrap3").SendMessage("Activate");
            GameObject.Find("LightningTrap4").SendMessage("Activate");
            GameObject.Find("LightningTrap5").SendMessage("Activate");
            GameObject.Find("LightningTrap6").SendMessage("Activate");
            GameObject.Find("LightningTrap7").SendMessage("Activate");
            GameObject.Find("LightningTrap8").SendMessage("Activate");
            GameObject.Find("LightningTrap9").SendMessage("Activate");
            GameObject.Find("LightningTrap10").SendMessage("Activate");
            GameObject.Find("LightningTrap11").SendMessage("Activate");
            GameObject.Find("LightningTrap12").SendMessage("Activate");
            GameObject.Find("LightningTrap13").SendMessage("Activate");
            GameObject.Find("LightningTrap14").SendMessage("Activate");
            GameObject.Find("LightningTrap15").SendMessage("Activate");
            GameObject.Find("LightningTrap16").SendMessage("Activate");
            GameObject.Find("LightningTrap17").SendMessage("Activate");
            GameObject.Find("LightningTrap18").SendMessage("Activate");
			break;
		}
		case 6:
		{
            GameObject.Find("LightningTrap1").SendMessage("Activate");
            GameObject.Find("LightningTrap2").SendMessage("Activate");
            GameObject.Find("LightningTrap3").SendMessage("Activate");
            GameObject.Find("LightningTrap4").SendMessage("Activate");
            GameObject.Find("LightningTrap5").SendMessage("Activate");
            GameObject.Find("LightningTrap6").SendMessage("Activate");
            GameObject.Find("PermanentLightningTrap1").SendMessage("Activate");
            GameObject.Find("ArcaneSpawner1").SendMessage("Activate");
            GameObject.Find("ArcaneSpawner2").SendMessage("Activate");
            GameObject.Find("ArcaneSpawner3").SendMessage("Activate");
            GameObject.Find("ArcaneSpawner4").SendMessage("Activate");

           
			break;
		}
		case 7:
		{
            green = true;
			break;
		}
		case 8:
		{
            green = true;
			break;
		}
		case 9:
		{
			
			break;
		}
		case 10:
		{
			
			break;
		}
		case 11:
		{
			
			break;
		}
		case 12:
		{
			
			break;
		}
		case 13:
		{
			
			break;
		}
		case 14:
		{
			
			break;
		}
		}
	}
}
