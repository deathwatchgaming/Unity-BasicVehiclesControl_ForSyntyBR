/*
 * File: Humvee 04 Entry
 * Name: Humvee04Entry.cs
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

    // public class Humvee04Entry 
    public class Humvee04Entry : MonoBehaviour
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

            [Tooltip("The humvee 04 game object")]
            // GameObject _humvee04
            [SerializeField] private GameObject _humvee04;

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
            // bool _inHumvee04 is false
            [SerializeField] private bool _inHumvee04 = false;
        
        // Humvee04Controller _humvee04Script
        private Humvee04Controller _humvee04Script;

        // Camera _humvee04Camera
        private Camera _humvee04Camera;

        // AudioListener _humvee04CameraAudioListener
        private AudioListener _humvee04CameraAudioListener; 

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
            // _humvee04Script is GetComponent Humvee04Controller
            _humvee04Script = GetComponent<Humvee04Controller>();

            // _humvee04Script enabled is false
            _humvee04Script.enabled = false;
            
            // _humvee04Script is GetComponentInChildren Camera
            _humvee04Camera = GetComponentInChildren<Camera>();

            // _humvee04Camera enabled is false
            _humvee04Camera.enabled = false;
           
            // _humvee04CameraAudioListener is GetComponentInChildren AudioListener
            _humvee04CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _humvee04CameraAudioListener enabled is false
            _humvee04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Humvee04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Humvee04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inHumvee04 and Input GetKey KeyCode _exitKey
            if (_inHumvee04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _humvee04Script enabled is false
                _humvee04Script.enabled = false;

                // _humvee04Camera enabled is false
                _humvee04Camera.enabled = false;

                // _humvee04CameraAudioListener enabled is false
                _humvee04CameraAudioListener.enabled = false; 

                // _inHumvee04 is false
                _inHumvee04 = false;

            } // close if _inHumvee04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inHumvee04 and gameObject tag is Player
            if (!_inHumvee04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inHumvee04 and gameObject tag is Player
            
            // if not _inHumvee04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inHumvee04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _humvee04 transform
                _player.transform.parent = _humvee04.transform;

                // _humvee04Script enabled is true
                _humvee04Script.enabled = true;

                // _humvee04Camera enabled is true
                _humvee04Camera.enabled = true;

                // _humvee04CameraAudioListener enabled is true
                _humvee04CameraAudioListener.enabled = true; 

                // _inHumvee04 is true
                _inHumvee04 = true;

            } // close if not _inHumvee04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Humvee04Entry  

} // close namespace VehiclesControl
