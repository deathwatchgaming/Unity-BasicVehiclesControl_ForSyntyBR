/*
 * File: Armored Truck 02 Entry 
 * Name: ArmoredTruck02Entry.cs
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

    // public class ArmoredTruck02Entry 
    public class ArmoredTruck02Entry : MonoBehaviour
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

            [Tooltip("The armored truck game object")]
            // GameObject _armoredTruck02
            [SerializeField] private GameObject _armoredTruck02;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inArmoredTruck02 is false
            [SerializeField] private bool _inArmoredTruck02 = false;
        
        // ArmoredTruck02Controller _armoredTruck02Script
        private ArmoredTruck02Controller _armoredTruck02Script;
        
        // Camera _armoredTruck02Camera
        private Camera _armoredTruck02Camera;

        // AudioListener _armoredTruck02CameraAudioListener
        private AudioListener _armoredTruck02CameraAudioListener; 

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
        
        // private void Start
        private void Start() 
        {
            // _armoredTruck02Script is GetComponent ArmoredTruck02Controller
            _armoredTruck02Script = GetComponent<ArmoredTruck02Controller>();

            // _armoredTruck02Script enabled is false
            _armoredTruck02Script.enabled = false;
            
            // _armoredTruck02Camera is GetComponentInChildren Camera
            _armoredTruck02Camera = GetComponentInChildren<Camera>();
            
            // _armoredTruck02Camera enabled is false
            _armoredTruck02Camera.enabled = false;

            // _armoredTruck02CameraAudioListener is GetComponentInChildren AudioListener
            _armoredTruck02CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _armoredTruck02CameraAudioListener enabled is false
            _armoredTruck02CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName ArmoredTruck02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("ArmoredTruck02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

    	} // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inArmoredTruck02 and Input GetKey KeyCode _exitKey
            if (_inArmoredTruck02 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _armoredTruck02Script enabled is false
                _armoredTruck02Script.enabled = false;
                
                // _armoredTruck02Camera enabled is false
                _armoredTruck02Camera.enabled = false;

                // _armoredTruck02CameraAudioListener enabled is false
                _armoredTruck02CameraAudioListener.enabled = false;                 

                // _inArmoredTruck02 is false
                _inArmoredTruck02 = false;

            } // close if _inArmoredTruck02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
        	// if not _inArmoredTruck02 and gameObject tag is Player
            if (!_inArmoredTruck02 && other.gameObject.tag == "Player")
            {
            	// _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inArmoredTruck02 and gameObject tag is Player
            
            // if not _inArmoredTruck02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inArmoredTruck02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _armoredTruck02 transform
                _player.transform.parent = _armoredTruck02.transform;

                // _armoredTruck02Script enabled is true
                _armoredTruck02Script.enabled = true;
                
                // _armoredTruck02Camera enabled is true
                _armoredTruck02Camera.enabled = true;

                // _armoredTruck02CameraAudioListener enabled is true
                _armoredTruck02CameraAudioListener.enabled = true; 

                // _inArmoredTruck02 is true
                _inArmoredTruck02 = true;

            } // close if not _inArmoredTruck02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class ArmoredTruck02Entry  

} // close namespace VehiclesControl
