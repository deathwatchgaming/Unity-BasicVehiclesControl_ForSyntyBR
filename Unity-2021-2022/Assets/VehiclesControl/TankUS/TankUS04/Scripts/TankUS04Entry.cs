/*
 * File: TankUS 04 Entry
 * Name: TankUS04Entry.cs
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

    // public class TankUS04Entry 
    public class TankUS04Entry : MonoBehaviour
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

            [Tooltip("The TankUS 04 game object")]
            // GameObject _tankUS04
            [SerializeField] private GameObject _tankUS04;

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
            // bool _inTankUS04 is false
            [SerializeField] private bool _inTankUS04 = false;
        
        // TankUS04Controller _tankUS04Script
        private TankUS04Controller _tankUS04Script;

        // Camera _tankUS04Camera
        private Camera _tankUS04Camera;

        // AudioListener _tankUS04CameraAudioListener
        private AudioListener _tankUS04CameraAudioListener; 

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
            
            [Tooltip("The tankUS 04 compass")]
            // TankUS04Compass _tankUS04Compass
            [SerializeField] private TankUS04Compass _tankUS04Compass;  

        //public static TankUS04Entry _tankUS04Entry;
        
        // private void Start
        private void Start() 
        {
            //_tankUS04Entry = this;
            
            // _tankUS04Script is GetComponent TankUS04Controller
            _tankUS04Script = GetComponent<TankUS04Controller>();

            // _tankUS04Script enabled is false
            _tankUS04Script.enabled = false;
            
            // _tankUS04Script is GetComponentInChildren
            _tankUS04Camera = GetComponentInChildren<Camera>();

            // _tankUS04Camera enabled is false
            _tankUS04Camera.enabled = false;

            // _tankUS04CameraAudioListener is GetComponentInChildren AudioListener
            _tankUS04CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankUS04CameraAudioListener enabled is false
            _tankUS04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankUS04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankUS04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _tankUS04Compass enabled is false
            _tankUS04Compass.enabled = false;

            // _tankUS04Compass compassEnabled is false
            _tankUS04Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The TankUS04 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankUS04 and Input GetKey KeyCode _exitKey
            if (_inTankUS04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankUS04Script enabled is false
                _tankUS04Script.enabled = false;
                
                // _tankUS04Camera enabled is false
                _tankUS04Camera.enabled = false;

                // _tankUS04CameraAudioListener enabled is false
                _tankUS04CameraAudioListener.enabled = false; 

                // _inTankUS04 is false
                _inTankUS04 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _tankUS04Compass enabled is false
                _tankUS04Compass.enabled = false;

                // _tankUS04Compass compassEnabled is false
                _tankUS04Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The TankUS04 compass is disabled");         

            } // close if _inTankUS04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankUS04 and gameObject tag is Player
            if (!_inTankUS04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankUS04 and gameObject tag is Player
            
            // if not _inTankUS04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankUS04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankUS04 transform
                _player.transform.parent = _tankUS04.transform;

                // _tankUS04Script enabled is true
                _tankUS04Script.enabled = true;
                
                // _tankUS04Camera enabled is true
                _tankUS04Camera.enabled = true;

                // _tankUS04CameraAudioListener enabled is true
                _tankUS04CameraAudioListener.enabled = true; 

                // _inTankUS04 is true
                _inTankUS04 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _tankUS04Compass enabled is true
                _tankUS04Compass.enabled = true;

                // _tankUS04Compass compassEnabled is true
                _tankUS04Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The TankUS04 compass is enabled");                

            } // close if not _inTankUS04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankUS04Entry  

} // close namespace VehiclesControl
