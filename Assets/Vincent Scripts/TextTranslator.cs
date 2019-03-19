using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTranslator : MonoBehaviour {

	public InputField Field;
	public VincentController VincentControllerObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Button_Click(){
		VincentControllerObj.VincentActions(Field.text);
	}
}
