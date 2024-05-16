/*
 * File: Dune Buggy Entry
 * Name: DuneBuggyEntry.cs
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

    // public class DuneBuggyEntry 
    public class DuneBuggyEntry : MonoBehaviour
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

            [Tooltip("The dune buggy game object")]
            // GameObject _duneBuggy
            [SerializeField] private GameObject _duneBuggy;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inDuneBuggy is false
            [SerializeField] private bool _inDuneBuggy = false;
        
        // DuneBuggyController _duneBuggyScript
        private DuneBuggyController _duneBuggyScript;
        
        // Camera _duneBuggyCamera
        private Camera _duneBuggyCamera;

        // AudioListener _duneBuggyCameraAudioListener
        private AudioListener _duneBuggyCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;
        
        // private void Start
        private void Start() 
        {
            // _duneBuggyScript is GetComponent DuneBuggyController
            _duneBuggyScript = GetComponent<DuneBuggyController>();

            // _duneBuggyScript enabled is false
            _duneBuggyScript.enabled = false;
            
            // _duneBuggyCamera is GetComponentInChildren Camera
            _duneBuggyCamera = GetComponentInChildren<Camera>();
            
            // _duneBuggyCamera enabled is false
            _duneBuggyCamera.enabled = false;
           
            // _duneBuggyCameraAudioListener is GetComponentInChildren AudioListener
            _duneBuggyCameraAudioListener = GetComponentInChildren<AudioListener>();

            // _duneBuggyCameraAudioListener enabled is false
            _duneBuggyCameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find PressE
            _interfaceTextObject = GameObject.Find("DuneBuggy_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inDuneBuggy and Input GetKey KeyCode F
            if (_inDuneBuggy && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _duneBuggyScript enabled is false
                _duneBuggyScript.enabled = false;
                
                // _duneBuggyCamera enabled is false
                _duneBuggyCamera.enabled = false;

                // _duneBuggyCameraAudioListener enabled is false
                _duneBuggyCameraAudioListener.enabled = false;

                // _inDuneBuggy is false
                _inDuneBuggy = false;

            } // close if _inDuneBuggy and Input GetKey KeyCode F

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inDuneBuggy and gameObject tag is Player
            if (!_inDuneBuggy && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inDuneBuggy and gameObject tag is Player
            
            // if not _inDuneBuggy and gameObject tag is Player and Input GetKey KeyCode E
            if (!_inDuneBuggy && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _duneBuggy transform
                _player.transform.parent = _duneBuggy.transform;

                // _duneBuggyScript enabled is true
                _duneBuggyScript.enabled = true;
                
                // _duneBuggyCamera enabled is true
                _duneBuggyCamera.enabled = true;

                // _duneBuggyCameraAudioListener enabled is true
                _duneBuggyCameraAudioListener.enabled = true;

                // _inDuneBuggy is true
                _inDuneBuggy = true;

            } // close if not _inDuneBuggy and gameObject tag is Player and Input GetKey KeyCode E

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

        } // close private IEnumerator RigidbodySleep float duartion  
        
    } // close public class DuneBuggyEntry  

} // close namespace VehiclesControl
