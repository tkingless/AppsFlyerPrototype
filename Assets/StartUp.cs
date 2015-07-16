using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartUp : MonoBehaviour {

	// Use this for initialization
	void Start () {

		AppsFlyer.setAppsFlyerKey ("L9sqRDPwTRURnhNNsyNagS");

		#if UNITY_IOS 

		//AppsFlyer.setAppID ("com.nxtomo.inhouse.appsFlyerTest");
		AppsFlyer.setAppID ("265446688");
		AppsFlyer.setIsDebug (true);
		AppsFlyer.getConversionData ();
		AppsFlyer.trackAppLaunch ();

		#elif UNITY_ANDROID

		//AppsFlyer.setAppID ("YOUR_ANDROID_PACKAGE_NAME_HERE"); // un-comment this in case you are not working with the manifest file
		AppsFlyer.loadConversionData("AppsFlyerTrackerCallbacks", "didReceiveConversionData");

		#endif

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		
		if(GUI.Button(new Rect(Screen.width/2,Screen.height/2,Screen.width/8,Screen.height/8), "124event")){
			TrackRichEventTest();
		}
	}
	
	// Test in app event
	public void TrackRichEventTest() {
		print ("trackRichEventTest called");
		Dictionary<string, string> dict = new Dictionary<string, string> ();
		dict.Add ("currency", "HKD");
		dict.Add ("productId", "88734");
		dict.Add ("price", "142");
		AppsFlyer.trackRichEvent ("tutorial_completioon", dict);

		//dict.Add ("af_success", "true");
		//AppsFlyer.trackRichEvent ("add_to_wish_list", dict);
	}

}
