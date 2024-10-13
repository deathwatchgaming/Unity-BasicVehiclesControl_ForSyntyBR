/*
 * File: Sedan 02 Entry
 * Name: Sedan02Entry.cs
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

    // public class Sedan02Entry 
    public class Sedan02Entry : MonoBehaviour
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

            [Tooltip("The sedan 02 game object")]
            // GameObject _sedan02
            [SerializeField] private GameObject _sedan02;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedan02 is false
            [SerializeField] private bool _inSedan02 = false;
        
        // Sedan02Controller _sedan02Script
        private Sedan02Controller _sedan02Script;

        // Camera _sedan02Camera
        private Camera _sedan02Camera;

        // AudioListener _sedan02CameraAudioListener
        private AudioListener _sedan02CameraAudioListener; 

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
            // _sedan02Script is GetComponent Sedan02Controller
            _sedan02Script = GetComponent<Sedan02Controller>();

            // _sedan02Script enabled is false
            _sedan02Script.enabled = false;
            
            // _sedan02Script is GetComponentInChildren
            _sedan02Camera = GetComponentInChildren<Camera>();

            // _sedan02Camera enabled is false
            _sedan02Camera.enabled = false;

            // _sedan02CameraAudioListener is GetComponentInChildren AudioListener
            _sedan02CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedan02CameraAudioListener enabled is false
            _sedan02CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Sedan02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Sedan02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedan02 and Input GetKey KeyCode _exitKey
            if (_inSedan02 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedan02Script enabled is false
                _sedan02Script.enabled = false;
                
                // _sedan02Camera enabled is false
                _sedan02Camera.enabled = false;

                // _sedan02CameraAudioListener enabled is false
                _sedan02CameraAudioListener.enabled = false; 

                // _inSedan02 is false
                _inSedan02 = false;

            } // close if _inSedan02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedan02 and gameObject tag is Player
            if (!_inSedan02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedan02 and gameObject tag is Player
            
            // if not _inSedan02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedan02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedan02 transform
                _player.transform.parent = _sedan02.transform;

                // _sedan02Script enabled is true
                _sedan02Script.enabled = true;
                
                // _sedan02Camera enabled is true
                _sedan02Camera.enabled = true;

                // _sedan02CameraAudioListener enabled is true
                _sedan02CameraAudioListener.enabled = true; 

                // _inSedan02 is true
                _inSedan02 = true;

            } // close if not _inSedan02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Sedan02Entry  

} // close namespace VehiclesControl