/*
 * File: Sedan 02 Entry
 * Name: Sedan02Entry.cs
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

    // public class Sedan02Entry 
    public class Sedan02Entry : MonoBehaviour
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

            [Tooltip("The sedan 02 game object")]
            // GameObject _sedan02
            [SerializeField] private GameObject _sedan02;

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
            // bool _inSedan02 is false
            [SerializeField] private bool _inSedan02 = false;
        
        // Sedan02Controller _sedan02Script
        private Sedan02Controller _sedan02Script;

        // Camera _sedan02Camera
        private Camera _sedan02Camera;

        // AudioListener _sedan02CameraAudioListener
        private AudioListener _sedan02CameraAudioListener; 

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
            
            [Tooltip("The sedan 02 compass")]
            // Sedan02Compass _sedan02Compass
            [SerializeField] private Sedan02Compass _sedan02Compass;  

        //public static Sedan02Entry _sedan02Entry;
        
        // private void Start
        private void Start() 
        {
            //_sedan02Entry = this;
            
            // _sedan02Script is GetComponent Sedan02Controller
            _sedan02Script = GetComponent<Sedan02Controller>();

            // _sedan02Script enabled is false
            _sedan02Script.enabled = false;
            
            // _sedan02Script is GetComponentInChildren
            _sedan02Camera = GetComponentInChildren<Camera>();

            // _sedan02Camera enabled is false
            _sedan02Camera.enabled = false;

            // _sedan02CameraAudioListener is GetComponentInChildren AudioListener
            _sedan02CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedan02CameraAudioListener enabled is false
            _sedan02CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Sedan02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Sedan02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedan02Compass enabled is false
            _sedan02Compass.enabled = false;

            // _sedan02Compass compassEnabled is false
            _sedan02Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Sedan02 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedan02 and Input GetKey KeyCode _exitKey
            if (_inSedan02 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedan02Script enabled is false
                _sedan02Script.enabled = false;
                
                // _sedan02Camera enabled is false
                _sedan02Camera.enabled = false;

                // _sedan02CameraAudioListener enabled is false
                _sedan02CameraAudioListener.enabled = false; 

                // _inSedan02 is false
                _inSedan02 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedan02Compass enabled is false
                _sedan02Compass.enabled = false;

                // _sedan02Compass compassEnabled is false
                _sedan02Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Sedan02 compass is disabled");         

            } // close if _inSedan02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedan02 and gameObject tag is Player
            if (!_inSedan02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedan02 and gameObject tag is Player
            
            // if not _inSedan02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedan02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedan02 transform
                _player.transform.parent = _sedan02.transform;

                // _sedan02Script enabled is true
                _sedan02Script.enabled = true;
                
                // _sedan02Camera enabled is true
                _sedan02Camera.enabled = true;

                // _sedan02CameraAudioListener enabled is true
                _sedan02CameraAudioListener.enabled = true; 

                // _inSedan02 is true
                _inSedan02 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedan02Compass enabled is true
                _sedan02Compass.enabled = true;

                // _sedan02Compass compassEnabled is true
                _sedan02Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Sedan02 compass is enabled");                

            } // close if not _inSedan02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Sedan02Entry  

} // close namespace VehiclesControl
