/*
 * File: TankUS 03 Entry
 * Name: TankUS03Entry.cs
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

    // public class TankUS03Entry 
    public class TankUS03Entry : MonoBehaviour
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

            [Tooltip("The TankUS 03 game object")]
            // GameObject _tankUS03
            [SerializeField] private GameObject _tankUS03;

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
            // bool _inTankUS03 is false
            [SerializeField] private bool _inTankUS03 = false;
        
        // TankUS03Controller _tankUS03Script
        private TankUS03Controller _tankUS03Script;

        // Camera _tankUS03Camera
        private Camera _tankUS03Camera;

        // AudioListener _tankUS03CameraAudioListener
        private AudioListener _tankUS03CameraAudioListener; 

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
            // _tankUS03Script is GetComponent TankUS03Controller
            _tankUS03Script = GetComponent<TankUS03Controller>();

            // _tankUS03Script enabled is false
            _tankUS03Script.enabled = false;
            
            // _tankUS03Script is GetComponentInChildren
            _tankUS03Camera = GetComponentInChildren<Camera>();

            // _tankUS03Camera enabled is false
            _tankUS03Camera.enabled = false;

            // _tankUS03CameraAudioListener is GetComponentInChildren AudioListener
            _tankUS03CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankUS03CameraAudioListener enabled is false
            _tankUS03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankUS03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankUS03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankUS03 and Input GetKey KeyCode _exitKey
            if (_inTankUS03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankUS03Script enabled is false
                _tankUS03Script.enabled = false;
                
                // _tankUS03Camera enabled is false
                _tankUS03Camera.enabled = false;

                // _tankUS03CameraAudioListener enabled is false
                _tankUS03CameraAudioListener.enabled = false; 

                // _inTankUS03 is false
                _inTankUS03 = false;

            } // close if _inTankUS03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankUS03 and gameObject tag is Player
            if (!_inTankUS03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankUS03 and gameObject tag is Player
            
            // if not _inTankUS03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankUS03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankUS03 transform
                _player.transform.parent = _tankUS03.transform;

                // _tankUS03Script enabled is true
                _tankUS03Script.enabled = true;
                
                // _tankUS03Camera enabled is true
                _tankUS03Camera.enabled = true;

                // _tankUS03CameraAudioListener enabled is true
                _tankUS03CameraAudioListener.enabled = true; 

                // _inTankUS03 is true
                _inTankUS03 = true;

            } // close if not _inTankUS03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankUS03Entry  

} // close namespace VehiclesControl
