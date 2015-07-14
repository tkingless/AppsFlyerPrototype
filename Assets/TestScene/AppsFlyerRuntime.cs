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
		if(GUI.Button(new Rect(Screen.width/2+Screen.width/8,Screen.height/2+Screen.height/8,Screen.width/8,Screen.height/8), "Shoot Test event 2")){
			TrackRichEventTest2();
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

	public void TrackRichEventTest2() {
		print ("trackRichEventTest2 called");
		Dictionary<string, string> dict = new Dictionary<string, string> ();
		dict.Add ("name", "Regal");
		//dict.Add ("productId", "123123");
		dict.Add ("price", "100");
		AppsFlyer.trackRichEvent ("hotel_booked", dict);
	}
}
