using UnityEngine;
using System.Collections;
using Leap;


public class HandTrackerPosition : MonoBehaviour{
	Controller controller;
	const float CoordinateScale = 1.0f / 200;
	public GameObject handPrefab;
	GameObject[] hand;
	public int handIndex;

	public int startingPitch = 1;
	AudioSource audio;




	void Start()
	{
		controller = new Controller();

		audio = GetComponent<AudioSource>();
		audio.pitch = startingPitch;




	}

	void Update(){
		Frame frame = controller.Frame ();
		if(frame.Hands.Count > 0){
			Hand hand = frame.Hands[0];
		}
		Vector handCenter = frame.Hands[0].PalmPosition;
		Debug.Log(handCenter);

	

		audio.pitch = startingPitch * (handCenter.y / 100f); 




	}








}