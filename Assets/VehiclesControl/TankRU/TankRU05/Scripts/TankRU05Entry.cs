/*
 * File: Tank RU 05 Entry
 * Name: TankRU05Entry.cs
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

    // public class TankRU05Entry 
    public class TankRU05Entry : MonoBehaviour
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

            [Tooltip("The tank ru 05 game object")]
            // GameObject _tankRU05
            [SerializeField] private GameObject _tankRU05;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inTankRU05 is false
            [SerializeField] private bool _inTankRU05 = false;
        
        // TankRU05Controller _tankRU05Script
        private TankRU05Controller _tankRU05Script;

        // Camera _tankRU05Camera
        private Camera _tankRU05Camera;

        // AudioListener _tankRU05CameraAudioListener
        private AudioListener _tankRU05CameraAudioListener; 

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
            // _tankRU05Script is GetComponent TankRU05Controller
            _tankRU05Script = GetComponent<TankRU05Controller>();

            // _tankRU05Script enabled is false
            _tankRU05Script.enabled = false;
            
            // _tankRU05Script is GetComponentInChildren
            _tankRU05Camera = GetComponentInChildren<Camera>();

            // _tankRU05Camera enabled is false
            _tankRU05Camera.enabled = false;

            // _tankRU05CameraAudioListener is GetComponentInChildren AudioListener
            _tankRU05CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankRU05CameraAudioListener enabled is false
            _tankRU05CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankRU05_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankRU05_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankRU05 and Input GetKey KeyCode _exitKey
            if (_inTankRU05 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankRU05Script enabled is false
                _tankRU05Script.enabled = false;
                
                // _tankRU05Camera enabled is false
                _tankRU05Camera.enabled = false;

                // _tankRU05CameraAudioListener enabled is false
                _tankRU05CameraAudioListener.enabled = false; 

                // _inTankRU05 is false
                _inTankRU05 = false;

            } // close if _inTankRU05 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankRU05 and gameObject tag is Player
            if (!_inTankRU05 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankRU05 and gameObject tag is Player
            
            // if not _inTankRU05 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankRU05 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankRU05 transform
                _player.transform.parent = _tankRU05.transform;

                // _tankRU05Script enabled is true
                _tankRU05Script.enabled = true;
                
                // _tankRU05Camera enabled is true
                _tankRU05Camera.enabled = true;

                // _tankRU05CameraAudioListener enabled is true
                _tankRU05CameraAudioListener.enabled = true; 

                // _inTankRU05 is true
                _inTankRU05 = true;

            } // close if not _inTankRU05 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankRU05Entry  

} // close namespace VehiclesControl
