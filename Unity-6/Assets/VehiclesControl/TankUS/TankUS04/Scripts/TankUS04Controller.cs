/*
 * File: TankUS 04 Controller
 * Name: TankUS04Controller.cs
 * Author: DeathwatchGaming
 * License: MIT
 */

// using
using System;
using UnityEngine;

// namespace VehiclesControl
namespace VehiclesControl
{
	// public enum TankUS04SpeedType
	public enum TankUS04SpeedType
	{
		mph,
		kmh	

	} // close public enum TankUS04SpeedType

	// RequireComponent typeof MeshCollider
	[RequireComponent(typeof(MeshCollider))]

	// RequireComponent typeof Rigidbody
	[RequireComponent(typeof(Rigidbody))]

	// public class TankUS04Controller
	public class TankUS04Controller : MonoBehaviour
	{
		// Input Customizations
		[Header("Input Customizations")]

			[Tooltip("The vertical movement input string")]
			// string _verticalMoveInput is Vertical
			[SerializeField] private string _verticalMoveInput = "Vertical";	

			[Tooltip("The horizontal movement input string")]
			// string _horizontalMoveInput is Horizontal
			[SerializeField] private string _horizontalMoveInput = "Horizontal";

			[Tooltip("The mouse x input string")]
			// string _mouseXInput is Mouse X
			[SerializeField] private string _mouseXInput = "Mouse X";

			[Tooltip("The mouse y input string")]
			// string _mouseXInput is Mouse Y
			[SerializeField] private string _mouseYInput = "Mouse Y";

			[Tooltip("The brake input keycode key")]
			// KeyCode _brakeKey is KeyCode Space
			[SerializeField] private KeyCode _brakeKey = KeyCode.Space;

		// Require Components
		[Header("Require Components")]

			[Tooltip("The rigidbody component")]
			// Rigidbody _rigidbody
			[SerializeField] Rigidbody _rigidbody;	

			[Tooltip("The mesh collider component")]
			// MeshCollider _meshCollider
			[SerializeField] private MeshCollider _meshCollider;

		// TankUS04 Transforms
		[Header("TankUS04 Transforms")]

			[Tooltip("The tank body transform")]	    
			// _tankUS04Body
			[SerializeField] private Transform _tankUS04Body;

			[Tooltip("The tank turret transform")]	    
			// _tankUS04Turret						
			[SerializeField] private Transform _tankUS04Turret;

			[Tooltip("The tank barrel transform")]	    
			// _tankUS04Barrel					
			[SerializeField] private Transform _tankUS04Barrel;			

		// Wheel Transforms
		[Header("Wheel Transforms")]

			// Left Wheel Transforms

			[Tooltip("The first left wheel transform")]
			// Transform _left01Transform
			[SerializeField] private Transform _left01Transform;

			[Tooltip("The second left wheel transform")]
			// Transform _left02Transform
			[SerializeField] private Transform _left02Transform;

			[Tooltip("The third left wheel transform")]
			// Transform _left03Transform
			[SerializeField] private Transform _left03Transform;

			[Tooltip("The fourth left wheel transform")]
			// Transform _left04Transform
			[SerializeField] private Transform _left04Transform;

			[Tooltip("The fifth left wheel transform")]
			// Transform _left05Transform
			[SerializeField] private Transform _left05Transform;

			[Tooltip("The sixth left wheel transform")]
			// Transform _left06Transform
			[SerializeField] private Transform _left06Transform;

			[Tooltip("The seventh left wheel transform")]
			// Transform _left07Transform
			[SerializeField] private Transform _left07Transform;

			[Tooltip("The eighth left wheel transform")]
			// Transform _left08Transform
			[SerializeField] private Transform _left08Transform;

			[Tooltip("The ninth left wheel transform")]
			// Transform _left09Transform
			[SerializeField] private Transform _left09Transform;

			// Right Wheel Transforms

			[Tooltip("The first right wheel transform")]
			// Transform _right01Transform
			[SerializeField] private Transform _right01Transform;

			[Tooltip("The second right wheel transform")]
			// Transform _right02Transform
			[SerializeField] private Transform _right02Transform;

			[Tooltip("The third right wheel transform")]
			// Transform _right03Transform
			[SerializeField] private Transform _right03Transform;

			[Tooltip("The fourth right wheel transform")]
			// Transform _right04Transform
			[SerializeField] private Transform _right04Transform;

			[Tooltip("The fifth right wheel transform")]
			// Transform _right05Transform
			[SerializeField] private Transform _right05Transform;

			[Tooltip("The sixth right wheel transform")]
			// Transform _right06Transform
			[SerializeField] private Transform _right06Transform;

			[Tooltip("The seventh right wheel transform")]
			// Transform _right07Transform
			[SerializeField] private Transform _right07Transform;

