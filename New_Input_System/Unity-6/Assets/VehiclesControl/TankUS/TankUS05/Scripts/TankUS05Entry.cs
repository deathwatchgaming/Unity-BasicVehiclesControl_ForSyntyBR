/*
 * File: TankUS 05 Entry
 * Name: TankUS05Entry.cs
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

    // public class TankUS05Entry 
    public class TankUS05Entry : MonoBehaviour
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

            [Tooltip("The TankUS 05 game object")]
            // GameObject _tankUS05
            [SerializeField] private GameObject _tankUS05;

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
            // bool _inTankUS05 is false
            [SerializeField] private bool _inTankUS05 = false;
        
        // TankUS05Controller _tankUS05Script
        private TankUS05Controller _tankUS05Script;

        // Camera _tankUS05Camera
        private Camera _tankUS05Camera;

        // AudioListener _tankUS05CameraAudioListener
        private AudioListener _tankUS05CameraAudioListener; 

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
            
            [Tooltip("The tankUS 05 compass")]
            // TankUS05Compass _tankUS05Compass
            [SerializeField] private TankUS05Compass _tankUS05Compass;  

        //public static TankUS05Entry _tankUS05Entry;
        
        // private void Start
        private void Start() 
        {
            //_tankUS05Entry = this;
            
            // _tankUS05Script is GetComponent TankUS05Controller
            _tankUS05Script = GetComponent<TankUS05Controller>();

            // _tankUS05Script enabled is false
            _tankUS05Script.enabled = false;
            
            // _tankUS05Script is GetComponentInChildren
            _tankUS05Camera = GetComponentInChildren<Camera>();

            // _tankUS05Camera enabled is false
            _tankUS05Camera.enabled = false;

            // _tankUS05CameraAudioListener is GetComponentInChildren AudioListener
            _tankUS05CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankUS05CameraAudioListener enabled is false
            _tankUS05CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankUS05_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankUS05_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _tankUS05Compass enabled is false
            _tankUS05Compass.enabled = false;

            // _tankUS05Compass compassEnabled is false
            _tankUS05Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The TankUS05 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankUS05 and Input GetKey KeyCode _exitKey
            if (_inTankUS05 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankUS05Script enabled is false
                _tankUS05Script.enabled = false;
                
                // _tankUS05Camera enabled is false
                _tankUS05Camera.enabled = false;

                // _tankUS05CameraAudioListener enabled is false
                _tankUS05CameraAudioListener.enabled = false; 

                // _inTankUS05 is false
                _inTankUS05 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _tankUS05Compass enabled is false
                _tankUS05Compass.enabled = false;

                // _tankUS05Compass compassEnabled is false
                _tankUS05Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The TankUS05 compass is disabled");         

            } // close if _inTankUS05 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankUS05 and gameObject tag is Player
            if (!_inTankUS05 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankUS05 and gameObject tag is Player
            
            // if not _inTankUS05 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankUS05 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankUS05 transform
                _player.transform.parent = _tankUS05.transform;

                // _tankUS05Script enabled is true
                _tankUS05Script.enabled = true;
                
                // _tankUS05Camera enabled is true
                _tankUS05Camera.enabled = true;

                // _tankUS05CameraAudioListener enabled is true
                _tankUS05CameraAudioListener.enabled = true; 

                // _inTankUS05 is true
                _inTankUS05 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _tankUS05Compass enabled is true
                _tankUS05Compass.enabled = true;

                // _tankUS05Compass compassEnabled is true
                _tankUS05Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The TankUS05 compass is enabled");                

            } // close if not _inTankUS05 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankUS05Entry  

} // close namespace VehiclesControl
