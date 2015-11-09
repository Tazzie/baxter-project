using UnityEngine;
using System.Collections;
using Uniduino;

public class BlinkyLight : MonoBehaviour {

	public Arduino arduino;

	void Start () {
		arduino = Arduino.global;
		arduino.Setup(ConfigurePins);
	}

	void ConfigurePins(){
		arduino.pinMode (13, PinMode.OUTPUT); //Set ouput pin

	}

	IEnumerator BlinkLoop(){
		while(true){
			arduino.digitalWrite(13, Arduino.HIGH); //LED ON
			yield return new WaitForSeconds(3);
			arduino.digitalWrite(13, Arduino.LOW); //LED OFF
			yield return new WaitForSeconds(3);
		}
	}


	void Update () {
	
	}
}