			[Tooltip("The eighth right wheel transform")]
			// Transform _right08Transform
			[SerializeField] private Transform _right08Transform;

			[Tooltip("The ninth right wheel transform")]
			// Transform _right09Transform
			[SerializeField] private Transform _right09Transform;

		// Wheel Colliders
		[Header("Wheel Colliders")]

			// Left Wheel Colliders

			[Tooltip("The first left wheel collider")]
			// WheelCollider _left01
			[SerializeField] private WheelCollider _left01;

			[Tooltip("The second left wheel collider")]
			// WheelCollider _left02
			[SerializeField] private WheelCollider _left02;

			[Tooltip("The third left wheel collider")]
			// WheelCollider _left03
			[SerializeField] private WheelCollider _left03;

			[Tooltip("The fourth left wheel collider")]
			// WheelCollider _left04
			[SerializeField] private WheelCollider _left04;
		    
			[Tooltip("The fifth left wheel collider")]
			// WheelCollider _left05
			[SerializeField] private WheelCollider _left05;

			[Tooltip("The sixth left wheel collider")]
			// WheelCollider _left06
			[SerializeField] private WheelCollider _left06;

			[Tooltip("The seventh left wheel collider")]
			// WheelCollider _left07
			[SerializeField] private WheelCollider _left07;

			[Tooltip("The eighth left wheel collider")]
			// WheelCollider _left08
			[SerializeField] private WheelCollider _left08;

			[Tooltip("The ninth left wheel collider")]
			// WheelCollider _left09
			[SerializeField] private WheelCollider _left09;		    

			// Right Wheel Colliders

			[Tooltip("The first right wheel collider")]
			// WheelCollider _right01
			[SerializeField] private WheelCollider _right01;

			[Tooltip("The second right wheel collider")]
			// WheelCollider _right02
			[SerializeField] private WheelCollider _right02;

			[Tooltip("The third right wheel collider")]
			// WheelCollider _right03
			[SerializeField] private WheelCollider _right03;

			[Tooltip("The fourth right wheel collider")]
			// WheelCollider _right04
			[SerializeField] private WheelCollider _right04;

			[Tooltip("The fifth right wheel collider")]
			// WheelCollider _right05
			[SerializeField] private WheelCollider _right05;

			[Tooltip("The sixth right wheel collider")]
			// WheelCollider _right06
			[SerializeField] private WheelCollider _right06;

			[Tooltip("The seventh right wheel collider")]
			// WheelCollider _right07
			[SerializeField] private WheelCollider _right07;

			[Tooltip("The eighth right wheel collider")]
			// WheelCollider _right08
			[SerializeField] private WheelCollider _right08;

			[Tooltip("The ninth right wheel collider")]
			// WheelCollider _right09
			[SerializeField] private WheelCollider _right09;

		// Amounts
		[Header("Amounts")]

			[Tooltip("The tank body rotation speed")]	    
			// _tankUS04RotationSpeed is 0.35
			[SerializeField] private float _tankUS04RotationSpeed = 0.35f;

			[Tooltip("The tank turret rotation speed")]	    
			// _turretRotationSpeed is 0.35
			[SerializeField] private float _turretRotationSpeed = 0.35f;

			[Tooltip("The tank barrel minimum")]	    
			// _barrelMin is -10
			[SerializeField] private float _barrelMin = -10.0f;

			[Tooltip("The tank barrel maximum")]	    
			// _barrelMax is 10
			[SerializeField] private float _barrelMax = 10.0f;			

			[Tooltip("The acceleration amount")]
			// _acceleration is 125
			[SerializeField] private float _acceleration = 125f;

			[Tooltip("The braking force amount")]
			// _brakingForce is 600
			[SerializeField] private float _brakingForce = 600f; 

			[Tooltip("The center of gravity offset amount")]	    
			// _centerOfGravityOffset is -1
			[SerializeField] private float _centerOfGravityOffset = -1f;

			[Tooltip("The rigidbody component mass")]
			// float _rigidbodyMass is 7000
			[SerializeField] private float _rigidbodyMass = 7000f;

			// _currentAcceleration is 0
			private float _currentAcceleration = 0f;

			// _currentBrakeForce is 0
			private float _currentBrakeForce = 0f;

			// _barrelElevation is 0
			private float _barrelElevation = 0f;		

			// Vector3 _tankUS04Rotation
			private Vector3 _tankUS04BodyRotation;

			// Vector3 _tankUS04TurretRotation
			private Vector3 _tankUS04TurretRotation;

		// Speed
		[Header("Speed")]

			[Tooltip("The speed measurement unit")]
			// TankUS04SpeedType _speedType	
			[SerializeField] private TankUS04SpeedType _speedType;			
	    
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
		
			// Adjust the center of mass vertically to help prevent the tank from rolling
			// _rigidbody centerOfMass
			_rigidbody.centerOfMass += Vector3.up * _centerOfGravityOffset;

