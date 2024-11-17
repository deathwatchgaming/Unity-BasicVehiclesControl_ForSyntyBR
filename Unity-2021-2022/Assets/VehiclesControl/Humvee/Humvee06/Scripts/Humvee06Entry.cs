/*
 * File: Humvee 06 Entry
 * Name: Humvee06Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
 */

// using
using UnityEngine;
using System.Collections;
using NavigationControl;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class Humvee06Entry 
    public class Humvee06Entry : MonoBehaviour
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

            [Tooltip("The humvee 06 game object")]
            // GameObject _humvee06
            [SerializeField] private GameObject _humvee06;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;

        // Rigidbody Sleep
        [Header("Rigidbody Sleep")]

            [Tooltip("The rigidbody sleep wait for seconds duration")]
            // float duration is 0.0001
            [SerializeField] private float duration = 0.0001f; 
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inHumvee06 is false
            [SerializeField] private bool _inHumvee06 = false;
        
        // Humvee06Controller _humvee06Script
        private Humvee06Controller _humvee06Script;

        // Camera _humvee06Camera
        private Camera _humvee06Camera;

        // AudioListener _humvee06CameraAudioListener
        private AudioListener _humvee06CameraAudioListener; 

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

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The humvee 06 compass")]
            // Humvee06Compass _humvee06Compass
            [SerializeField] private Humvee06Compass _humvee06Compass;  

        //public static Humvee06Entry _humvee06Entry;
        
        // private void Start
        private void Start() 
        {
            //_humvee06Entry = this;
            
            // _humvee06Script is GetComponent Humvee06Controller
            _humvee06Script = GetComponent<Humvee06Controller>();

            // _humvee06Script enabled is false
            _humvee06Script.enabled = false;
            
            // _humvee06Script is GetComponentInChildren Camera
            _humvee06Camera = GetComponentInChildren<Camera>();

            // _humvee06Camera enabled is false
            _humvee06Camera.enabled = false;
           
            // _humvee06CameraAudioListener is GetComponentInChildren AudioListener
            _humvee06CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _humvee06CameraAudioListener enabled is false
            _humvee06CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Humvee06_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Humvee06_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _humvee06Compass enabled is false
            _humvee06Compass.enabled = false;

            // _humvee06Compass compassEnabled is false
            _humvee06Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Humvee06 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inHumvee06 and Input GetKey KeyCode _exitKey
            if (_inHumvee06 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _humvee06Script enabled is false
                _humvee06Script.enabled = false;

                // _humvee06Camera enabled is false
                _humvee06Camera.enabled = false;

                // _humvee06CameraAudioListener enabled is false
                _humvee06CameraAudioListener.enabled = false; 

                // _inHumvee06 is false
                _inHumvee06 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _humvee06Compass enabled is false
                _humvee06Compass.enabled = false;

                // _humvee06Compass compassEnabled is false
                _humvee06Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Humvee06 compass is disabled");         

            } // close if _inHumvee06 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inHumvee06 and gameObject tag is Player
            if (!_inHumvee06 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inHumvee06 and gameObject tag is Player
            
            // if not _inHumvee06 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inHumvee06 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _humvee06 transform
                _player.transform.parent = _humvee06.transform;

                // _humvee06Script enabled is true
                _humvee06Script.enabled = true;

                // _humvee06Camera enabled is true
                _humvee06Camera.enabled = true;

                // _humvee06CameraAudioListener enabled is true
                _humvee06CameraAudioListener.enabled = true; 

                // _inHumvee06 is true
                _inHumvee06 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _humvee06Compass enabled is true
                _humvee06Compass.enabled = true;

                // _humvee06Compass compassEnabled is true
                _humvee06Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Humvee06 compass is enabled");                

            } // close if not _inHumvee06 and gameObject tag is Player and Input GetKey KeyCode _enterKey

        } // close private void OnTriggerStay Collider other
        
        // private void OnTriggerExit Collider other
        private void OnTriggerExit(Collider other)
        {
            // if gameObject tag is Player
            if (other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);
                
                // StartCoroutine RigidbodySleep duration
                StartCoroutine(RigidbodySleep(duration)); 

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
        
    } // close public class Humvee06Entry  

} // close namespace VehiclesControl
