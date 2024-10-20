/*
 * File: Humvee 03 Entry
 * Name: Humvee03Entry.cs
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

    // public class Humvee03Entry 
    public class Humvee03Entry : MonoBehaviour
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

            [Tooltip("The humvee 03 game object")]
            // GameObject _humvee03
            [SerializeField] private GameObject _humvee03;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inHumvee03 is false
            [SerializeField] private bool _inHumvee03 = false;
        
        // Humvee03Controller _humvee03Script
        private Humvee03Controller _humvee03Script;

        // Camera _humvee03Camera
        private Camera _humvee03Camera;

        // AudioListener _humvee03CameraAudioListener
        private AudioListener _humvee03CameraAudioListener; 

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
            // _humvee03Script is GetComponent Humvee03Controller
            _humvee03Script = GetComponent<Humvee03Controller>();

            // _humvee03Script enabled is false
            _humvee03Script.enabled = false;
            
            // _humvee03Script is GetComponentInChildren Camera
            _humvee03Camera = GetComponentInChildren<Camera>();

            // _humvee03Camera enabled is false
            _humvee03Camera.enabled = false;
           
            // _humvee03CameraAudioListener is GetComponentInChildren AudioListener
            _humvee03CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _humvee03CameraAudioListener enabled is false
            _humvee03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Humvee03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Humvee03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inHumvee03 and Input GetKey KeyCode _exitKey
            if (_inHumvee03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _humvee03Script enabled is false
                _humvee03Script.enabled = false;

                // _humvee03Camera enabled is false
                _humvee03Camera.enabled = false;

                // _humvee03CameraAudioListener enabled is false
                _humvee03CameraAudioListener.enabled = false; 

                // _inHumvee03 is false
                _inHumvee03 = false;

            } // close if _inHumvee03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inHumvee03 and gameObject tag is Player
            if (!_inHumvee03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inHumvee03 and gameObject tag is Player
            
            // if not _inHumvee03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inHumvee03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _humvee03 transform
                _player.transform.parent = _humvee03.transform;

                // _humvee03Script enabled is true
                _humvee03Script.enabled = true;

                // _humvee03Camera enabled is true
                _humvee03Camera.enabled = true;

                // _humvee03CameraAudioListener enabled is true
                _humvee03CameraAudioListener.enabled = true; 

                // _inHumvee03 is true
                _inHumvee03 = true;

            } // close if not _inHumvee03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Humvee03Entry  

} // close namespace VehiclesControl