			// _meshCollider is GetComponent MeshCollider
			_meshCollider = GetComponent<MeshCollider>();

			// _meshCollider convex is true
			_meshCollider.convex = true;
			
			// _tankUS04Rotation is _tankUS04Rotation.transform.eulerAngles
			_tankUS04BodyRotation = _tankUS04Body.transform.eulerAngles;

			// _tankUS04TurretRotation is _tankUS04Turret.transform.eulerAngles
			_tankUS04TurretRotation = _tankUS04Turret.transform.eulerAngles;
	        
		} // close private void Awake

		// private void Start
		private void Start()
		{
			// Cursor lockState is CursorLockMode Locked
			Cursor.lockState = CursorLockMode.Locked;

			// Cursor visible is false
			Cursor.visible = false;

		} // close private void Start

		// private void Update
		private void Update()
		{
			// Handle Speed
			HandleSpeed();

			// Handle Steering
			HandleSteering();
            
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

			// Apply acceleration to the wheels

			// Left Wheels

			// _left01 motorTorque is _currentAcceleration
			_left01.motorTorque = _currentAcceleration;	

			// _left02 motorTorque is _currentAcceleration
			_left02.motorTorque = _currentAcceleration;	

			// _left03 motorTorque is _currentAcceleration
			_left03.motorTorque = _currentAcceleration;	

			// _left04 motorTorque is _currentAcceleration
			_left04.motorTorque = _currentAcceleration;	

			// _left05 motorTorque is _currentAcceleration
			_left05.motorTorque = _currentAcceleration;	

			// _left06 motorTorque is _currentAcceleration
			_left06.motorTorque = _currentAcceleration;	

			// _left07 motorTorque is _currentAcceleration
			_left07.motorTorque = _currentAcceleration;	

			// _left08 motorTorque is _currentAcceleration
			_left08.motorTorque = _currentAcceleration;	

			// Left Sprocket

			// _left09 motorTorque is _currentAcceleration
			_left09.motorTorque = _currentAcceleration;

			// Right Wheels

			// _right01 motorTorque is _currentAcceleration
			_right01.motorTorque = _currentAcceleration;

			// _right02 motorTorque is _currentAcceleration
			_right02.motorTorque = _currentAcceleration;

			// _right03 motorTorque is _currentAcceleration
			_right03.motorTorque = _currentAcceleration;

			// _right04 motorTorque is _currentAcceleration
			_right04.motorTorque = _currentAcceleration;

			// _right05 motorTorque is _currentAcceleration
			_right05.motorTorque = _currentAcceleration;

			// _right06 motorTorque is _currentAcceleration
			_right06.motorTorque = _currentAcceleration;

			// _right07 motorTorque is _currentAcceleration
			_right07.motorTorque = _currentAcceleration;

			// _right08 motorTorque is _currentAcceleration
			_right08.motorTorque = _currentAcceleration;			

			// Right Sprocket

			// _right09 motorTorque is _currentAcceleration
			_right09.motorTorque = _currentAcceleration;

			// Apply braking force to all of the wheels

			// Left Wheels

			// _left01 brakeTorque is _currentBrakeForce
			_left01.brakeTorque = _currentBrakeForce;

			// _left02 brakeTorque is _currentBrakeForce
			_left02.brakeTorque = _currentBrakeForce;

			// _left03 brakeTorque is _currentBrakeForce
			_left03.brakeTorque = _currentBrakeForce;

			// _left04 brakeTorque is _currentBrakeForce
			_left04.brakeTorque = _currentBrakeForce;

			// _left05 brakeTorque is _currentBrakeForce
			_left05.brakeTorque = _currentBrakeForce;

			// _left06 brakeTorque is _currentBrakeForce
			_left06.brakeTorque = _currentBrakeForce;

			// _left07 brakeTorque is _currentBrakeForce
			_left07.brakeTorque = _currentBrakeForce;

			// _left08 brakeTorque is _currentBrakeForce
			_left08.brakeTorque = _currentBrakeForce;

			// _left09 brakeTorque is _currentBrakeForce
			_left09.brakeTorque = _currentBrakeForce;

			// Right Wheels

			// _right01 brakeTorque is _currentBrakeForce
			_right01.brakeTorque = _currentBrakeForce;	        

			// _right02 brakeTorque is _currentBrakeForce
			_right02.brakeTorque = _currentBrakeForce;	

			// _right03 brakeTorque is _currentBrakeForce
			_right03.brakeTorque = _currentBrakeForce;

			// _right04 brakeTorque is _currentBrakeForce
			_right04.brakeTorque = _currentBrakeForce;	

			// _right05 brakeTorque is _currentBrakeForce
			_right05.brakeTorque = _currentBrakeForce;	

			// _right06 brakeTorque is _currentBrakeForce
			_right06.brakeTorque = _currentBrakeForce;	

			// _right07 brakeTorque is _currentBrakeForce
			_right07.brakeTorque = _currentBrakeForce;	

			// _right08 brakeTorque is _currentBrakeForce
			_right08.brakeTorque = _currentBrakeForce;

			// _right09 brakeTorque is _currentBrakeForce
			_right09.brakeTorque = _currentBrakeForce;	

			// Update the wheel meshes

			// Left Wheels

			// UpdateLeftWheel _left01 _left01Transform
			UpdateLeftWheel(_left01, _left01Transform); 

			// UpdateLeftWheel _left02 _left02Transform
			UpdateLeftWheel(_left02, _left02Transform);

			// UpdateLeftWheel _left03 _left03Transform
			UpdateLeftWheel(_left03, _left03Transform); 

			// UpdateLeftWheel _left04 _left04Transform
			UpdateLeftWheel(_left04, _left04Transform);

			// UpdateLeftWheel _left05 _left05Transform
			UpdateLeftWheel(_left05, _left05Transform); 

			// UpdateLeftWheel _left06 _left06Transform
			UpdateLeftWheel(_left06, _left06Transform); 

			// UpdateLeftWheel _left07 _left07Transform
			UpdateLeftWheel(_left07, _left07Transform); 

			// UpdateLeftWheel _left08 _left08Transform
			UpdateLeftWheel(_left08, _left08Transform); 

			// UpdateLeftWheel _left09 _left09Transform
			UpdateLeftWheel(_left09, _left09Transform); 

			// Right Wheels

			// UpdateRightWheel _right01 _right01Transform
			UpdateRightWheel(_right01, _right01Transform); 

			// UpdateRightWheel _right02 _right02Transform
			UpdateRightWheel(_right02, _right02Transform);

			// UpdateRightWheel _right03 _right03Transform
			UpdateRightWheel(_right03, _right03Transform); 

			// UpdateRightWheel _right04 _right04Transform
			UpdateRightWheel(_right04, _right04Transform); 

			// UpdateRightWheel _right05 _right05Transform
			UpdateRightWheel(_right05, _right05Transform); 

			// UpdateRightWheel _right06 _right06Transform
			UpdateRightWheel(_right06, _right06Transform); 

			// UpdateRightWheel _right07 _right07Transform
			UpdateRightWheel(_right07, _right07Transform); 

			// UpdateRightWheel _right08 _right08Transform
			UpdateRightWheel(_right08, _right08Transform); 

			// UpdateRightWheel _right09 _right09Transform
			UpdateRightWheel(_right09, _right09Transform); 

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

			// _speedType equals TankUS04SpeedType.mph
			if (_speedType == TankUS04SpeedType.mph)
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
                        
			} // close if _speedType equals TankUS04SpeedType.mph

