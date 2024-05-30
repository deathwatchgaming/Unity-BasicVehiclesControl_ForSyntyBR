/*
 * File: Six Wheel Truck Entry
 * Name: SixWheelTruckEntry.cs
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

    // public class SixWheelTruckEntry 
    public class SixWheelTruckEntry : MonoBehaviour
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

            [Tooltip("The six wheel truck game object")]
            // GameObject _sixWheelTruck
            [SerializeField] private GameObject _sixWheelTruck;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSixWheelTruck is false
            [SerializeField] private bool _inSixWheelTruck = false;
        
        // SixWheelTruckController _sixWheelTruckScript
        private SixWheelTruckController _sixWheelTruckScript;
        
        // Camera _sixWheelTruckCamera
        private Camera _sixWheelTruckCamera;

        // AudioListener _sixWheelTruckCameraAudioListener
        private AudioListener _sixWheelTruckCameraAudioListener;        

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;  

        // private void Start
        private void Start() 
        {
            // _sixWheelTruckScript is GetComponent SixWheelTruckController
            _sixWheelTruckScript = GetComponent<SixWheelTruckController>();

            // _sixWheelTruckScript enabled is false
            _sixWheelTruckScript.enabled = false;

            // _sixWheelTruckCamera is GetComponentInChildren Camera
            _sixWheelTruckCamera = GetComponentInChildren<Camera>();
            
            // _sixWheelTruckCamera enabled is false
            _sixWheelTruckCamera.enabled = false;

            // _sixWheelTruckCameraAudioListener is GetComponentInChildren AudioListener
            _sixWheelTruckCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sixWheelTruckCameraAudioListener enabled is false
            _sixWheelTruckCameraAudioListener.enabled = false;            

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();            

            // _interfaceTextObject is GameObject Find SixWheelTruck_EntryKey
            _interfaceTextObject = GameObject.Find("SixWheelTruck_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSixWheelTruck and Input GetKey KeyCode _exitKey
            if (_inSixWheelTruck && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sixWheelTruckScript enabled is false
                _sixWheelTruckScript.enabled = false;
                
                // _sixWheelTruckCamera enabled is false
                _sixWheelTruckCamera.enabled = false;

                // _sixWheelTruckCameraAudioListener enabled is false
                _sixWheelTruckCameraAudioListener.enabled = false; 

                // _inSixWheelTruck is false
                _inSixWheelTruck = false;

            } // close if _inSixWheelTruck and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSixWheelTruck and gameObject tag is Player
            if (!_inSixWheelTruck && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSixWheelTruck and gameObject tag is Player
            
            // if not _inSixWheelTruck and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSixWheelTruck && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sixWheelTruck transform
                _player.transform.parent = _sixWheelTruck.transform;

                // _sixWheelTruckScript enabled is true
                _sixWheelTruckScript.enabled = true;
                
                // _sixWheelTruckCamera enabled is true
                _sixWheelTruckCamera.enabled = true;

                // _sixWheelTruckCameraAudioListener enabled is true
                _sixWheelTruckCameraAudioListener.enabled = true;                 

                // _inSixWheelTruck is true
                _inSixWheelTruck = true;

            } // close if not _inSixWheelTruck and gameObject tag is Player and Input GetKey KeyCode _enterKey

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

        } // close private IEnumerator RigidbodySleep float duration

    } // close public class SixWheelTruckEntry  

} // close namespace VehiclesControl
