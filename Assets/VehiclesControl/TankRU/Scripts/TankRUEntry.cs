/*
 * File: TankRU Entry
 * Name: TankRUEntry.cs
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

    // public class TankRUEntry 
    public class TankRUEntry : MonoBehaviour
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

            [Tooltip("The sedan game object")]
            // GameObject _tankRU
            [SerializeField] private GameObject _tankRU;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inTankRU is false
            [SerializeField] private bool _inTankRU = false;
        
        // TankRUController _tankRUScript
        private TankRUController _tankRUScript;

        // Camera _tankRUCamera
        private Camera _tankRUCamera;

        // AudioListener _tankRUCameraAudioListener
        private AudioListener _tankRUCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;        

        // private void Start
        private void Start() 
        {
            // _tankRUScript is GetComponent TankRUController
            _tankRUScript = GetComponent<TankRUController>();

            // _tankRUScript enabled is false
            _tankRUScript.enabled = false;
            
            // _tankRUScript is GetComponentInChildren
            _tankRUCamera = GetComponentInChildren<Camera>();

            // _tankRUCamera enabled is false
            _tankRUCamera.enabled = false;

            // _tankRUCameraAudioListener is GetComponentInChildren AudioListener
            _tankRUCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankRUCameraAudioListener enabled is false
            _tankRUCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find TankRU_EntryKey
            _interfaceTextObject = GameObject.Find("TankRU_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankRU and Input GetKey KeyCode _exitKey
            if (_inTankRU && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankRUScript enabled is false
                _tankRUScript.enabled = false;
                
                // _tankRUCamera enabled is false
                _tankRUCamera.enabled = false;

                // _tankRUCameraAudioListener enabled is false
                _tankRUCameraAudioListener.enabled = false; 

                // _inTankRU is false
                _inTankRU = false;

            } // close if _inTankRU and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankRU and gameObject tag is Player
            if (!_inTankRU && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankRU and gameObject tag is Player
            
            // if not _inTankRU and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankRU && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankRU transform
                _player.transform.parent = _tankRU.transform;

                // _tankRUScript enabled is true
                _tankRUScript.enabled = true;
                
                // _tankRUCamera enabled is true
                _tankRUCamera.enabled = true;

                // _tankRUCameraAudioListener enabled is true
                _tankRUCameraAudioListener.enabled = true; 

                // _inTankRU is true
                _inTankRU = true;

            } // close if not _inTankRU and gameObject tag is Player and Input GetKey KeyCode _enterKey

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

        } // close private IEnumerator RigidbodySleep float duration       
        
    } // close public class TankRUEntry  

} // close namespace VehiclesControl