			// else if _speedType equals TankUS04SpeedType.kmh
			else if (_speedType == TankUS04SpeedType.kmh)
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
                       
			} // close else if _speedType equals TankUS04SpeedType.kmh
            
		} // close private void HandleSpeed

		// private void HandleSteering
		private void HandleSteering()
		{						
			// Take care of the tank body steering
		
			// _tankUS04Rotation.transform.eulerAngles is _tankUS04Rotation
			_tankUS04Body.transform.eulerAngles = _tankUS04BodyRotation;

			// _tankUS04Rotation.y is Input GetAxis _horizontalMoveInput times _tankUS04RotationSpeed
			_tankUS04BodyRotation.y += Input.GetAxis(_horizontalMoveInput) * _tankUS04RotationSpeed;

			// Take care of the tank turret steering
		
			// _tankUS04Turret.transform.eulerAngles is _tankUS04TurretRotation
			_tankUS04Turret.transform.eulerAngles = _tankUS04TurretRotation;

			// _tankUS04TurretRotation.y is Input GetAxis _mouseXInput times _turretRotationSpeed
			_tankUS04TurretRotation.y += Input.GetAxis(_mouseXInput) * _turretRotationSpeed;

			// Take care of the tank barrel elevation control
            
			// _barrelVert is Input GetAxis _mouseYInput
			float _barrelVert = Input.GetAxis(_mouseYInput);

			// _barrelElevation is Mathf Clamp _barrelElevation plus _barrelVert, _barrelMin, _barrelMax
			_barrelElevation = Mathf.Clamp(_barrelElevation+_barrelVert, _barrelMin, _barrelMax);

			// _tankUS04Barrel.localRotation is Quaternion Euler _barrelElevation, 0, 0
			_tankUS04Barrel.localRotation = Quaternion.Euler(_barrelElevation, 0, 0);
            
		} // close private void HandleSteering

	} // close public class TankUS04Controller

} // close namespace VehiclesControl
