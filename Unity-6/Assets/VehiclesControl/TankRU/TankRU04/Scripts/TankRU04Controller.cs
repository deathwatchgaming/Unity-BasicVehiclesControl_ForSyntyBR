/*
 * File: Tank RU 04 Controller
 * Name: TankRU04Controller.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// using
using System;
using UnityEngine;

// namespace VehiclesControl
namespace VehiclesControl
{
	// public enum TankRU04SpeedType
	public enum TankRU04SpeedType
	{
		mph,
		kmh	

	} // close public enum TankRU04SpeedType

	// RequireComponent typeof MeshCollider
	[RequireComponent(typeof(MeshCollider))]

	// RequireComponent typeof Rigidbody
	[RequireComponent(typeof(Rigidbody))]

	// public class TankRU04Controller
	public class TankRU04Controller : MonoBehaviour
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

		// TankRU04 Transforms
		[Header("TankRU04 Transforms")]

			[Tooltip("The tank body transform")]	    
			// _tankRU04Body
			[SerializeField] private Transform _tankRU04Body;

			[Tooltip("The tank turret transform")]	    
			// _tankRU04Turret						
			[SerializeField] private Transform _tankRU04Turret;

			[Tooltip("The tank barrel transform")]	    
			// _tankRU04Barrel					
			[SerializeField] private Transform _tankRU04Barrel;			

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

		// Amounts
		[Header("Amounts")]

			[Tooltip("The tank body rotation speed")]	    
			// _tankRU04RotationSpeed is 0.35
			[SerializeField] private float _tankRU04RotationSpeed = 0.35f;

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

			// Vector3 _tankRU04Rotation
			private Vector3 _tankRU04BodyRotation;

			// Vector3 _tankRU04TurretRotation
			private Vector3 _tankRU04TurretRotation;

		// Speed
		[Header("Speed")]

			[Tooltip("The speed measurement unit")]
			// TankRU04SpeedType _speedType	
			[SerializeField] private TankRU04SpeedType _speedType;			
	    
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

			// _tankRU04Rotation is _tankRU04Rotation.transform.eulerAngles
			_tankRU04BodyRotation = _tankRU04Body.transform.eulerAngles;

			// _tankRU04TurretRotation is _tankRU04Turret.transform.eulerAngles
			_tankRU04TurretRotation = _tankRU04Turret.transform.eulerAngles;

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

			// Left Sprocket

			// _left07 motorTorque is _currentAcceleration
			_left07.motorTorque = _currentAcceleration;

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

			// Right Sprocket

			// _right07 motorTorque is _currentAcceleration
			_right07.motorTorque = _currentAcceleration;

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

			// _speedType equals TankRU04SpeedType.mph
			if (_speedType == TankRU04SpeedType.mph)
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
                        
			} // close if _speedType equals TankRU04SpeedType.mph

			// else if _speedType equals TankRU04SpeedType.kmh
			else if (_speedType == TankRU04SpeedType.kmh)
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
                       
			} // close else if _speedType equals TankRU04SpeedType.kmh
            
		} // close private void HandleSpeed

		// private void HandleSteering
		private void HandleSteering()
		{			
			// Take care of the tank body steering
		
			// _tankRU04Rotation.transform.eulerAngles is _tankRU04Rotation
			_tankRU04Body.transform.eulerAngles = _tankRU04BodyRotation;

			// _tankRU04Rotation.y is Input GetAxis _horizontalMoveInput times _tankRU04RotationSpeed
			_tankRU04BodyRotation.y += Input.GetAxis(_horizontalMoveInput) * _tankRU04RotationSpeed;

			// Take care of the tank turret steering
		
			// _tankRU04Turret.transform.eulerAngles is _tankRU04TurretRotation
			_tankRU04Turret.transform.eulerAngles = _tankRU04TurretRotation;

			// _tankRU04TurretRotation.y is Input GetAxis _mouseXInput times _turretRotationSpeed
			_tankRU04TurretRotation.y += Input.GetAxis(_mouseXInput) * _turretRotationSpeed;

			// Take care of the tank barrel elevation control
            
			// _barrelVert is Input GetAxis _mouseYInput
			float _barrelVert = Input.GetAxis(_mouseYInput);

			// _barrelElevation is Mathf Clamp _barrelElevation plus _barrelVert, _barrelMin, _barrelMax
			_barrelElevation = Mathf.Clamp(_barrelElevation+_barrelVert, _barrelMin, _barrelMax);

			// _tankRU04Barrel.localRotation is Quaternion Euler _barrelElevation, 0, 0
			_tankRU04Barrel.localRotation = Quaternion.Euler(_barrelElevation, 0, 0);
            
		} // close private void HandleSteering

	} // close public class TankRU04Controller

} // close namespace VehiclesControl
