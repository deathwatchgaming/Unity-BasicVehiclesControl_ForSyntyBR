/*
 * File: Dune Buggy 05 Entry (New Input System)
 * Name: DuneBuggy05Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// using
using UnityEngine;
using NavigationControl;
using System.Collections;
using UnityEngine.InputSystem;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class DuneBuggy05Entry 
    public class DuneBuggy05Entry : MonoBehaviour
    {
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The dune buggy 05 game object")]
            // GameObject _duneBuggy05
            [SerializeField] private GameObject _duneBuggy05;

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
            // bool _inDuneBuggy05 is false
            [SerializeField] private bool _inDuneBuggy05 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The duneBuggy 05 compass")]
            // DuneBuggy05Compass _duneBuggy05Compass
            [SerializeField] private DuneBuggy05Compass _duneBuggy05Compass;

        // Input Actions
        [Header("Input Actions")] 

            [Tooltip("The input action asset")]
            // InputActionAsset _carControls
            [SerializeField] private InputActionAsset _carControls;

        // InputAction _carEnterAction
        private InputAction _carEnterAction;

        // InputAction _carExitAction
        private InputAction _carExitAction;

        // bool _enterButton
        private bool _enterButton;

        // bool _exitButton
        private bool _exitButton;

        // DuneBuggy05Controller _duneBuggy05Script
        private DuneBuggy05Controller _duneBuggy05Script;
        
        // Camera _duneBuggy05Camera
        private Camera _duneBuggy05Camera;

        // AudioListener _duneBuggy05CameraAudioListener
        private AudioListener _duneBuggy05CameraAudioListener; 

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

        //public static DuneBuggy05Entry _duneBuggy05Entry;

        // private void Awake
        private void Awake()
        {
            // _carEnterAction
            _carEnterAction = _carControls.FindActionMap("Car").FindAction("Enter");

            // _carExitAction
            _carExitAction = _carControls.FindActionMap("Car").FindAction("Exit");

        } // close private void Awake

        // private void OnEnable
        private void OnEnable()
        {
            // _carEnterAction Enable
            _carEnterAction.Enable();

            // _carExitAction Enable
            _carExitAction.Enable();

        } // close private void OnEnable

        // private void OnDisable
        private void OnDisable()
        {
            // _carEnterAction Disable
            _carEnterAction.Disable();

            // _carExitAction Disable
            _carExitAction.Disable();  

        } // close private void OnDisable

        // private void Start
        private void Start() 
        {
            //_duneBuggy05Entry = this;
            
            // _duneBuggy05Script is GetComponent DuneBuggy05Controller
            _duneBuggy05Script = GetComponent<DuneBuggy05Controller>();

            // _duneBuggy05Script enabled is false
            _duneBuggy05Script.enabled = false;
            
            // _duneBuggy05Camera is GetComponentInChildren Camera
            _duneBuggy05Camera = GetComponentInChildren<Camera>();
            
            // _duneBuggy05Camera enabled is false
            _duneBuggy05Camera.enabled = false;
           
            // _duneBuggy05CameraAudioListener is GetComponentInChildren AudioListener
            _duneBuggy05CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _duneBuggy05CameraAudioListener enabled is false
            _duneBuggy05CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName DuneBuggy05_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("DuneBuggy05_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _duneBuggy05Compass enabled is false
            _duneBuggy05Compass.enabled = false;

            // _duneBuggy05Compass compassEnabled is false
            _duneBuggy05Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The DuneBuggy05 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if_carEnterAction triggered
            if (_carEnterAction.triggered)
            {
                // _enterButton is true
                _enterButton = true;

                // _exitButton is false
                _exitButton = false;

            } // close if_carEnterAction triggered

            // if _carExitAction triggered
            if (_carExitAction.triggered)
            {
                // _enterButton is false
                _enterButton = false;

                // _exitButton is true
                _exitButton = true;

            } // close if _carExitAction triggered
            
            // if _inDuneBuggy05 and Input GetKey KeyCode _exitKey
            if (_inDuneBuggy05 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _duneBuggy05Script enabled is false
                _duneBuggy05Script.enabled = false;
                
                // _duneBuggy05Camera enabled is false
                _duneBuggy05Camera.enabled = false;

                // _duneBuggy05CameraAudioListener enabled is false
                _duneBuggy05CameraAudioListener.enabled = false;

                // _inDuneBuggy05 is false
                _inDuneBuggy05 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _duneBuggy05Compass enabled is false
                _duneBuggy05Compass.enabled = false;

                // _duneBuggy05Compass compassEnabled is false
                _duneBuggy05Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The DuneBuggy05 compass is disabled");         

            } // close if _inDuneBuggy05 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inDuneBuggy05 and gameObject tag is Player
            if (!_inDuneBuggy05 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inDuneBuggy05 and gameObject tag is Player
            
            // if not _inDuneBuggy05 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inDuneBuggy05 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _duneBuggy05 transform
                _player.transform.parent = _duneBuggy05.transform;

                // _duneBuggy05Script enabled is true
                _duneBuggy05Script.enabled = true;
                
                // _duneBuggy05Camera enabled is true
                _duneBuggy05Camera.enabled = true;

                // _duneBuggy05CameraAudioListener enabled is true
                _duneBuggy05CameraAudioListener.enabled = true;

                // _inDuneBuggy05 is true
                _inDuneBuggy05 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _duneBuggy05Compass enabled is true
                _duneBuggy05Compass.enabled = true;

                // _duneBuggy05Compass compassEnabled is true
                _duneBuggy05Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The DuneBuggy05 compass is enabled");                

            } // close if not _inDuneBuggy05 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class DuneBuggy05Entry  

} // close namespace VehiclesControl
