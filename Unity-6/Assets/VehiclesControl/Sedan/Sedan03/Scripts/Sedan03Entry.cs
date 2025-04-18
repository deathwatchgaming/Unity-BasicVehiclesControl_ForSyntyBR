
/*
 * File: Sedan 03 Entry
 * Name: Sedan03Entry.cs
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

    // public class Sedan03Entry 
    public class Sedan03Entry : MonoBehaviour
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

            [Tooltip("The sedan 03 game object")]
            // GameObject _sedan03
            [SerializeField] private GameObject _sedan03;

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
            // bool _inSedan03 is false
            [SerializeField] private bool _inSedan03 = false;
        
        // Sedan03Controller _sedan03Script
        private Sedan03Controller _sedan03Script;

        // Camera _sedan03Camera
        private Camera _sedan03Camera;

        // AudioListener _sedan03CameraAudioListener
        private AudioListener _sedan03CameraAudioListener; 

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
            
            [Tooltip("The sedan 03 compass")]
            // Sedan03Compass _sedan03Compass
            [SerializeField] private Sedan03Compass _sedan03Compass;  

        //public static Sedan03Entry _sedan03Entry;
        
        // private void Start
        private void Start() 
        {
            //_sedan03Entry = this;
            
            // _sedan03Script is GetComponent Sedan03Controller
            _sedan03Script = GetComponent<Sedan03Controller>();

            // _sedan03Script enabled is false
            _sedan03Script.enabled = false;
            
            // _sedan03Script is GetComponentInChildren
            _sedan03Camera = GetComponentInChildren<Camera>();

            // _sedan03Camera enabled is false
            _sedan03Camera.enabled = false;

            // _sedan03CameraAudioListener is GetComponentInChildren AudioListener
            _sedan03CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedan03CameraAudioListener enabled is false
            _sedan03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Sedan03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Sedan03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedan03Compass enabled is false
            _sedan03Compass.enabled = false;

            // _sedan03Compass compassEnabled is false
            _sedan03Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Sedan03 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedan03 and Input GetKey KeyCode _exitKey
            if (_inSedan03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedan03Script enabled is false
                _sedan03Script.enabled = false;
                
                // _sedan03Camera enabled is false
                _sedan03Camera.enabled = false;

                // _sedan03CameraAudioListener enabled is false
                _sedan03CameraAudioListener.enabled = false; 

                // _inSedan03 is false
                _inSedan03 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedan03Compass enabled is false
                _sedan03Compass.enabled = false;

                // _sedan03Compass compassEnabled is false
                _sedan03Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Sedan03 compass is disabled");         

            } // close if _inSedan03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedan03 and gameObject tag is Player
            if (!_inSedan03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedan03 and gameObject tag is Player
            
            // if not _inSedan03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedan03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedan03 transform
                _player.transform.parent = _sedan03.transform;

                // _sedan03Script enabled is true
                _sedan03Script.enabled = true;
                
                // _sedan03Camera enabled is true
                _sedan03Camera.enabled = true;

                // _sedan03CameraAudioListener enabled is true
                _sedan03CameraAudioListener.enabled = true; 

                // _inSedan03 is true
                _inSedan03 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedan03Compass enabled is true
                _sedan03Compass.enabled = true;

                // _sedan03Compass compassEnabled is true
                _sedan03Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Sedan03 compass is enabled");                

            } // close if not _inSedan03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Sedan03Entry  

} // close namespace VehiclesControl
