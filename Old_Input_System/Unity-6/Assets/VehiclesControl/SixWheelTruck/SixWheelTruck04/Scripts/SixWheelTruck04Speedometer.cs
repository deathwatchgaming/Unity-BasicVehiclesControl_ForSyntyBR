/*
 * File: Six Wheel Truck 04 Speedometer
 * Name: SixWheelTruck04Speedometer.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// using
using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;

// namespace VehiclesControl
namespace VehiclesControl
{
    // public enum SixWheelTruck04SpeedUnit
	public enum SixWheelTruck04SpeedUnit
	{
		mph,
		kmh	

	} // close public enum SixWheelTruck04SpeedUnit

	// public class SixWheelTruck04Speedometer 
	public class SixWheelTruck04Speedometer : MonoBehaviour
	{
		// Speedometer
		[Header("Speedometer")]

			[Tooltip("The speedometer needle")]
			// GameObject _needle
			[SerializeField] private GameObject _needle;

			[Tooltip("The start position")]
			// float _startPosition
			[SerializeField] private float _startPosition = 220f;

			[Tooltip("The end position")]
			// float _endPosition
			[SerializeField] private float _endPosition = -41f;

			[Tooltip("The desired position")]
			// float _desiredPosition
			[SerializeField] private float _desiredPosition;

			[Tooltip("The vehicle speed")]
			// float _vehicleSpeed
			[SerializeField] private float _vehicleSpeed = 0f;

 		// Speed Text       
		[Header("Speed Text")]

			[Tooltip("The decimal places")]
			// int _decimalPlaces 
			[SerializeField] private int _decimalPlaces = 0;

			[Tooltip("The previous text string")]
			//  string _previousText		
			[SerializeField] private string _previousText;

			[Tooltip("The speed measurement unit")]
			// SixWheelTruck04SpeedUnit _speedUnit	
			[SerializeField] private SixWheelTruck04SpeedUnit _speedUnit;

			[Tooltip("The interface speed amount text")]
			// TMP_Text speedText
			[SerializeField] private TMP_Text _speedText;

		// Game Objects
		[Header("Game Objects")]

			[Tooltip("The interface parent game object")]
			// GameObject _interfaceParentObject
			[SerializeField] private GameObject _interfaceParentObject;
			
			[Tooltip("The interface image01 speedometer guage game object")]
			// GameObject _interfaceIMG01Object
			[SerializeField] private GameObject _interfaceIMG01Object;

			[Tooltip("The interface image02 speedometer needle game object")]
			// GameObject _interfaceIMG02Object
			[SerializeField] private GameObject _interfaceIMG02Object;

			[Tooltip("The interface text speed text game object")]
			// GameObject _interfaceTextObject
			[SerializeField] private GameObject _interfaceTextObject;

		// Active State
		[Header("Active State")]

			[Tooltip("The active state bool")]
			// bool _inSixWheelTruck04 is false
			[SerializeField] private bool _inSixWheelTruck04 = false;

		// Input Customizations
		[Header("Input Customizations")] 

			[Tooltip("The vehicle entry key code")]
			// KeyCode _enterKey
			[SerializeField] private KeyCode _enterKey = KeyCode.E;	

			[Tooltip("The vehicle exit key code")]
			// KeyCode _exitKey
			[SerializeField] private KeyCode _exitKey = KeyCode.F;

		// float _currentSpeed
		float _currentSpeed;

		// SixWheelTruck04Controller _sixWheelTruck04Script
		private SixWheelTruck04Controller _sixWheelTruck04Script;

		// Rigidbody _rigidbody
		private Rigidbody _rigidbody;

		// GameObject FindInActiveObjectByName
		GameObject FindInActiveObjectByName(string name)
		{
			// Transform[] objs
			Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];

			// for
			for (int i = 0; i < objs.Length; i++)
			{
				// if
				if (objs[i].hideFlags == HideFlags.None)
				{
					// if
					if (objs[i].name == name)
					{
						// return
						return objs[i].gameObject;

					} // close if

				} // close if

			} // close for

			// return
			return null;

		} // close GameObject FindInActiveObjectByName

		// private void Start
		private void Start()
		{
			// _sixWheelTruck04Script is GetComponent SixWheelTruck04Controller
			_sixWheelTruck04Script = GetComponent<SixWheelTruck04Controller>();

			// _rigidbody
			_rigidbody = GetComponent<Rigidbody>();

			// GameObject _interfaceIMG01Object is FindInActiveObjectByName SixWheelTruck04_SpeedoGuage
			GameObject _interfaceIMG01Object = FindInActiveObjectByName("SixWheelTruck04_SpeedoGuage");

			// _interfaceIMG01Object SetActive is false
			_interfaceIMG01Object.SetActive(false);

			// GameObject _interfaceIMG02Object is FindInActiveObjectByName SixWheelTruck04_SpeedoNeedle
			GameObject _interfaceIMG02Object = FindInActiveObjectByName("SixWheelTruck04_SpeedoNeedle");

			// _interfaceIMG02Object SetActive is false
			_interfaceIMG02Object.SetActive(false);	

			// GameObject _interfaceTextObject is FindInActiveObjectByName SixWheelTruck04_SpeedText
			GameObject _interfaceTextObject = FindInActiveObjectByName("SixWheelTruck04_SpeedText");

			// _interfaceTextObject SetActive is false
			_interfaceTextObject.SetActive(false);			

			// GameObject _interfaceParentObject is FindInActiveObjectByName SixWheelTruck04Speedometer
			GameObject _interfaceParentObject = FindInActiveObjectByName("SixWheelTruck04Speedometer");

			// _interfaceParentObject SetActive is false
			_interfaceParentObject.SetActive(false);

		} // close private void Start

		// private void Update
		private void Update()
		{
			// if _speedUnit equals SixWheelTruck04SpeedUnit.mph
			if (_speedUnit == SixWheelTruck04SpeedUnit.mph)
			{
				// 2.23694 is the constant to convert a value from m/s to mph

				// _currentSpeed
				_currentSpeed = (float)Math.Round(_rigidbody.linearVelocity.magnitude * 2.23694f, _decimalPlaces);

				// _speedText.text
				_speedText.text = _previousText + _currentSpeed.ToString() + " mph";

			} // close if _speedUnit equals SixWheelTruck04SpeedUnit.mph

			// else 
			else 
			{
				// 3.6 is the constant to convert a value from m/s to km/h

				// _currentSpeed
				_currentSpeed = (float)Math.Round(_rigidbody.linearVelocity.magnitude * 3.6f, _decimalPlaces);

				// _speedText.text
				_speedText.text = _previousText + _currentSpeed.ToString() + " km/h";

			} // close else

			// if _inSixWheelTruck04 and Input GetKey KeyCode _exitKey
			if (_inSixWheelTruck04 && Input.GetKey(_exitKey))
			{
				// _inSixWheelTruck04 is false
				_inSixWheelTruck04 = false;

			} // close if _inSixWheelTruck04 and Input GetKey KeyCode _exitKey

		} // close private void Update

		// private void FixedUpdate
		private void FixedUpdate()
		{
			// _vehicleSpeed
			_vehicleSpeed = _currentSpeed;

			// UpdateSpeedoNeedle
			UpdateSpeedoNeedle();

		} // close private void FixedUpdate

		// private void UpdateSpeedoNeedle
		private void UpdateSpeedoNeedle()
		{
			// _desiredPosition
			_desiredPosition = _startPosition - _endPosition;

			// float _temp 
			float _temp = _vehicleSpeed / 180;

			// _needle.transform.eulerAngles
			_needle.transform.eulerAngles = new Vector3(0, 0, (_startPosition -_temp * _desiredPosition));

		} // close private void UpdateSpeedoNeedle

		// private void OnTriggerStay Collider other
		private void OnTriggerStay(Collider other)
		{
			// if not _inSixWheelTruck04 and gameObject tag is Player
			if (!_inSixWheelTruck04 && other.gameObject.tag == "Player")
			{
				// _interfaceIMG01Object SetActive is false
				_interfaceIMG01Object.SetActive(false);

				// _interfaceIMG02Object SetActive is false
				_interfaceIMG02Object.SetActive(false);

				// _interfaceTextObject SetActive is false
				_interfaceTextObject.SetActive(false);	

				// _interfaceParentObject SetActive is false
				_interfaceParentObject.SetActive(false);

			} // close if not _inSixWheelTruck04 and gameObject tag is Player

			// if not _inSixWheelTruck04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
			if (!_inSixWheelTruck04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
			{
				// _interfaceIMG01Object SetActive is true
				_interfaceIMG01Object.SetActive(true);

				// _interfaceIMG02Object SetActive is true
				_interfaceIMG02Object.SetActive(true);

				// _interfaceTextObject SetActive is true
				_interfaceTextObject.SetActive(true);

				// _interfaceParentObject SetActive is true
				_interfaceParentObject.SetActive(true);

				// _inSixWheelTruck04 is true
				_inSixWheelTruck04 = true;					

			} // close if not _inSixWheelTruck04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

		} // close private void OnTriggerStay Collider other

		// private void OnTriggerExit Collider other
		private void OnTriggerExit(Collider other)
		{
			// if gameObject tag is Player
			if (other.gameObject.tag == "Player")
			{
				// _interfaceIMG01Object SetActive is false
				_interfaceIMG01Object.SetActive(false);

				// _interfaceIMG02Object SetActive is false
				_interfaceIMG02Object.SetActive(false);

				// _interfaceTextObject SetActive is false
				_interfaceTextObject.SetActive(false);			

				// _interfaceParentObject SetActive is false
				_interfaceParentObject.SetActive(false);

			} // close if gameObject tag is Player

		} // close private void OnTriggerExit Collider other

	} // close public class SixWheelTruck04Speedometer

} // close namespace VehiclesControl
