/*
 * File: Sedan 05 Entry
 * Name: Sedan05Entry.cs
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

    // public class Sedan05Entry 
    public class Sedan05Entry : MonoBehaviour
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

            [Tooltip("The sedan 05 game object")]
            // GameObject _sedan05
            [SerializeField] private GameObject _sedan05;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedan05 is false
            [SerializeField] private bool _inSedan05 = false;
        
        // Sedan05Controller _sedan05Script
        private Sedan05Controller _sedan05Script;

        // Camera _sedan05Camera
        private Camera _sedan05Camera;

        // AudioListener _sedan05CameraAudioListener
        private AudioListener _sedan05CameraAudioListener; 

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
            // _sedan05Script is GetComponent Sedan05Controller
            _sedan05Script = GetComponent<Sedan05Controller>();

            // _sedan05Script enabled is false
            _sedan05Script.enabled = false;
            
            // _sedan05Script is GetComponentInChildren
            _sedan05Camera = GetComponentInChildren<Camera>();

            // _sedan05Camera enabled is false
            _sedan05Camera.enabled = false;

            // _sedan05CameraAudioListener is GetComponentInChildren AudioListener
            _sedan05CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedan05CameraAudioListener enabled is false
            _sedan05CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Sedan05_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Sedan05_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedan05 and Input GetKey KeyCode _exitKey
            if (_inSedan05 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedan05Script enabled is false
                _sedan05Script.enabled = false;
                
                // _sedan05Camera enabled is false
                _sedan05Camera.enabled = false;

                // _sedan05CameraAudioListener enabled is false
                _sedan05CameraAudioListener.enabled = false; 

                // _inSedan05 is false
                _inSedan05 = false;

            } // close if _inSedan05 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedan05 and gameObject tag is Player
            if (!_inSedan05 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedan05 and gameObject tag is Player
            
            // if not _inSedan05 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedan05 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedan05 transform
                _player.transform.parent = _sedan05.transform;

                // _sedan05Script enabled is true
                _sedan05Script.enabled = true;
                
                // _sedan05Camera enabled is true
                _sedan05Camera.enabled = true;

                // _sedan05CameraAudioListener enabled is true
                _sedan05CameraAudioListener.enabled = true; 

                // _inSedan05 is true
                _inSedan05 = true;

            } // close if not _inSedan05 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Sedan05Entry  

} // close namespace VehiclesControl
