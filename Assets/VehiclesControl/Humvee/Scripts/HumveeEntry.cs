/*
 * File: Humvee Entry
 * Name: HumveeEntry.cs
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

    // public class HumveeEntry 
    public class HumveeEntry : MonoBehaviour
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

            [Tooltip("The humvee game object")]
            // GameObject _humvee
            [SerializeField] private GameObject _humvee;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inHumvee is false
            [SerializeField] private bool _inHumvee = false;
        
        // HumveeController _humveeScript
        private HumveeController _humveeScript;

        // Camera _humveeCamera
        private Camera _humveeCamera;

        // AudioListener _humveeCameraAudioListener
        private AudioListener _humveeCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody; 

        // private void Start
        private void Start() 
        {
            // _humveeScript is GetComponent HumveeController
            _humveeScript = GetComponent<HumveeController>();

            // _humveeScript enabled is false
            _humveeScript.enabled = false;
            
            // _humveeScript is GetComponentInChildren Camera
            _humveeCamera = GetComponentInChildren<Camera>();

            // _humveeCamera enabled is false
            _humveeCamera.enabled = false;
           
            // _humveeCameraAudioListener is GetComponentInChildren AudioListener
            _humveeCameraAudioListener = GetComponentInChildren<AudioListener>();

            // _humveeCameraAudioListener enabled is false
            _humveeCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find Humvee_EntryKey
            _interfaceTextObject = GameObject.Find("Humvee_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inHumvee and Input GetKey KeyCode _exitKey
            if (_inHumvee && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _humveeScript enabled is false
                _humveeScript.enabled = false;

                // _humveeCamera enabled is false
                _humveeCamera.enabled = false;

                // _humveeCameraAudioListener enabled is false
                _humveeCameraAudioListener.enabled = false; 

                // _inHumvee is false
                _inHumvee = false;

            } // close if _inHumvee and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inHumvee and gameObject tag is Player
            if (!_inHumvee && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inHumvee and gameObject tag is Player
            
            // if not _inHumvee and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inHumvee && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _humvee transform
                _player.transform.parent = _humvee.transform;

                // _humveeScript enabled is true
                _humveeScript.enabled = true;

                // _humveeCamera enabled is true
                _humveeCamera.enabled = true;

                // _humveeCameraAudioListener enabled is true
                _humveeCameraAudioListener.enabled = true; 

                // _inHumvee is true
                _inHumvee = true;

            } // close if not _inHumvee and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class HumveeEntry  

} // close namespace VehiclesControl
