using UnityEngine;
using System.Collections;

public class AppsFlyerRuntime : MonoBehaviour {

	// Use this for initialization
	void Start () {

		AppsFlyer.setAppsFlyerKey ("L9sqRDPwTRURnhNNsyNagS"); 
		AppsFlyer.setAppID ("com.nxtomo.flyer.test"); 
		//AppsFlyer.setCollectIMEI (false);
		//AppsFlyer.setCollectAndroidID (false); 
		AppsFlyer.trackAppLaunch (); 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
