/*
 * File: Armored Truck Entry 
 * Name: ArmoredTruckEntry.cs
 * Author: DeathwatchGaming
 * License: MIT
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class ArmoredTruckEntry 
    public class ArmoredTruckEntry : MonoBehaviour
    {  
        // Input Customizations
        [Header("Input Customizations")] 

            [Tooltip("The vehicle entry key code")]
            // KeyCode _enterKey
            [SerializeField] private KeyCode _enterKey = KeyCode.E;

            [Tooltip("The vehicle exit key code")]
            // KeyCode _exitKey
            [SerializeField] private KeyCode _exitKey = KeyCode.F;

        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The armored truck game object")]
        	// GameObject _armoredTruck
        	[SerializeField] private GameObject _armoredTruck;

            [Tooltip("The player game object")]
        	// GameObject _player
        	[SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
        	// bool _inArmoredTruck is false
        	[SerializeField] private bool _inArmoredTruck = false;
        
        // ArmoredTruckController _armoredTruckScript
        private ArmoredTruckController _armoredTruckScript;
        
        // Camera _armoredTruckCamera
        private Camera _armoredTruckCamera;

        // AudioListener _armoredTruckCameraAudioListener
        private AudioListener _armoredTruckCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;

        // private void Start
        private void Start() 
        {
        	// _armoredTruckScript is GetComponent ArmoredTruckController
            _armoredTruckScript = GetComponent<ArmoredTruckController>();

            // _armoredTruckScript enabled is false
            _armoredTruckScript.enabled = false;
            
            // _armoredTruckCamera is GetComponentInChildren Camera
            _armoredTruckCamera = GetComponentInChildren<Camera>();
            
            // _armoredTruckCamera enabled is false
            _armoredTruckCamera.enabled = false;

            // _armoredTruckCameraAudioListener is GetComponentInChildren AudioListener
            _armoredTruckCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _armoredTruckCameraAudioListener enabled is false
            _armoredTruckCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find PressE
            _interfaceTextObject = GameObject.Find("ArmoredTruck_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

    	} // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inArmoredTruck and Input GetKey KeyCode F
            if (_inArmoredTruck && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _armoredTruckScript enabled is false
                _armoredTruckScript.enabled = false;
                
                // _armoredTruckCamera enabled is false
                _armoredTruckCamera.enabled = false;

                // _armoredTruckCameraAudioListener enabled is false
                _armoredTruckCameraAudioListener.enabled = false;                 

                // _inArmoredTruck is false
                _inArmoredTruck = false;

            } // close if _inArmoredTruck and Input GetKey KeyCode F

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
        	// if not _inArmoredTruck and gameObject tag is Player
            if (!_inArmoredTruck && other.gameObject.tag == "Player")
            {
            	// _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inArmoredTruck and gameObject tag is Player
            
            // if not _inArmoredTruck and gameObject tag is Player and Input GetKey KeyCode E
            if (!_inArmoredTruck && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _armoredTruck transform
                _player.transform.parent = _armoredTruck.transform;

                // _armoredTruckScript enabled is true
                _armoredTruckScript.enabled = true;
                
                // _armoredTruckCamera enabled is true
                _armoredTruckCamera.enabled = true;

                // _armoredTruckCameraAudioListener enabled is true
                _armoredTruckCameraAudioListener.enabled = true; 

                // _inArmoredTruck is true
                _inArmoredTruck = true;

            } // close if not _inArmoredTruck and gameObject tag is Player and Input GetKey KeyCode E

        } // close private void OnTriggerStay Collider other
        
        // private void OnTriggerExit Collider other
        private void OnTriggerExit(Collider other)
        {
        	// if gameObject tag is Player
            if (other.gameObject.tag == "Player")
            {
            	// _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);
                
                // StartCoroutine RigidbodySleep
                StartCoroutine(RigidbodySleep(0.000001f)); 

            } // close if gameObject tag is Player

        } // close private void OnTriggerExit Collider other

        // private IEnumerator RigidbodySleep float duration
        private IEnumerator RigidbodySleep(float duration) 
        {
            // WaitForSeconds duration
            yield return new WaitForSeconds(duration);
            
            // _rigidbody Sleep
            _rigidbody.Sleep();

        } // close private IEnumerator RigidbodySleep float duartion  
        
    } // close public class ArmoredTruckEntry  

} // close namespace VehiclesControl
