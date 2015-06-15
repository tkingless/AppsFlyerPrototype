using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppsFlyerRuntime : MonoBehaviour {

	// Use this for initialization
	void Start () {

		AppsFlyer.setAppsFlyerKey ("L9sqRDPwTRURnhNNsyNagS"); 
		AppsFlyer.setAppID ("com.nxtomo.flyer.test"); 
		//AppsFlyer.setCollectIMEI (false);
		//AppsFlyer.setCollectAndroidID (false); 
		AppsFlyer.trackAppLaunch (); 

		print("AppsFlyerRuntime start() called");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {

		if(GUI.Button(new Rect(Screen.width/2,Screen.height/2,Screen.width/8,Screen.height/8), "Shoot Test event")){
			TrackRichEventTest();
		}
	}

		// Test in app event
		public void TrackRichEventTest() {
			print ("trackRichEventTest called");
			Dictionary<string, string> dict = new Dictionary<string, string> ();
			dict.Add ("currency", "USD");
			dict.Add ("productId", "123123");
			dict.Add ("price", "100");
			AppsFlyer.trackRichEvent ("add_to_wish_list", dict);
		}
}
