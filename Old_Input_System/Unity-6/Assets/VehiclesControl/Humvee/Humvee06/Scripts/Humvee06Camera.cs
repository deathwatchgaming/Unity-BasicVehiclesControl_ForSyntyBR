/*
 * File: Humvee 06 Camera
 * Name: Humvee06Camera.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */
 
// using
using UnityEngine;

// namespace VehiclesControl
namespace VehiclesControl
{
	// public class Humvee06Camera
	public class Humvee06Camera : MonoBehaviour 
	{
		// Transforms
		[Header("Transforms")]

			[Tooltip("The humvee 06 transform")]
			// Transform _humvee06
			[SerializeField] private Transform _humvee06;
        
		// Amounts
		[Header("Amounts")]

			[Tooltip("The distance amount")]
			// float _distance is 6.4
			[SerializeField] private float _distance = 6.4f;

			[Tooltip("The height amount")]
			// float _height is 1.4
			[SerializeField] private float _height = 1.4f;

			[Tooltip("The rotation damping amount")]
			// float _rotationDamping is 3.0
			[SerializeField] private float _rotationDamping = 3.0f;

			[Tooltip("The height damping amount")]
			// float _heightDamping is 2.0
			[SerializeField] private float _heightDamping = 2.0f;

			[Tooltip("The zoom ratio amount")]
			// float _zoomRatio is 0.5
			[SerializeField] private float _zoomRatio = 0.5f;

			[Tooltip("The field of view amount")]
			// float _defaultFieldOfView is 60
			[SerializeField] private float _defaultFieldOfView = 60f;

		// Vector3 _rotationVector
		private Vector3 _rotationVector;
	    
		// private void LateUpdate
		private void LateUpdate()
		{
			// float _desiredAngle is _rotationVector.y
			float _desiredAngle = _rotationVector.y;

			// float _desiredHeight is _humvee06.position.y plus _height
			float _desiredHeight = _humvee06.position.y + _height;

			// float _transformedAngle is transform.eulerAngles.y
			float _transformedAngle = transform.eulerAngles.y;

			// float _transformedHeight is transform.position.y
			float _transformedHeight = transform.position.y;
	        
			// _transformedAngle is Mathf LerpAngle
			_transformedAngle = Mathf.LerpAngle(_transformedAngle, _desiredAngle, _rotationDamping * Time.deltaTime);
			
			// _transformedHeight is Mathf Lerp
			_transformedHeight = Mathf.Lerp(_transformedHeight, _desiredHeight, _heightDamping * Time.deltaTime);
	        
			// Quaternion _currentRotation is Quaternion Euler
			Quaternion _currentRotation = Quaternion.Euler(0, _transformedAngle, 0);

			// transform position is _humvee06.position
			transform.position = _humvee06.position;

			// transform position
			transform.position -= _currentRotation * Vector3.forward * _distance;

			// Vector3 _tempVector3 is transform.position
			Vector3 _tempVector3 = transform.position;
			
			// _tempVector3 y is _transformedHeight
			_tempVector3.y = _transformedHeight;
	        
			// transform position is _tempVector3
			transform.position = _tempVector3;

			// transform LookAt _humvee06
			transform.LookAt(_humvee06);

		} // close private void LateUpdate
	    
		// private void FixedUpdate
		private void FixedUpdate()
		{
			// Vector3 _localVelocity
			Vector3 _localVelocity = _humvee06.InverseTransformDirection(_humvee06.GetComponent<Rigidbody>().linearVelocity);
			
			// if
			if (_localVelocity.z < -0.1f)
			{
				// Vector3 _tempVector3 is _rotationVector
				Vector3 _tempVector3 = _rotationVector;
				
				// _tempVector3.y is _humvee06.eulerAngles.y plus 180
				_tempVector3.y = _humvee06.eulerAngles.y + 180;

				// _rotationVector is _tempVector3
				_rotationVector = _tempVector3;

			} //close if
	        
			// else
			else
			{
				// Vector3 _tempVector3 is _rotationVector
				Vector3 _tempVector3 = _rotationVector;

				// _tempVector3 y is _humvee06.eulerAngles.y
				_tempVector3.y = _humvee06.eulerAngles.y;

				// _rotationVector is _tempVector3
				_rotationVector = _tempVector3;

			} // close else
	        
			// float autoCamControl
			float _autoCamControl = _humvee06.GetComponent<Rigidbody>().linearVelocity.magnitude;

			// GetComponent Camera fieldOfView
			GetComponent<Camera>().fieldOfView = _defaultFieldOfView + _autoCamControl * _zoomRatio * Time.deltaTime;
		
		} // close private void FixedUpdate

	} // close public class Humvee06Camera

} // close namespace VehiclesControl
