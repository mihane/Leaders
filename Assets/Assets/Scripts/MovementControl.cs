using UnityEngine;
using System.Collections;

public class MovementControl : MonoBehaviour {
	public WheelCollider[] wheelColliders;// = new WheelCollider[4];
	public Transform[] tyreMeshes = new Transform[4];
	public float maxTorque = 50.0f;
	private Rigidbody m_rigidbody;
	public Transform centerOfMass;
	public float timer = 0.0f;
	private int i;

	void start()
	{
		m_rigidbody = GetComponent<Rigidbody>();
		m_rigidbody.centerOfMass = centerOfMass.localPosition;
	}

	void Update()
	{
		timer += Time.deltaTime;
	}

	void FixedUpdate()
	{// 0 is front left and 1 is front right
		float steer = Input.GetAxis ("Horizontal");
		float fixedAngel = steer * 45f;
		wheelColliders [0].steerAngle = fixedAngel;
		wheelColliders [1].steerAngle = fixedAngel;

		float acceleration = Input.GetAxis ("Vertical");
		for (i = 0; i < 4; i++)
		if (timer >= 30.0f)
			wheelColliders [i].motorTorque = 1 * maxTorque;
		if (timer >= 60.0f)
			wheelColliders [i].motorTorque = 0 * maxTorque;
	}

	void UpdateMeshesPositions()
	{
		for(int i = 0; i < 4 ; i++)
		{
			Quaternion quat;
			Vector3 pos;
			wheelColliders[i].GetWorldPose(out pos, out quat);
			tyreMeshes[i].position = pos;
			tyreMeshes[i].rotation = quat;
		}
	}
}
