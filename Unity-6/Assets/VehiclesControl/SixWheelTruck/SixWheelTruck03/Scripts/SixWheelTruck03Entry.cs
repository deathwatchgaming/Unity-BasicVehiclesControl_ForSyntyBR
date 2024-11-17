/*
 * File: Six Wheel Truck 03 Entry
 * Name: SixWheelTruck03Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
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

    // public class SixWheelTruck03Entry 
    public class SixWheelTruck03Entry : MonoBehaviour
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

            [Tooltip("The six wheel truck 03 game object")]
            // GameObject _sixWheelTruck03
            [SerializeField] private GameObject _sixWheelTruck03;

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
            // bool _inSixWheelTruck03 is false
            [SerializeField] private bool _inSixWheelTruck03 = false;
        
        // SixWheelTruck03Controller _sixWheelTruck03Script
        private SixWheelTruck03Controller _sixWheelTruck03Script;
        
        // Camera _sixWheelTruck03Camera
        private Camera _sixWheelTruck03Camera;

        // AudioListener _sixWheelTruck03CameraAudioListener
        private AudioListener _sixWheelTruck03CameraAudioListener;        

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
            
            [Tooltip("The sixWheelTruck 03 compass")]
            // SixWheelTruck03Compass _sixWheelTruck03Compass
            [SerializeField] private SixWheelTruck03Compass _sixWheelTruck03Compass;  

        //public static SixWheelTruck03Entry _sixWheelTruck03Entry;
        
        // private void Start
        private void Start() 
        {
            //_sixWheelTruck03Entry = this;
            
            // _sixWheelTruck03Script is GetComponent SixWheelTruck03Controller
            _sixWheelTruck03Script = GetComponent<SixWheelTruck03Controller>();

            // _sixWheelTruck03Script enabled is false
            _sixWheelTruck03Script.enabled = false;

            // _sixWheelTruck03Camera is GetComponentInChildren Camera
            _sixWheelTruck03Camera = GetComponentInChildren<Camera>();
            
            // _sixWheelTruck03Camera enabled is false
            _sixWheelTruck03Camera.enabled = false;

            // _sixWheelTruck03CameraAudioListener is GetComponentInChildren AudioListener
            _sixWheelTruck03CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sixWheelTruck03CameraAudioListener enabled is false
            _sixWheelTruck03CameraAudioListener.enabled = false;            

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();            

            // GameObject _interfaceTextObject is FindInActiveObjectByName SixWheelTruck03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SixWheelTruck03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sixWheelTruck03Compass enabled is false
            _sixWheelTruck03Compass.enabled = false;

            // _sixWheelTruck03Compass compassEnabled is false
            _sixWheelTruck03Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SixWheelTruck03 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSixWheelTruck03 and Input GetKey KeyCode _exitKey
            if (_inSixWheelTruck03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sixWheelTruck03Script enabled is false
                _sixWheelTruck03Script.enabled = false;
                
                // _sixWheelTruck03Camera enabled is false
                _sixWheelTruck03Camera.enabled = false;

                // _sixWheelTruck03CameraAudioListener enabled is false
                _sixWheelTruck03CameraAudioListener.enabled = false; 

                // _inSixWheelTruck03 is false
                _inSixWheelTruck03 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sixWheelTruck03Compass enabled is false
                _sixWheelTruck03Compass.enabled = false;

                // _sixWheelTruck03Compass compassEnabled is false
                _sixWheelTruck03Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SixWheelTruck03 compass is disabled");         

            } // close if _inSixWheelTruck03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSixWheelTruck03 and gameObject tag is Player
            if (!_inSixWheelTruck03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSixWheelTruck03 and gameObject tag is Player
            
            // if not _inSixWheelTruck03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSixWheelTruck03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sixWheelTruck03 transform
                _player.transform.parent = _sixWheelTruck03.transform;

                // _sixWheelTruck03Script enabled is true
                _sixWheelTruck03Script.enabled = true;
                
                // _sixWheelTruck03Camera enabled is true
                _sixWheelTruck03Camera.enabled = true;

                // _sixWheelTruck03CameraAudioListener enabled is true
                _sixWheelTruck03CameraAudioListener.enabled = true;                 

                // _inSixWheelTruck03 is true
                _inSixWheelTruck03 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sixWheelTruck03Compass enabled is true
                _sixWheelTruck03Compass.enabled = true;

                // _sixWheelTruck03Compass compassEnabled is true
                _sixWheelTruck03Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SixWheelTruck03 compass is enabled");                

            } // close if not _inSixWheelTruck03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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

    } // close public class SixWheelTruck03Entry  

} // close namespace VehiclesControl
