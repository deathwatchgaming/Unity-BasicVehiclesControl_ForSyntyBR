/*
 * File: TankUS 02 Entry
 * Name: TankUS02Entry.cs
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

    // public class TankUS02Entry 
    public class TankUS02Entry : MonoBehaviour
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

            [Tooltip("The tankUS02 game object")]
            // GameObject _tankUS02
            [SerializeField] private GameObject _tankUS02;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inTankUS02 is false
            [SerializeField] private bool _inTankUS02 = false;
        
        // TankUS02Controller _tankUS02Script
        private TankUS02Controller _tankUS02Script;

        // Camera _tankUS02Camera
        private Camera _tankUS02Camera;

        // AudioListener _tankUS02CameraAudioListener
        private AudioListener _tankUS02CameraAudioListener; 

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
            // _tankUS02Script is GetComponent TankUS02Controller
            _tankUS02Script = GetComponent<TankUS02Controller>();

            // _tankUS02Script enabled is false
            _tankUS02Script.enabled = false;
            
            // _tankUS02Script is GetComponentInChildren
            _tankUS02Camera = GetComponentInChildren<Camera>();

            // _tankUS02Camera enabled is false
            _tankUS02Camera.enabled = false;

            // _tankUS02CameraAudioListener is GetComponentInChildren AudioListener
            _tankUS02CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankUS02CameraAudioListener enabled is false
            _tankUS02CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankUS02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankUS02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankUS02 and Input GetKey KeyCode _exitKey
            if (_inTankUS02 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankUS02Script enabled is false
                _tankUS02Script.enabled = false;
                
                // _tankUS02Camera enabled is false
                _tankUS02Camera.enabled = false;

                // _tankUS02CameraAudioListener enabled is false
                _tankUS02CameraAudioListener.enabled = false; 

                // _inTankUS02 is false
                _inTankUS02 = false;

            } // close if _inTankUS02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankUS02 and gameObject tag is Player
            if (!_inTankUS02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankUS02 and gameObject tag is Player
            
            // if not _inTankUS02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankUS02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankUS02 transform
                _player.transform.parent = _tankUS02.transform;

                // _tankUS02Script enabled is true
                _tankUS02Script.enabled = true;
                
                // _tankUS02Camera enabled is true
                _tankUS02Camera.enabled = true;

                // _tankUS02CameraAudioListener enabled is true
                _tankUS02CameraAudioListener.enabled = true; 

                // _inTankUS02 is true
                _inTankUS02 = true;

            } // close if not _inTankUS02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankUS02Entry  

} // close namespace VehiclesControl
