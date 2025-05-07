/*
 * File: Tank RU 04 Entry (New Input System)
 * Name: TankRU04Entry.cs
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

    // public class TankRU04Entry 
    public class TankRU04Entry : MonoBehaviour
    {   
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The tank ru 04 game object")]
            // GameObject _tankRU04
            [SerializeField] private GameObject _tankRU04;

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
            // bool _inTankRU04 is false
            [SerializeField] private bool _inTankRU04 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The tankRU 04 compass")]
            // TankRU04Compass _tankRU04Compass
            [SerializeField] private TankRU04Compass _tankRU04Compass;

        // Input Actions
        [Header("Input Actions")] 

            [Tooltip("The input action asset")]
            // InputActionAsset _tankControls
            [SerializeField] private InputActionAsset _tankControls;

        // InputAction _tankEnterAction
        private InputAction _tankEnterAction;

        // InputAction _tankExitAction
        private InputAction _tankExitAction;

        // bool _enterButton
        private bool _enterButton;

        // bool _exitButton
        private bool _exitButton;

        // TankRU04Controller _tankRU04Script
        private TankRU04Controller _tankRU04Script;

        // Camera _tankRU04Camera
        private Camera _tankRU04Camera;

        // AudioListener _tankRU04CameraAudioListener
        private AudioListener _tankRU04CameraAudioListener; 

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

        //public static TankRU04Entry _tankRU04Entry;

        // private void Awake
        private void Awake()
        {
            // _tankEnterAction
            _tankEnterAction = _tankControls.FindActionMap("Tank").FindAction("Enter");

            // _tankExitAction
            _tankExitAction = _tankControls.FindActionMap("Tank").FindAction("Exit");

        } // close private void Awake

        // private void OnEnable
        private void OnEnable()
        {
            // _tankEnterAction Enable
            _tankEnterAction.Enable();

            // _tankExitAction Enable
            _tankExitAction.Enable();

        } // close private void OnEnable

        // private void OnDisable
        private void OnDisable()
        {
            // _tankEnterAction Disable
            _tankEnterAction.Disable();

            // _tankExitAction Disable
            _tankExitAction.Disable();  

        } // close private void OnDisable

        // private void Start
        private void Start() 
        {
            //_tankRU04Entry = this;
            
            // _tankRU04Script is GetComponent TankRU04Controller
            _tankRU04Script = GetComponent<TankRU04Controller>();

            // _tankRU04Script enabled is false
            _tankRU04Script.enabled = false;
            
            // _tankRU04Script is GetComponentInChildren
            _tankRU04Camera = GetComponentInChildren<Camera>();

            // _tankRU04Camera enabled is false
            _tankRU04Camera.enabled = false;

            // _tankRU04CameraAudioListener is GetComponentInChildren AudioListener
            _tankRU04CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankRU04CameraAudioListener enabled is false
            _tankRU04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankRU04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankRU04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _tankRU04Compass enabled is false
            _tankRU04Compass.enabled = false;

            // _tankRU04Compass compassEnabled is false
            _tankRU04Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The TankRU04 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if_tankEnterAction triggered
            if (_tankEnterAction.triggered)
            {
                // _enterButton is true
                _enterButton = true;

                // _exitButton is false
                _exitButton = false;

            } // close if_tankEnterAction triggered

            // if _tankExitAction triggered
            if (_tankExitAction.triggered)
            {
                // _enterButton is false
                _enterButton = false;

                // _exitButton is true
                _exitButton = true;

            } // close if _tankExitAction triggered
            
            // if _inTankRU04 and Input GetKey KeyCode _exitKey
            if (_inTankRU04 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankRU04Script enabled is false
                _tankRU04Script.enabled = false;
                
                // _tankRU04Camera enabled is false
                _tankRU04Camera.enabled = false;

                // _tankRU04CameraAudioListener enabled is false
                _tankRU04CameraAudioListener.enabled = false; 

                // _inTankRU04 is false
                _inTankRU04 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _tankRU04Compass enabled is false
                _tankRU04Compass.enabled = false;

                // _tankRU04Compass compassEnabled is false
                _tankRU04Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The TankRU04 compass is disabled");         

            } // close if _inTankRU04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankRU04 and gameObject tag is Player
            if (!_inTankRU04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankRU04 and gameObject tag is Player
            
            // if not _inTankRU04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankRU04 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankRU04 transform
                _player.transform.parent = _tankRU04.transform;

                // _tankRU04Script enabled is true
                _tankRU04Script.enabled = true;
                
                // _tankRU04Camera enabled is true
                _tankRU04Camera.enabled = true;

                // _tankRU04CameraAudioListener enabled is true
                _tankRU04CameraAudioListener.enabled = true; 

                // _inTankRU04 is true
                _inTankRU04 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _tankRU04Compass enabled is true
                _tankRU04Compass.enabled = true;

                // _tankRU04Compass compassEnabled is true
                _tankRU04Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The TankRU04 compass is enabled");                

            } // close if not _inTankRU04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankRU04Entry  

} // close namespace VehiclesControl
