/*
 * File: TankUS Entry
 * Name: TankUSEntry.cs
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

    // public class TankUSEntry 
    public class TankUSEntry : MonoBehaviour
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
            // GameObject _tankUS
            [SerializeField] private GameObject _tankUS;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inTankUS is false
            [SerializeField] private bool _inTankUS = false;
        
        // TankUSController _tankUSScript
        private TankUSController _tankUSScript;

        // Camera _tankUSCamera
        private Camera _tankUSCamera;

        // AudioListener _tankUSCameraAudioListener
        private AudioListener _tankUSCameraAudioListener; 

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
            // _tankUSScript is GetComponent TankUSController
            _tankUSScript = GetComponent<TankUSController>();

            // _tankUSScript enabled is false
            _tankUSScript.enabled = false;
            
            // _tankUSScript is GetComponentInChildren
            _tankUSCamera = GetComponentInChildren<Camera>();

            // _tankUSCamera enabled is false
            _tankUSCamera.enabled = false;

            // _tankUSCameraAudioListener is GetComponentInChildren AudioListener
            _tankUSCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _tankUSCameraAudioListener enabled is false
            _tankUSCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName TankUS_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("TankUS_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTankUS and Input GetKey KeyCode _exitKey
            if (_inTankUS && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _tankUSScript enabled is false
                _tankUSScript.enabled = false;
                
                // _tankUSCamera enabled is false
                _tankUSCamera.enabled = false;

                // _tankUSCameraAudioListener enabled is false
                _tankUSCameraAudioListener.enabled = false; 

                // _inTankUS is false
                _inTankUS = false;

            } // close if _inTankUS and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTankUS and gameObject tag is Player
            if (!_inTankUS && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTankUS and gameObject tag is Player
            
            // if not _inTankUS and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTankUS && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _tankUS transform
                _player.transform.parent = _tankUS.transform;

                // _tankUSScript enabled is true
                _tankUSScript.enabled = true;
                
                // _tankUSCamera enabled is true
                _tankUSCamera.enabled = true;

                // _tankUSCameraAudioListener enabled is true
                _tankUSCameraAudioListener.enabled = true; 

                // _inTankUS is true
                _inTankUS = true;

            } // close if not _inTankUS and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TankUSEntry  

} // close namespace VehiclesControl
