using UnityEngine;
using System.Collections;

public class KongregateAPI : MonoBehaviour 
{
	static bool KONGREGATE_LOADED = false;
	static int USER_ID=0;
	static string USER_NAME = "Guest";
	static string GAME_AUTH_TOKEN = "";

	// Use this for initialization
	void Start () 
	{
		Application.ExternalEval("typeof(kongregateUnitySupport) != 'undefined') {" +
		                         " kongregateUnitySupport.initAPI('API', 'OnKongregateAPILoaded');}");
	}
	
	void OnKongregateAPILoaded(string userInfo)
	{
		KONGREGATE_LOADED=true;
		string[] userStats = userInfo.Split("|"[0]);
		USER_ID = int.Parse(userStats[0]);
		USER_NAME = userStats[1];
		GAME_AUTH_TOKEN = userStats[2];
	}

	public static bool APILoaded()
	{
		if(USER_NAME != "Guest" && KONGREGATE_LOADED)
			return true;
		else
			return false;
	}

	public static void SubmitData(string dataName, int dataValue)
	{
		if(APILoaded())
		{
			Application.ExternalCall("kongregate.stats.submit", dataName, dataValue);
		}
	}
}
