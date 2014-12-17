using UnityEngine;
using System.Collections;

namespace KongregateNamespace
{
public class KongregateAPI : MonoBehaviour 
{
	static bool KONGREGATE_LOADED { get; private set; }// false;
	static int USER_ID { get; private set; }//=0;
	static string USER_NAME { get; private set; }// = "Guest";
	static string GAME_AUTH_TOKEN { get; private set; }// = "";

	// Use this for initialization
	void Start () 
	{
		if (!KONGREGATE_LOADED) {
						//Application.ExternalEval ("typeof(kongregateUnitySupport) != 'undefined') {" +
						//		" kongregateUnitySupport.initAPI('API', 'OnKongregateAPILoaded');}");
						Application.ExternalEval (
				"if(typeof(kongregateUnitySupport) != 'undefined') {" +
								"kongregateUnitySupport.initAPI('" + gameObject.name + "', 'OnKongregateAPILoaded');" +
								"}");
				} else {
						Debug.LogWarning ("You are attempting to connect to Kongregate's API multiple times. You only need to connect once.");
				}

	}
	
	void OnKongregateAPILoaded(string userInfo)
	{
		KONGREGATE_LOADED=true;
		string[] userStats = userInfo.Split('|');//= userInfo.Split("|"[0]);
		USER_ID = System.Convert.ToInt32(userStats[0]);// = int.Parse(userStats[0]);
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

	/*public static void SubmitData(string dataName, int dataValue)
	{
		if(APILoaded())
		{
			Application.ExternalCall("kongregate.stats.submit", dataName, dataValue);
		}
	}*/
	/// <summary>
	/// Submit a value to the server.
	/// </summary>
	/// <param name="statisticName">The name of the statistic. This is the name provided in the "Statistic name" section when you fill in the API when uploading your game.</param>
	/// <param name="value">The value to submit (score, kills, deaths, etc...).</param>
	public static void SubmitData(string statisticName, int value)
	{
		if (APILoaded())
			Application.ExternalCall("kongregate.stats.submit", statisticName, value);
		else
			Debug.LogWarning("You are attempting to submit a statistic without being connected to Kongregate's API or for a guest Player. Connect first, then submit.");
	}
}
}