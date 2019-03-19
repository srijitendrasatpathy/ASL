using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VincentController : MonoBehaviour {

	//Declaring game components required.
	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator>();
	}

	//Method to map words to animations
	public void VincentActions(string ActionCommands){
		switch(ActionCommands.Replace(" ","")){
			
			case "hello":
				anim.Play("hello",-1,0f);
				break;
			case "hi":
				anim.Play("hello",-1,0f);
				break;
			case "hey":
				anim.Play("hello",-1,0f);
				break;
			case "wave":
				anim.Play("wave",-1,0f);
				break;
			case "def":
				anim.Play("deaf",-1,0f);
				break;
			case "goodbye":
				anim.Play("goodbye",-1,0f);
				break;
			case "you":
				anim.Play("you",-1,0f);
				break;
			case "know":
				anim.Play("know",-1,0f);
				break;
			case "me":
				anim.Play("me",-1,0f);
				break;
			case "yes":
				anim.Play("yes",-1,0f);
				break;	
			default:
				anim.Play("ideal",-1,0f);
				break;

		}
	}
}
