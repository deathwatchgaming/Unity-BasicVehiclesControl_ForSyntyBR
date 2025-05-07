/*
 * File: Dune Buggy 04 Entry (New Input System)
 * Name: DuneBuggy04Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
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

    // public class DuneBuggy04Entry 
    public class DuneBuggy04Entry : MonoBehaviour
    {
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The dune buggy 04 game object")]
            // GameObject _duneBuggy04
            [SerializeField] private GameObject _duneBuggy04;

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
            // bool _inDuneBuggy04 is false
            [SerializeField] private bool _inDuneBuggy04 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The duneBuggy 04 compass")]
            // DuneBuggy04Compass _duneBuggy04Compass
            [SerializeField] private DuneBuggy04Compass _duneBuggy04Compass;

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

        // DuneBuggy04Controller _duneBuggy04Script
        private DuneBuggy04Controller _duneBuggy04Script;
        
        // Camera _duneBuggy04Camera
        private Camera _duneBuggy04Camera;

        // AudioListener _duneBuggy04CameraAudioListener
        private AudioListener _duneBuggy04CameraAudioListener; 

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

        //public static DuneBuggy04Entry _duneBuggy04Entry;

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
            //_duneBuggy04Entry = this;
            
            // _duneBuggy04Script is GetComponent DuneBuggy04Controller
            _duneBuggy04Script = GetComponent<DuneBuggy04Controller>();

            // _duneBuggy04Script enabled is false
            _duneBuggy04Script.enabled = false;
            
            // _duneBuggy04Camera is GetComponentInChildren Camera
            _duneBuggy04Camera = GetComponentInChildren<Camera>();
            
            // _duneBuggy04Camera enabled is false
            _duneBuggy04Camera.enabled = false;
           
            // _duneBuggy04CameraAudioListener is GetComponentInChildren AudioListener
            _duneBuggy04CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _duneBuggy04CameraAudioListener enabled is false
            _duneBuggy04CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName DuneBuggy04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("DuneBuggy04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _duneBuggy04Compass enabled is false
            _duneBuggy04Compass.enabled = false;

            // _duneBuggy04Compass compassEnabled is false
            _duneBuggy04Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The DuneBuggy04 compass is disabled");

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
            
            // if _inDuneBuggy04 and Input GetKey KeyCode _exitKey
            if (_inDuneBuggy04 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _duneBuggy04Script enabled is false
                _duneBuggy04Script.enabled = false;
                
                // _duneBuggy04Camera enabled is false
                _duneBuggy04Camera.enabled = false;

                // _duneBuggy04CameraAudioListener enabled is false
                _duneBuggy04CameraAudioListener.enabled = false;

                // _inDuneBuggy04 is false
                _inDuneBuggy04 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _duneBuggy04Compass enabled is false
                _duneBuggy04Compass.enabled = false;

                // _duneBuggy04Compass compassEnabled is false
                _duneBuggy04Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The DuneBuggy04 compass is disabled");         

            } // close if _inDuneBuggy04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inDuneBuggy04 and gameObject tag is Player
            if (!_inDuneBuggy04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inDuneBuggy04 and gameObject tag is Player
            
            // if not _inDuneBuggy04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inDuneBuggy04 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _duneBuggy04 transform
                _player.transform.parent = _duneBuggy04.transform;

                // _duneBuggy04Script enabled is true
                _duneBuggy04Script.enabled = true;
                
                // _duneBuggy04Camera enabled is true
                _duneBuggy04Camera.enabled = true;

                // _duneBuggy04CameraAudioListener enabled is true
                _duneBuggy04CameraAudioListener.enabled = true;

                // _inDuneBuggy04 is true
                _inDuneBuggy04 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _duneBuggy04Compass enabled is true
                _duneBuggy04Compass.enabled = true;

                // _duneBuggy04Compass compassEnabled is true
                _duneBuggy04Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The DuneBuggy04 compass is enabled");                

            } // close if not _inDuneBuggy04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class DuneBuggy04Entry  

} // close namespace VehiclesControl
