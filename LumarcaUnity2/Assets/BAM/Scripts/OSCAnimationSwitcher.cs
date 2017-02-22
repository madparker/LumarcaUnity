using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OSCAnimationSwitcher : MonoBehaviour {

	public string OSCScene = "KinectScene"; 

	private static float timer;
	public float SwitchTime;

	public static OSCAnimationSwitcher instance;

	private bool turnOffAnimation = false;

	// Use this for initialization
	void Start () {
		if(instance == null){
			DontDestroyOnLoad(gameObject);
			instance = this;
			AnimationManager.instance.HardSwitch();
		} else {
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if(timer <= 0){
			AnimationManager.instance.enabled = true;
		}

		if(turnOffAnimation){
			turnOffAnimation = false;
			AnimationManager.instance.enabled = false;

			if(!SceneManager.GetActiveScene().name.Equals(OSCScene)){
				SceneManager.LoadScene(OSCScene);
			}
		}
	}

	public void GotOSC(){
		Debug.Log("GOT OSC");

		timer = SwitchTime;
		turnOffAnimation = true;
	}
}
