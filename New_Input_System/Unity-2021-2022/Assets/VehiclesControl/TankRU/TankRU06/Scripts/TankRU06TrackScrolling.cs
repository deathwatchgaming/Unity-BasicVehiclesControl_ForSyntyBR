/*
 * File: Tank RU 06 Track Scrolling
 * Name: TankRU06TrackScrolling.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
 */

// using
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// namespace VehiclesControl
namespace VehiclesControl
{
    // public class TankRU06TrackScrolling
    public class TankRU06TrackScrolling : MonoBehaviour
    {
        // TankRU06 Rigidbody
        [Header("TankRU06 Rigidbody")]

            [Tooltip("The TankRU06 Rigidbody")]
            // Rigidbody _rigidbody
            [SerializeField] Rigidbody _rigidbody;

        // Track Scrolling
        [Header("Track Scrolling")]

            [Tooltip("The tank tracks scroll speed amount")]
            // float _scrollSpeed is 0.05
            [SerializeField] private float _scrollSpeed = 0.05f;

            [Tooltip("The invert bool")]
            // bool _invert
            [SerializeField] private bool _invert;

            [Tooltip("The tank track mesh renderers")]
            // List MeshRenderer _trackRenderers
            [SerializeField] private List<MeshRenderer> _trackRenderers;

        // Vector3 _velocity
        private Vector3 _velocity;

        // Vector3 _forward
        private Vector3 _forward;

        // float _previousX
        private float _previousX;

        // float _offset
        private float _offset;

        // private void Update
        private void Update()
        {
            // _velocity is _rigidbody.velocity
            _velocity = _rigidbody.velocity;

            // _forward is transform.forward;
            _forward = transform.forward;
            
            // if _forward.x >= 0 and _velocity.x >= 0 _forward.x < 0 and _velocity.x < 0
            if ((_forward.x >= 0 && _velocity.x >= 0) || (_forward.x < 0 && _velocity.x < 0))
            {
                // _previousX is 1
                _previousX = 1;

            } // close if _forward.x >= 0 and _velocity.x >= 0 _forward.x < 0 and _velocity.x < 0

            // else if _forward.x < 0 and _velocity.x >= 0  _forward.x >= 0 and _velocity.x < 0
            else if ((_forward.x < 0 && _velocity.x >= 0) || (_forward.x >= 0 && _velocity.x < 0))
            {
                // _previousX is -1
                _previousX = -1;

            } // close if _forward.x < 0 and _velocity.x >= 0  _forward.x >= 0 and _velocity.x < 0
            
            // if _invert
            if (_invert)
            {
                // _offset is _offset plus _velocity.magnitude times minus _previousX times _scrollSpeed
                _offset = (_offset + (_velocity.magnitude * -_previousX) * _scrollSpeed) % 1f;

            } // close if _invert
            
            // else
            else
            {
                // _offset is _offset plus _velocity.magnitude times _previousX times _scrollSpeed
                _offset = (_offset + (_velocity.magnitude * _previousX) * _scrollSpeed) % 1f;

            } // close else
            
            // foreach var _meshRenderer in _trackRenderers
            foreach (var _meshRenderer in _trackRenderers)
            {
                // _meshRenderer materials[] mainTexturOffset is Vector2 _offset, 0f
                //_meshRenderer.materials[0].mainTextureOffset = new Vector2(_offset, 0f);
                _meshRenderer.materials[0].mainTextureOffset = new Vector2(0f, _offset);

            } // close foreach var _meshRenderer in _trackRenderers

        } // close private void Update

    } // close public class TankRU06TrackScrolling

} // close namespace VehiclesControl
