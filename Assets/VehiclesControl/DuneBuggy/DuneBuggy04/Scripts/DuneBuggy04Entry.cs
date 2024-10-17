/*
 * File: Dune Buggy 04 Entry
 * Name: DuneBuggy04Entry.cs
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

    // public class DuneBuggy04Entry 
    public class DuneBuggy04Entry : MonoBehaviour
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

            [Tooltip("The dune buggy 04 game object")]
            // GameObject _duneBuggy04
            [SerializeField] private GameObject _duneBuggy04;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inDuneBuggy04 is false
            [SerializeField] private bool _inDuneBuggy04 = false;
        
        // DuneBuggy04Controller _duneBuggy04Script
        private DuneBuggy04Controller _duneBuggy04Script;
        
        // Camera _duneBuggy04Camera
        private Camera _duneBuggy04Camera;

        // AudioListener _duneBuggy04CameraAudioListener
        private AudioListener _duneBuggy04CameraAudioListener; 

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
            // _duneBuggy04Script is GetComponent DuneBuggy04Controller
            _duneBuggy04Script = GetComponent<DuneBuggy04Controller>();

            // _duneBuggy04Script enabled is false
            _duneBuggy04Script.enabled = false;
            
            // _duneBuggy04Camera is GetComponentInChildren Camera
            _duneBuggy04Camera = GetComponentInChildren<Camera>();
            
            // _duneBuggy04Camera enabled is false
            _duneBuggy04Camera.enabled = false;
           
            // _duneBuggy04CameraAudioListener is GetComponentInChildren AudioListener
            _duneBuggy04CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _duneBuggy04CameraAudioListener enabled is false
            _duneBuggy04CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName DuneBuggy04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("DuneBuggy04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inDuneBuggy04 and Input GetKey KeyCode _exitKey
            if (_inDuneBuggy04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _duneBuggy04Script enabled is false
                _duneBuggy04Script.enabled = false;
                
                // _duneBuggy04Camera enabled is false
                _duneBuggy04Camera.enabled = false;

                // _duneBuggy04CameraAudioListener enabled is false
                _duneBuggy04CameraAudioListener.enabled = false;

                // _inDuneBuggy04 is false
                _inDuneBuggy04 = false;

            } // close if _inDuneBuggy04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inDuneBuggy04 and gameObject tag is Player
            if (!_inDuneBuggy04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inDuneBuggy04 and gameObject tag is Player
            
            // if not _inDuneBuggy04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inDuneBuggy04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _duneBuggy04 transform
                _player.transform.parent = _duneBuggy04.transform;

                // _duneBuggy04Script enabled is true
                _duneBuggy04Script.enabled = true;
                
                // _duneBuggy04Camera enabled is true
                _duneBuggy04Camera.enabled = true;

                // _duneBuggy04CameraAudioListener enabled is true
                _duneBuggy04CameraAudioListener.enabled = true;

                // _inDuneBuggy04 is true
                _inDuneBuggy04 = true;

            } // close if not _inDuneBuggy04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class DuneBuggy04Entry  

} // close namespace VehiclesControl
