/*
 * File: Six Wheel Truck 06 Controller
 * Name: SixWheelTruck06Controller.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// Front Wheels Collider Radius: 0.6400671
// Front Wheels Collider Position Y: 0.7900671 (0.6400671+0.15)

// Rear Wheels Collider Radius: 0.6400672
// Rear Wheels Collider Position Y: 0.7900672 (0.6400672+0.15)

// using
using System;
using UnityEngine;

// namespace VehiclesControl
namespace VehiclesControl
{
	// public enum SixWheelTruck06SpeedType
	public enum SixWheelTruck06SpeedType
	{
		mph,
		kmh	

	} // close public enum SixWheelTruck06SpeedType

	// RequireComponent typeof MeshCollider
	[RequireComponent(typeof(MeshCollider))]

	// RequireComponent typeof Rigidbody
	[RequireComponent(typeof(Rigidbody))]

	// public class SixWheelTruck06Controller
	public class SixWheelTruck06Controller : MonoBehaviour
	{
		// Input Customizations
		[Header("Input Customizations")]

			[Tooltip("The vertical movement input string")]
			// string _verticalMoveInput
			[SerializeField] private string _verticalMoveInput = "Vertical";	

			[Tooltip("The horizontal movement input string")]
			// string _horizontalMoveInput
			[SerializeField] private string _horizontalMoveInput = "Horizontal";

			[Tooltip("The brake input keycode key")]
			// KeyCode _brakeKey
			[SerializeField] private KeyCode _brakeKey = KeyCode.Space;
					    		
		// Require Components
		[Header("Require Components")]

			[Tooltip("The rigidbody component")]
			// Rigidbody _rigidbody
			[SerializeField] Rigidbody _rigidbody;	

			[Tooltip("The mesh collider component")]
			// MeshCollider _meshCollider
			[SerializeField] private MeshCollider _meshCollider;	

		// Wheel Transforms
		[Header("Wheel Transforms")]

			[Tooltip("The front left wheel transform")]
			// Transform _frontLeftTransform
			[SerializeField] private Transform _frontLeftTransform;

			[Tooltip("The front right wheel transform")]
			// Transform _frontRightTransform
			[SerializeField] private Transform _frontRightTransform;

			[Tooltip("The first rear left wheel transform")]
			// Transform _rearLeft01Transform
			[SerializeField] private Transform _rearLeft01Transform;

			[Tooltip("The second rear left wheel transform")]
			// Transform _rearLeft02Transform
			[SerializeField] private Transform _rearLeft02Transform;

			[Tooltip("The first rear right wheel transform")]
			// Transform _rearRight01Transform
			[SerializeField] private Transform _rearRight01Transform;

			[Tooltip("The second rear right wheel transform")]
			// Transform _rearRight02Transform
			[SerializeField] private Transform _rearRight02Transform;

		// Wheel Colliders
		[Header("Wheel Colliders")]

			[Tooltip("The front left wheel collider")]
			// WheelCollider _frontLeft
			[SerializeField] private WheelCollider _frontLeft;

			[Tooltip("The front right wheel collider")]
			// WheelCollider _frontRight
			[SerializeField] private WheelCollider _frontRight;

			[Tooltip("The first rear left wheel collider")]
			// WheelCollider _rearLeft01
			[SerializeField] private WheelCollider _rearLeft01;

			[Tooltip("The second rear left wheel collider")]
			// WheelCollider _rearLeft02
			[SerializeField] private WheelCollider _rearLeft02;

			[Tooltip("The first rear right wheel collider")]
			// WheelCollider _rearRight01
			[SerializeField] private WheelCollider _rearRight01;

			[Tooltip("The second rear right wheel collider")]
			// WheelCollider _rearRight02
			[SerializeField] private WheelCollider _rearRight02;
					    	    
		// Amounts
		[Header("Amounts")]

			[Tooltip("The acceleration amount")]
			// _acceleration is 500
			[SerializeField] private float _acceleration = 500f;

			[Tooltip("The braking force amount")]
			// _brakingForce is 300
			[SerializeField] private float _brakingForce = 300f; 

			[Tooltip("The maximum turn angle amount")]
			// _maxTurnAngle is 15
			[SerializeField] private float _maxTurnAngle = 15f;

			[Tooltip("The center of gravity offset amount")]	    
			// _centerOfGravityOffset is -1
			[SerializeField] private float _centerOfGravityOffset = -1f;

			[Tooltip("The rigidbody component mass")]
			// float _rigidbodyMass is 3500
			[SerializeField] private float _rigidbodyMass = 3500f;

			// _currentAcceleration is 0
			private float _currentAcceleration = 0f;

			// _currentBrakeForce is 0
			private float _currentBrakeForce = 0f;
		    
			// _currentTurnAngle is 0
			private float _currentTurnAngle = 0f;

		// Speed
		[Header("Speed")]

			[Tooltip("The speed measurement unit")]
			// SixWheelTruck06SpeedType _speedType	
			[SerializeField] private SixWheelTruck06SpeedType _speedType;			
	    
			[Tooltip("The maximum speed amount")]
			// float _maxSpeed
			[SerializeField] private float _maxSpeed = 180;	

		// private void Awake
		private void Awake()
		{
			// _rigidbody is GetComponent Rigidbody
			_rigidbody = GetComponent<Rigidbody>();
	        
			// _rigidbody mass is _rigidbodyMass
			_rigidbody.mass = _rigidbodyMass;
		
			// Adjust the center of mass vertically to help prevent the truck from rolling
			// _rigidbody centerOfMass
			_rigidbody.centerOfMass += Vector3.up * _centerOfGravityOffset;	

			// _meshCollider is GetComponent MeshCollider
			_meshCollider = GetComponent<MeshCollider>();

			// _meshCollider convex is true
			_meshCollider.convex = true;
	        
		} // close private void Awake
		
		// private void Update
		private void Update()
		{
			// Handle Speed
			HandleSpeed();

		} // close private void Update

		// private void FixedUpdate
		private void FixedUpdate()
		{
			// Get the forward and reverse acceleration from vertical axis (W and S keys)
	        
			// _currentAcceleration is _acceleration times Input GetAxis Vertical
			_currentAcceleration = _acceleration * Input.GetAxis(_verticalMoveInput);

			// If we are pressing the _brakeKey then give currentBrakingForce a value

			// if Input GetKey KeyCode _brakeKey
			if (Input.GetKey(_brakeKey))
			{
				// _currentBrakeForce is _brakingForce
				_currentBrakeForce = _brakingForce;

			} // close if Input GetKey KeyCode _brakeKey
	        
			// else 
			else
			{
				// _currentBrakeForce is 0
				_currentBrakeForce = 0f;

			} // close else

			// Apply acceleration to the front wheels
	        
			// _frontLeft motorTorque is _currentAcceleration
			_frontLeft.motorTorque = _currentAcceleration;

			// _frontRight motorTorque is _currentAcceleration
			_frontRight.motorTorque = _currentAcceleration;

			// Apply braking force to all of the wheels

			// _frontLeft brakeTorque is _currentBrakeForce
			_frontLeft.brakeTorque = _currentBrakeForce;

			// _frontRight brakeTorque is _currentBrakeForce
			_frontRight.brakeTorque = _currentBrakeForce;

			// _rearLeft01 brakeTorque is _currentBrakeForce
			_rearLeft01.brakeTorque = _currentBrakeForce;

			// _rearLeft02 brakeTorque is _currentBrakeForce
			_rearLeft02.brakeTorque = _currentBrakeForce;

			// _rearRight01 brakeTorque is _currentBrakeForce
			_rearRight01.brakeTorque = _currentBrakeForce;

			// _rearRight02 brakeTorque is _currentBrakeForce
			_rearRight02.brakeTorque = _currentBrakeForce;

			// Take care of the front wheels steering

			// _currentTurnAngle is _maxTurnAngle times Input GetAxis Horizontal
			_currentTurnAngle = _maxTurnAngle * Input.GetAxis(_horizontalMoveInput);

			// _frontLeft steerAngle is _currentTurnAngle
			_frontLeft.steerAngle = _currentTurnAngle;

			// _frontRight steerAngle is _currentTurnAngle
			_frontRight.steerAngle = _currentTurnAngle;

			// Update the wheel meshes

			// UpdateLeftWheel _frontLeft _frontLeftTransform
			UpdateLeftWheel(_frontLeft, _frontLeftTransform); 

			// UpdateRightWheel _frontRight _frontRightTransform
			UpdateRightWheel(_frontRight, _frontRightTransform);

			// UpdateLeftWheel _rearLeft01 _rearLeft01Transform
			UpdateLeftWheel(_rearLeft01, _rearLeft01Transform);

			// UpdateLeftWheel _rearLeft02 _rearLeft02Transform
			UpdateLeftWheel(_rearLeft02, _rearLeft02Transform); 

			// UpdateRightWheel _rearRight01 _rearRight01Transform
			UpdateRightWheel(_rearRight01, _rearRight01Transform);
	 
			// UpdateRightWheel _rearRight02 _rearRight02Transform
			UpdateRightWheel(_rearRight02, _rearRight02Transform);

		} // close private void FixedUpdate

		// private void UpdateLeftWheel WheelCollider _leftCollider Transform _leftTransform
		private void UpdateLeftWheel(WheelCollider _leftCollider, Transform _leftTransform)
		{
			// Get the left wheels collider states

			// Vector3 _leftPosition
			Vector3 _leftPosition;

			// Quaternion _leftRotation
			Quaternion _leftRotation;

			// leftCollider GetWorldPose out _leftPosition out _leftRotation
			_leftCollider.GetWorldPose(out _leftPosition, out _leftRotation);

			// Set the left wheels transform states

			// _leftTransform position is _leftPosition
			_leftTransform.position = _leftPosition;

			// _leftTransform rotation is _leftRotation
			_leftTransform.rotation = _leftRotation;

		} // close private void UpdateLeftWheel WheelCollider _leftCollider Transform _leftTransform
	    
		// private void UpdateRightWheel WheelCollider _rightCollider Transform _rightTransform
		private void UpdateRightWheel(WheelCollider _rightCollider, Transform _rightTransform)
		{
			// Get the right wheels collider states

			// Vector3 _rightPosition
			Vector3 _rightPosition;

			// Quaternion _rightRotation
			Quaternion _rightRotation;

			// _rightCollider GetWorldPose out _rightPosition out _rightRotation
			_rightCollider.GetWorldPose(out _rightPosition, out _rightRotation);

			// Set the right wheels transform states

			// _rightTransform position is _rightPosition
			_rightTransform.position = _rightPosition;

			// _rightTransform rotation is _rightRotation
			_rightTransform.rotation = _rightRotation;

		} // close private void UpdateRightWheel WheelCollider _rightCollider Transform _rightTransform
		
		// private void HandleSpeed
		private void HandleSpeed()
		{
			// Take care of speed unit type and max speed

			// float _speed
			float _speed = _rigidbody.linearVelocity.magnitude;

			// _speedType equals SixWheelTruck06SpeedType.mph
			if (_speedType == SixWheelTruck06SpeedType.mph)
			{
				// 2.23694 is the constant to convert a value from m/s to mph

				// _speed
				_speed *= 2.23694f;

				// if _speed > _maxSpeed
				if (_speed > _maxSpeed)
				{
					// _rigidbody.velocity
					_rigidbody.linearVelocity = (_maxSpeed/2.23694f) * _rigidbody.linearVelocity.normalized;

				} // close if _speed > _maxSpeed
                        
			} // close if _speedType equals SixWheelTruck06SpeedType.mph

			// else if _speedType equals SixWheelTruck06SpeedType.kmh
			else if (_speedType == SixWheelTruck06SpeedType.kmh)
			{
				// 3.6 is the constant to convert a value from m/s to km/h
				
				// _speed
				_speed *= 3.6f;

				// if _speed > _maxSpeed
				if (_speed > _maxSpeed)
				{
					// _rigidbody.velocity
					_rigidbody.linearVelocity = (_maxSpeed/3.6f) * _rigidbody.linearVelocity.normalized;

				} // close if _speed > _maxSpeed
                       
			} // close else if _speedType equals SixWheelTruck06SpeedType.kmh

		} // close private void HandleSpeed

	} // close public class SixWheelTruck06Controller

} //close namespace VehiclesControl
