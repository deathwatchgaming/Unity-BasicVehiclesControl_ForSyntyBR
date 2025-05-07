/*
 * File: Sedan 01 Entry
 * Name: Sedan01Entry.cs
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

    // public class Sedan01Entry 
    public class Sedan01Entry : MonoBehaviour
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

            [Tooltip("The sedan 01 game object")]
            // GameObject _sedan01
            [SerializeField] private GameObject _sedan01;

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
            // bool _inSedan01 is false
            [SerializeField] private bool _inSedan01 = false;
        
        // Sedan01Controller _sedan01Script
        private Sedan01Controller _sedan01Script;

        // Camera _sedan01Camera
        private Camera _sedan01Camera;

        // AudioListener _sedan01CameraAudioListener
        private AudioListener _sedan01CameraAudioListener; 

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
            
            [Tooltip("The sedan 01 compass")]
            // Sedan01Compass _sedan01Compass
            [SerializeField] private Sedan01Compass _sedan01Compass;  

        //public static Sedan01Entry _sedan01Entry;
        
        // private void Start
        private void Start() 
        {
            //_sedan01Entry = this;
            
            // _sedan01Script is GetComponent Sedan01Controller
            _sedan01Script = GetComponent<Sedan01Controller>();

            // _sedan01Script enabled is false
            _sedan01Script.enabled = false;
            
            // _sedan01Script is GetComponentInChildren
            _sedan01Camera = GetComponentInChildren<Camera>();

            // _sedan01Camera enabled is false
            _sedan01Camera.enabled = false;

            // _sedan01CameraAudioListener is GetComponentInChildren AudioListener
            _sedan01CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedan01CameraAudioListener enabled is false
            _sedan01CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Sedan01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Sedan01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedan01Compass enabled is false
            _sedan01Compass.enabled = false;

            // _sedan01Compass compassEnabled is false
            _sedan01Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Sedan01 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedan01 and Input GetKey KeyCode _exitKey
            if (_inSedan01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedan01Script enabled is false
                _sedan01Script.enabled = false;
                
                // _sedan01Camera enabled is false
                _sedan01Camera.enabled = false;

                // _sedan01CameraAudioListener enabled is false
                _sedan01CameraAudioListener.enabled = false; 

                // _inSedan01 is false
                _inSedan01 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedan01Compass enabled is false
                _sedan01Compass.enabled = false;

                // _sedan01Compass compassEnabled is false
                _sedan01Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Sedan01 compass is disabled");         

            } // close if _inSedan01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedan01 and gameObject tag is Player
            if (!_inSedan01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedan01 and gameObject tag is Player
            
            // if not _inSedan01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedan01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedan01 transform
                _player.transform.parent = _sedan01.transform;

                // _sedan01Script enabled is true
                _sedan01Script.enabled = true;
                
                // _sedan01Camera enabled is true
                _sedan01Camera.enabled = true;

                // _sedan01CameraAudioListener enabled is true
                _sedan01CameraAudioListener.enabled = true; 

                // _inSedan01 is true
                _inSedan01 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedan01Compass enabled is true
                _sedan01Compass.enabled = true;

                // _sedan01Compass compassEnabled is true
                _sedan01Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Sedan01 compass is enabled");                

            } // close if not _inSedan01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Sedan01Entry  

} // close namespace VehiclesControl
