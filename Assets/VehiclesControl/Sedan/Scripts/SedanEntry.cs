/*
 * File: Sedan Entry
 * Name: SedanEntry.cs
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

    // public class SedanEntry 
    public class SedanEntry : MonoBehaviour
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

            [Tooltip("The sedan game object")]
            // GameObject _sedan
            [SerializeField] private GameObject _sedan;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedan is false
            [SerializeField] private bool _inSedan = false;
        
        // SedanController _sedanScript
        private SedanController _sedanScript;

        // Camera _sedanCamera
        private Camera _sedanCamera;

        // AudioListener _sedanCameraAudioListener
        private AudioListener _sedanCameraAudioListener; 

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
            // _sedanScript is GetComponent SedanController
            _sedanScript = GetComponent<SedanController>();

            // _sedanScript enabled is false
            _sedanScript.enabled = false;
            
            // _sedanScript is GetComponentInChildren
            _sedanCamera = GetComponentInChildren<Camera>();

            // _sedanCamera enabled is false
            _sedanCamera.enabled = false;

            // _sedanCameraAudioListener is GetComponentInChildren AudioListener
            _sedanCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanCameraAudioListener enabled is false
            _sedanCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Sedan_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Sedan_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedan and Input GetKey KeyCode _exitKey
            if (_inSedan && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanScript enabled is false
                _sedanScript.enabled = false;
                
                // _sedanCamera enabled is false
                _sedanCamera.enabled = false;

                // _sedanCameraAudioListener enabled is false
                _sedanCameraAudioListener.enabled = false; 

                // _inSedan is false
                _inSedan = false;

            } // close if _inSedan and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedan and gameObject tag is Player
            if (!_inSedan && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedan and gameObject tag is Player
            
            // if not _inSedan and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedan && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedan transform
                _player.transform.parent = _sedan.transform;

                // _sedanScript enabled is true
                _sedanScript.enabled = true;
                
                // _sedanCamera enabled is true
                _sedanCamera.enabled = true;

                // _sedanCameraAudioListener enabled is true
                _sedanCameraAudioListener.enabled = true; 

                // _inSedan is true
                _inSedan = true;

            } // close if not _inSedan and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanEntry  

} // close namespace VehiclesControl
