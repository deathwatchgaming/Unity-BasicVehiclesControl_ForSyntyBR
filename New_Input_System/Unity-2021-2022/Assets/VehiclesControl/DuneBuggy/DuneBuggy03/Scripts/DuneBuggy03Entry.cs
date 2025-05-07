/*
 * File: Dune Buggy 03 Entry (New Input System) 
 * Name: DuneBuggy03Entry.cs
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

    // public class DuneBuggy03Entry 
    public class DuneBuggy03Entry : MonoBehaviour
    {
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The dune buggy 03 game object")]
            // GameObject _duneBuggy03
            [SerializeField] private GameObject _duneBuggy03;

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
            // bool _inDuneBuggy03 is false
            [SerializeField] private bool _inDuneBuggy03 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The duneBuggy 03 compass")]
            // DuneBuggy03Compass _duneBuggy03Compass
            [SerializeField] private DuneBuggy03Compass _duneBuggy03Compass;

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

        // DuneBuggy03Controller _duneBuggy03Script
        private DuneBuggy03Controller _duneBuggy03Script;
        
        // Camera _duneBuggy03Camera
        private Camera _duneBuggy03Camera;

        // AudioListener _duneBuggy03CameraAudioListener
        private AudioListener _duneBuggy03CameraAudioListener; 

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

        //public static DuneBuggy03Entry _duneBuggy03Entry;

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
            //_duneBuggy03Entry = this;

            // _duneBuggy03Script is GetComponent DuneBuggy03Controller
            _duneBuggy03Script = GetComponent<DuneBuggy03Controller>();

            // _duneBuggy03Script enabled is false
            _duneBuggy03Script.enabled = false;
            
            // _duneBuggy03Camera is GetComponentInChildren Camera
            _duneBuggy03Camera = GetComponentInChildren<Camera>();
            
            // _duneBuggy03Camera enabled is false
            _duneBuggy03Camera.enabled = false;
           
            // _duneBuggy03CameraAudioListener is GetComponentInChildren AudioListener
            _duneBuggy03CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _duneBuggy03CameraAudioListener enabled is false
            _duneBuggy03CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName DuneBuggy03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("DuneBuggy03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _duneBuggy03Compass enabled is false
            _duneBuggy03Compass.enabled = false;

            // _duneBuggy03Compass compassEnabled is false
            _duneBuggy03Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The DuneBuggy03 compass is disabled");

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
            
            // if _inDuneBuggy03 and Input GetKey KeyCode _exitKey
            if (_inDuneBuggy03 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _duneBuggy03Script enabled is false
                _duneBuggy03Script.enabled = false;
                
                // _duneBuggy03Camera enabled is false
                _duneBuggy03Camera.enabled = false;

                // _duneBuggy03CameraAudioListener enabled is false
                _duneBuggy03CameraAudioListener.enabled = false;

                // _inDuneBuggy03 is false
                _inDuneBuggy03 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _duneBuggy03Compass enabled is false
                _duneBuggy03Compass.enabled = false;

                // _duneBuggy03Compass compassEnabled is false
                _duneBuggy03Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The DuneBuggy03 compass is disabled");         

            } // close if _inDuneBuggy03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inDuneBuggy03 and gameObject tag is Player
            if (!_inDuneBuggy03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inDuneBuggy03 and gameObject tag is Player
            
            // if not _inDuneBuggy03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inDuneBuggy03 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _duneBuggy03 transform
                _player.transform.parent = _duneBuggy03.transform;

                // _duneBuggy03Script enabled is true
                _duneBuggy03Script.enabled = true;
                
                // _duneBuggy03Camera enabled is true
                _duneBuggy03Camera.enabled = true;

                // _duneBuggy03CameraAudioListener enabled is true
                _duneBuggy03CameraAudioListener.enabled = true;

                // _inDuneBuggy03 is true
                _inDuneBuggy03 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _duneBuggy03Compass enabled is true
                _duneBuggy03Compass.enabled = true;

                // _duneBuggy03Compass compassEnabled is true
                _duneBuggy03Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The DuneBuggy03 compass is enabled");
                
            } // close if not _inDuneBuggy03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class DuneBuggy03Entry  

} // close namespace VehiclesControl
