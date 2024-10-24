/*
 * File: Armored Truck 04 Entry 
 * Name: ArmoredTruck04Entry.cs
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

    // public class ArmoredTruck04Entry 
    public class ArmoredTruck04Entry : MonoBehaviour
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
            // GameObject _armoredTruck04
            [SerializeField] private GameObject _armoredTruck04;

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
            // bool _inArmoredTruck04 is false
            [SerializeField] private bool _inArmoredTruck04 = false;
        
        // ArmoredTruck04Controller _armoredTruck04Script
        private ArmoredTruck04Controller _armoredTruck04Script;
        
        // Camera _armoredTruck04Camera
        private Camera _armoredTruck04Camera;

        // AudioListener _armoredTruck04CameraAudioListener
        private AudioListener _armoredTruck04CameraAudioListener; 

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
            // _armoredTruck04Script is GetComponent ArmoredTruck04Controller
            _armoredTruck04Script = GetComponent<ArmoredTruck04Controller>();

            // _armoredTruck04Script enabled is false
            _armoredTruck04Script.enabled = false;
            
            // _armoredTruck04Camera is GetComponentInChildren Camera
            _armoredTruck04Camera = GetComponentInChildren<Camera>();
            
            // _armoredTruck04Camera enabled is false
            _armoredTruck04Camera.enabled = false;

            // _armoredTruck04CameraAudioListener is GetComponentInChildren AudioListener
            _armoredTruck04CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _armoredTruck04CameraAudioListener enabled is false
            _armoredTruck04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName ArmoredTruck04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("ArmoredTruck04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

    	} // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inArmoredTruck04 and Input GetKey KeyCode _exitKey
            if (_inArmoredTruck04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _armoredTruck04Script enabled is false
                _armoredTruck04Script.enabled = false;
                
                // _armoredTruck04Camera enabled is false
                _armoredTruck04Camera.enabled = false;

                // _armoredTruck04CameraAudioListener enabled is false
                _armoredTruck04CameraAudioListener.enabled = false;                 

                // _inArmoredTruck04 is false
                _inArmoredTruck04 = false;

            } // close if _inArmoredTruck04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
        	// if not _inArmoredTruck04 and gameObject tag is Player
            if (!_inArmoredTruck04 && other.gameObject.tag == "Player")
            {
            	// _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inArmoredTruck04 and gameObject tag is Player
            
            // if not _inArmoredTruck04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inArmoredTruck04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _armoredTruck04 transform
                _player.transform.parent = _armoredTruck04.transform;

                // _armoredTruck04Script enabled is true
                _armoredTruck04Script.enabled = true;
                
                // _armoredTruck04Camera enabled is true
                _armoredTruck04Camera.enabled = true;

                // _armoredTruck04CameraAudioListener enabled is true
                _armoredTruck04CameraAudioListener.enabled = true; 

                // _inArmoredTruck04 is true
                _inArmoredTruck04 = true;

            } // close if not _inArmoredTruck04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class ArmoredTruck04Entry  

} // close namespace VehiclesControl
