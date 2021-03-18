using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ThrowBall : MonoBehaviour
{
	private Vector3 startPosition;
	private Vector3 direction;
	private float startTime;
	private float endTime;
	private float duration;
	private bool directionChosen = false;

	public Vector3 directionFinal;

	Rigidbody rb;

	[SerializeField] GameObject ARCam;

	public float puissanceHorizontal;
	public float puissanceVertical;
	private void Start()
    {
		rb = GetComponent<Rigidbody>();
		ARCam = GameObject.FindGameObjectWithTag("MainCamera");
	}
    public void Update()
    {
		directionFinal = ARCam.transform.forward.normalized * puissanceHorizontal + new Vector3(0, 1, 0) * puissanceVertical;

		if (Input.GetMouseButtonDown(0))
		{
			startPosition = Input.mousePosition;
			startTime = Time.time;
			directionChosen = false;
		}
		
		else if (Input.GetMouseButtonUp(0))
		{
			endTime = Time.time;
			duration = endTime - startTime;
			direction = Input.mousePosition - startPosition;
			directionChosen = true;
			//directionFinal *= duration;
			duration = 0.0f;
		}

		if (directionChosen)
		{
			rb.mass = 1f;
			rb.useGravity = true;

			//rb.AddForce(0, (direction.y / 1)/duration, 20 * 2);
			rb.AddForce(directionFinal);

			startTime = 0.0f;

			startPosition = new Vector3(0, 0, 0);
			direction = new Vector3(0, 0, 0);
			directionChosen = false;
		}
	}
}
