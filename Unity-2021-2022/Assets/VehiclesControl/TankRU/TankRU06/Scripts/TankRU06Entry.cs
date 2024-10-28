/*
 * File: Tank RU 06 Entry
 * Name: TankRU06Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class TankRU06Entry 
    public class TankRU06Entry : MonoBehaviour
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

            [Tooltip("The tank ru 06 game object")]
            // GameObject _tankRU06
            [SerializeField] private GameObject _tankRU06;

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
            // bool _inTankRU06 is false
            [SerializeField] private bool _inTankRU06 = false;
        
        // TankRU06Controller _tankRU06Script
        private TankRU06Controller _tankRU06Script;

        // Camera _tankRU06Camera
        private Camera _tankRU06Camera;

        // AudioListener _tankRU06CameraAudioListener
        private AudioListener _tankRU06CameraAudioListener; 

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
            // _tankRU06Script is GetComponent TankRU06Controller
            _tankRU06Script = GetComponent<TankRU06Controller>();

            // _tankRU06Script enabled is false
            _tankRU06Script.enabled = false;
            
            // _tankRU06Script is GetComponentInChildren
            _tankRU06Camera = GetComponentInChildren<Camera>();

            // _tankRU06Camera enabled is false
            _tankRU06Camera.enabled = false;

            // _tankRU06CameraAudioListener is GetComponentInChildren AudioListener
            _tankRU06CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankRU06CameraAudioListener enabled is false
            _tankRU06CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankRU06_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankRU06_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankRU06 and Input GetKey KeyCode _exitKey
            if (_inTankRU06 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankRU06Script enabled is false
                _tankRU06Script.enabled = false;
                
                // _tankRU06Camera enabled is false
                _tankRU06Camera.enabled = false;

                // _tankRU06CameraAudioListener enabled is false
                _tankRU06CameraAudioListener.enabled = false; 

                // _inTankRU06 is false
                _inTankRU06 = false;

            } // close if _inTankRU06 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankRU06 and gameObject tag is Player
            if (!_inTankRU06 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankRU06 and gameObject tag is Player
            
            // if not _inTankRU06 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankRU06 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankRU06 transform
                _player.transform.parent = _tankRU06.transform;

                // _tankRU06Script enabled is true
                _tankRU06Script.enabled = true;
                
                // _tankRU06Camera enabled is true
                _tankRU06Camera.enabled = true;

                // _tankRU06CameraAudioListener enabled is true
                _tankRU06CameraAudioListener.enabled = true; 

                // _inTankRU06 is true
                _inTankRU06 = true;

            } // close if not _inTankRU06 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankRU06Entry  

} // close namespace VehiclesControl
