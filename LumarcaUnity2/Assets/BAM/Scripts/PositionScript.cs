﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScript : MonoBehaviour {

	private Vector3 headPosition;
	public Vector3 HeadPosition{
		set{
			headPosition = value;
		}
	}

	private Vector3 topTorsoPosition;
	public Vector3 TopTorsoPosition{		
		set{
			topTorsoPosition = value;
		}
	}

	private Vector3 bottomTorsoPosition;
	public Vector3 BottomTorsoPosition{		
		set{
			bottomTorsoPosition = value;
		}
	}
		
	private Vector3 leftHandPosition;
	public Vector3 LeftHandPosition{
		set{
			leftHandPosition = value;
		}
	}

	private Vector3 rightHandPosition;
	public Vector3 RightHandPosition{
		set{
			rightHandPosition = value;
		}
	}


	private Vector3 leftFootPosition;
	public Vector3 LeftFootPosition{
		set{
			leftFootPosition = value;
		}
	}

	private Vector3 rightFootPosition;
	public Vector3 RightFootPosition{
		set{
			rightFootPosition = value;
		}
	}

	private Vector3 leftElbowPosition;
	public Vector3 LeftElbowPosition{
		set{
			leftElbowPosition = value;
		}
	}

	private Vector3 rightElbowPosition;
	public Vector3 RightElbowPosition{
		set{
			rightElbowPosition = value;
		}
	}

	private Vector3 leftKneePosition;
	public Vector3 LeftKneePosition{
		set{
			leftKneePosition = value;
		}
	}

	private Vector3 rightKneePosition;
	public Vector3 RightKneePosition{
		set{
			rightKneePosition = value;
		}
	}


	public GameObject head;
	public GameObject topTorso;
	public GameObject bottomTorso;
	public GameObject rightHand;
	public GameObject leftHand;
	public GameObject rightFoot;
	public GameObject leftFoot;
	public GameObject rightKnee;
	public GameObject leftKnee;
	public GameObject rightElbow;
	public GameObject leftElbow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		head.transform.position = headPosition;
		topTorso.transform.position = topTorsoPosition;
		bottomTorso.transform.position = bottomTorsoPosition;
		rightHand.transform.position = rightHandPosition;
		leftHand.transform.position = leftHandPosition;
		rightFoot.transform.position = rightFootPosition;
		leftFoot.transform.position = leftFootPosition;
		rightKnee.transform.position = rightKneePosition;
		leftKnee.transform.position = leftKneePosition;
		rightElbow.transform.position = rightElbowPosition;
		leftElbow.transform.position = leftElbowPosition;
	}
}