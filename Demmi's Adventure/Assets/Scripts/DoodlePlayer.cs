﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DoodlePlayer : MonoBehaviour {
	float movement = 0f;
	public float movementSpeed = 10f;
	// public int numObjToBeInstantiates = 3;

	Rigidbody2D _rigidbody;

	// Game Objects
	// public GameObject objToBeInstantiate;

	// Use this for initialization
	void Start () {
		_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal")*movementSpeed;
		// if(Input.GetMouseButtonDown(0)&&(numObjToBeInstantiates>0)){
		// 	InistantiateSomeObj();
    	// }
	}

	void FixedUpdate(){
		Vector2 velocity = _rigidbody.velocity;
		velocity.x =movement;
		_rigidbody.velocity = velocity;
	}

	// void InistantiateSomeObj(){
	// 	Vector3 mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
	// 	mousePos.z=0;
	// 	// Vector3 spawnPosition = new Vector3();
	// 	// spawnPosition.y = mousePos.y;
	// 	// spawnPosition.x = mousePos.x;
	// 	// Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
	// 	Instantiate(objToBeInstantiate, mousePos, Quaternion.identity);
	// 	numObjToBeInstantiates-=1;
	// }

}