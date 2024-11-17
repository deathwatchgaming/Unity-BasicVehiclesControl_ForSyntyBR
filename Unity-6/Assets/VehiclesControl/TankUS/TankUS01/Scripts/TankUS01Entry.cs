/*
 * File: TankUS 01 Entry
 * Name: TankUS01Entry.cs
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

    // public class TankUS01Entry 
    public class TankUS01Entry : MonoBehaviour
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

            [Tooltip("The tankUS01 game object")]
            // GameObject _tankUS01
            [SerializeField] private GameObject _tankUS01;

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
            // bool _inTankUS01 is false
            [SerializeField] private bool _inTankUS01 = false;
        
        // TankUS01Controller _tankUS01Script
        private TankUS01Controller _tankUS01Script;

        // Camera _tankUS01Camera
        private Camera _tankUS01Camera;

        // AudioListener _tankUS01CameraAudioListener
        private AudioListener _tankUS01CameraAudioListener; 

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
            
            [Tooltip("The tankUS 01 compass")]
            // TankUS01Compass _tankUS01Compass
            [SerializeField] private TankUS01Compass _tankUS01Compass;  

        //public static TankUS01Entry _tankUS01Entry;
        
        // private void Start
        private void Start() 
        {
            //_tankUS01Entry = this;
            
            // _tankUS01Script is GetComponent TankUS01Controller
            _tankUS01Script = GetComponent<TankUS01Controller>();

            // _tankUS01Script enabled is false
            _tankUS01Script.enabled = false;
            
            // _tankUS01Script is GetComponentInChildren
            _tankUS01Camera = GetComponentInChildren<Camera>();

            // _tankUS01Camera enabled is false
            _tankUS01Camera.enabled = false;

            // _tankUS01CameraAudioListener is GetComponentInChildren AudioListener
            _tankUS01CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankUS01CameraAudioListener enabled is false
            _tankUS01CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankUS01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankUS01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _tankUS01Compass enabled is false
            _tankUS01Compass.enabled = false;

            // _tankUS01Compass compassEnabled is false
            _tankUS01Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The TankUS01 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankUS01 and Input GetKey KeyCode _exitKey
            if (_inTankUS01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankUS01Script enabled is false
                _tankUS01Script.enabled = false;
                
                // _tankUS01Camera enabled is false
                _tankUS01Camera.enabled = false;

                // _tankUS01CameraAudioListener enabled is false
                _tankUS01CameraAudioListener.enabled = false; 

                // _inTankUS01 is false
                _inTankUS01 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _tankUS01Compass enabled is false
                _tankUS01Compass.enabled = false;

                // _tankUS01Compass compassEnabled is false
                _tankUS01Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The TankUS01 compass is disabled");         

            } // close if _inTankUS01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankUS01 and gameObject tag is Player
            if (!_inTankUS01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankUS01 and gameObject tag is Player
            
            // if not _inTankUS01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankUS01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankUS01 transform
                _player.transform.parent = _tankUS01.transform;

                // _tankUS01Script enabled is true
                _tankUS01Script.enabled = true;
                
                // _tankUS01Camera enabled is true
                _tankUS01Camera.enabled = true;

                // _tankUS01CameraAudioListener enabled is true
                _tankUS01CameraAudioListener.enabled = true; 

                // _inTankUS01 is true
                _inTankUS01 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _tankUS01Compass enabled is true
                _tankUS01Compass.enabled = true;

                // _tankUS01Compass compassEnabled is true
                _tankUS01Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The TankUS01 compass is enabled");                

            } // close if not _inTankUS01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankUS01Entry  

} // close namespace VehiclesControl
