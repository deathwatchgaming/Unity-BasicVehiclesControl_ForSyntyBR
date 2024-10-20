/*
 * File: Dune Buggy 06 Entry
 * Name: DuneBuggy06Entry.cs
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

    // public class DuneBuggy06Entry 
    public class DuneBuggy06Entry : MonoBehaviour
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

            [Tooltip("The dune buggy 06 game object")]
            // GameObject _duneBuggy06
            [SerializeField] private GameObject _duneBuggy06;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inDuneBuggy06 is false
            [SerializeField] private bool _inDuneBuggy06 = false;
        
        // DuneBuggy06Controller _duneBuggy06Script
        private DuneBuggy06Controller _duneBuggy06Script;
        
        // Camera _duneBuggy06Camera
        private Camera _duneBuggy06Camera;

        // AudioListener _duneBuggy06CameraAudioListener
        private AudioListener _duneBuggy06CameraAudioListener; 

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
            // _duneBuggy06Script is GetComponent DuneBuggy06Controller
            _duneBuggy06Script = GetComponent<DuneBuggy06Controller>();

            // _duneBuggy06Script enabled is false
            _duneBuggy06Script.enabled = false;
            
            // _duneBuggy06Camera is GetComponentInChildren Camera
            _duneBuggy06Camera = GetComponentInChildren<Camera>();
            
            // _duneBuggy06Camera enabled is false
            _duneBuggy06Camera.enabled = false;
           
            // _duneBuggy06CameraAudioListener is GetComponentInChildren AudioListener
            _duneBuggy06CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _duneBuggy06CameraAudioListener enabled is false
            _duneBuggy06CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName DuneBuggy06_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("DuneBuggy06_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inDuneBuggy06 and Input GetKey KeyCode _exitKey
            if (_inDuneBuggy06 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _duneBuggy06Script enabled is false
                _duneBuggy06Script.enabled = false;
                
                // _duneBuggy06Camera enabled is false
                _duneBuggy06Camera.enabled = false;

                // _duneBuggy06CameraAudioListener enabled is false
                _duneBuggy06CameraAudioListener.enabled = false;

                // _inDuneBuggy06 is false
                _inDuneBuggy06 = false;

            } // close if _inDuneBuggy06 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inDuneBuggy06 and gameObject tag is Player
            if (!_inDuneBuggy06 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inDuneBuggy06 and gameObject tag is Player
            
            // if not _inDuneBuggy06 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inDuneBuggy06 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _duneBuggy06 transform
                _player.transform.parent = _duneBuggy06.transform;

                // _duneBuggy06Script enabled is true
                _duneBuggy06Script.enabled = true;
                
                // _duneBuggy06Camera enabled is true
                _duneBuggy06Camera.enabled = true;

                // _duneBuggy06CameraAudioListener enabled is true
                _duneBuggy06CameraAudioListener.enabled = true;

                // _inDuneBuggy06 is true
                _inDuneBuggy06 = true;

            } // close if not _inDuneBuggy06 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class DuneBuggy06Entry  

} // close namespace VehiclesControl
