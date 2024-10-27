/*
 * File: Humvee 05 Entry
 * Name: Humvee05Entry.cs
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

    // public class Humvee05Entry 
    public class Humvee05Entry : MonoBehaviour
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

            [Tooltip("The humvee 05 game object")]
            // GameObject _humvee05
            [SerializeField] private GameObject _humvee05;

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
            // bool _inHumvee05 is false
            [SerializeField] private bool _inHumvee05 = false;
        
        // Humvee05Controller _humvee05Script
        private Humvee05Controller _humvee05Script;

        // Camera _humvee05Camera
        private Camera _humvee05Camera;

        // AudioListener _humvee05CameraAudioListener
        private AudioListener _humvee05CameraAudioListener; 

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
            // _humvee05Script is GetComponent Humvee05Controller
            _humvee05Script = GetComponent<Humvee05Controller>();

            // _humvee05Script enabled is false
            _humvee05Script.enabled = false;
            
            // _humvee05Script is GetComponentInChildren Camera
            _humvee05Camera = GetComponentInChildren<Camera>();

            // _humvee05Camera enabled is false
            _humvee05Camera.enabled = false;
           
            // _humvee05CameraAudioListener is GetComponentInChildren AudioListener
            _humvee05CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _humvee05CameraAudioListener enabled is false
            _humvee05CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Humvee05_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Humvee05_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inHumvee05 and Input GetKey KeyCode _exitKey
            if (_inHumvee05 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _humvee05Script enabled is false
                _humvee05Script.enabled = false;

                // _humvee05Camera enabled is false
                _humvee05Camera.enabled = false;

                // _humvee05CameraAudioListener enabled is false
                _humvee05CameraAudioListener.enabled = false; 

                // _inHumvee05 is false
                _inHumvee05 = false;

            } // close if _inHumvee05 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inHumvee05 and gameObject tag is Player
            if (!_inHumvee05 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inHumvee05 and gameObject tag is Player
            
            // if not _inHumvee05 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inHumvee05 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _humvee05 transform
                _player.transform.parent = _humvee05.transform;

                // _humvee05Script enabled is true
                _humvee05Script.enabled = true;

                // _humvee05Camera enabled is true
                _humvee05Camera.enabled = true;

                // _humvee05CameraAudioListener enabled is true
                _humvee05CameraAudioListener.enabled = true; 

                // _inHumvee05 is true
                _inHumvee05 = true;

            } // close if not _inHumvee05 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Humvee05Entry  

} // close namespace VehiclesControl
