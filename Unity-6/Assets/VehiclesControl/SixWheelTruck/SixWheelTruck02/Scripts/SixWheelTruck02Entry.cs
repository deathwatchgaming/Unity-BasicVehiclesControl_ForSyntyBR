/*
 * File: Six Wheel Truck 02 Entry
 * Name: SixWheelTruck02Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class SixWheelTruck02Entry 
    public class SixWheelTruck02Entry : MonoBehaviour
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

            [Tooltip("The six wheel truck 02 game object")]
            // GameObject _sixWheelTruck02
            [SerializeField] private GameObject _sixWheelTruck02;

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
            // bool _inSixWheelTruck02 is false
            [SerializeField] private bool _inSixWheelTruck02 = false;
        
        // SixWheelTruck02Controller _sixWheelTruck02Script
        private SixWheelTruck02Controller _sixWheelTruck02Script;
        
        // Camera _sixWheelTruck02Camera
        private Camera _sixWheelTruck02Camera;

        // AudioListener _sixWheelTruck02CameraAudioListener
        private AudioListener _sixWheelTruck02CameraAudioListener;        

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
            // _sixWheelTruck02Script is GetComponent SixWheelTruck02Controller
            _sixWheelTruck02Script = GetComponent<SixWheelTruck02Controller>();

            // _sixWheelTruck02Script enabled is false
            _sixWheelTruck02Script.enabled = false;

            // _sixWheelTruck02Camera is GetComponentInChildren Camera
            _sixWheelTruck02Camera = GetComponentInChildren<Camera>();
            
            // _sixWheelTruck02Camera enabled is false
            _sixWheelTruck02Camera.enabled = false;

            // _sixWheelTruck02CameraAudioListener is GetComponentInChildren AudioListener
            _sixWheelTruck02CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sixWheelTruck02CameraAudioListener enabled is false
            _sixWheelTruck02CameraAudioListener.enabled = false;            

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();            

            // GameObject _interfaceTextObject is FindInActiveObjectByName SixWheelTruck02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SixWheelTruck02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSixWheelTruck02 and Input GetKey KeyCode _exitKey
            if (_inSixWheelTruck02 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sixWheelTruck02Script enabled is false
                _sixWheelTruck02Script.enabled = false;
                
                // _sixWheelTruck02Camera enabled is false
                _sixWheelTruck02Camera.enabled = false;

                // _sixWheelTruck02CameraAudioListener enabled is false
                _sixWheelTruck02CameraAudioListener.enabled = false; 

                // _inSixWheelTruck02 is false
                _inSixWheelTruck02 = false;

            } // close if _inSixWheelTruck02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSixWheelTruck02 and gameObject tag is Player
            if (!_inSixWheelTruck02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSixWheelTruck02 and gameObject tag is Player
            
            // if not _inSixWheelTruck02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSixWheelTruck02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sixWheelTruck02 transform
                _player.transform.parent = _sixWheelTruck02.transform;

                // _sixWheelTruck02Script enabled is true
                _sixWheelTruck02Script.enabled = true;
                
                // _sixWheelTruck02Camera enabled is true
                _sixWheelTruck02Camera.enabled = true;

                // _sixWheelTruck02CameraAudioListener enabled is true
                _sixWheelTruck02CameraAudioListener.enabled = true;                 

                // _inSixWheelTruck02 is true
                _inSixWheelTruck02 = true;

            } // close if not _inSixWheelTruck02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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

    } // close public class SixWheelTruck02Entry  

} // close namespace VehiclesControl
