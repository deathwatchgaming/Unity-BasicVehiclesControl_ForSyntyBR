/*
 * File: Six Wheel Truck 01 Entry
 * Name: SixWheelTruck01Entry.cs
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

    // public class SixWheelTruck01Entry 
    public class SixWheelTruck01Entry : MonoBehaviour
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

            [Tooltip("The six wheel truck 01 game object")]
            // GameObject _sixWheelTruck01
            [SerializeField] private GameObject _sixWheelTruck01;

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
            // bool _inSixWheelTruck01 is false
            [SerializeField] private bool _inSixWheelTruck01 = false;
        
        // SixWheelTruck01Controller _sixWheelTruck01Script
        private SixWheelTruck01Controller _sixWheelTruck01Script;
        
        // Camera _sixWheelTruck01Camera
        private Camera _sixWheelTruck01Camera;

        // AudioListener _sixWheelTruck01CameraAudioListener
        private AudioListener _sixWheelTruck01CameraAudioListener;        

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
            // _sixWheelTruck01Script is GetComponent SixWheelTruck01Controller
            _sixWheelTruck01Script = GetComponent<SixWheelTruck01Controller>();

            // _sixWheelTruck01Script enabled is false
            _sixWheelTruck01Script.enabled = false;

            // _sixWheelTruck01Camera is GetComponentInChildren Camera
            _sixWheelTruck01Camera = GetComponentInChildren<Camera>();
            
            // _sixWheelTruck01Camera enabled is false
            _sixWheelTruck01Camera.enabled = false;

            // _sixWheelTruck01CameraAudioListener is GetComponentInChildren AudioListener
            _sixWheelTruck01CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sixWheelTruck01CameraAudioListener enabled is false
            _sixWheelTruck01CameraAudioListener.enabled = false;            

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();            

            // GameObject _interfaceTextObject is FindInActiveObjectByName SixWheelTruck01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SixWheelTruck01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSixWheelTruck01 and Input GetKey KeyCode _exitKey
            if (_inSixWheelTruck01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sixWheelTruck01Script enabled is false
                _sixWheelTruck01Script.enabled = false;
                
                // _sixWheelTruck01Camera enabled is false
                _sixWheelTruck01Camera.enabled = false;

                // _sixWheelTruck01CameraAudioListener enabled is false
                _sixWheelTruck01CameraAudioListener.enabled = false; 

                // _inSixWheelTruck01 is false
                _inSixWheelTruck01 = false;

            } // close if _inSixWheelTruck01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSixWheelTruck01 and gameObject tag is Player
            if (!_inSixWheelTruck01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSixWheelTruck01 and gameObject tag is Player
            
            // if not _inSixWheelTruck01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSixWheelTruck01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sixWheelTruck01 transform
                _player.transform.parent = _sixWheelTruck01.transform;

                // _sixWheelTruck01Script enabled is true
                _sixWheelTruck01Script.enabled = true;
                
                // _sixWheelTruck01Camera enabled is true
                _sixWheelTruck01Camera.enabled = true;

                // _sixWheelTruck01CameraAudioListener enabled is true
                _sixWheelTruck01CameraAudioListener.enabled = true;                 

                // _inSixWheelTruck01 is true
                _inSixWheelTruck01 = true;

            } // close if not _inSixWheelTruck01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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

    } // close public class SixWheelTruck01Entry  

} // close namespace VehiclesControl
