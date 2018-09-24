using UnityEngine;
using System.Collections;

public class LaneCreep : MonoBehaviour {

	public GameObject[] destinations = new GameObject[5];

	private NavMeshAgent agent;

	private int index = 0;

	void Start()
	{
		agent = this.gameObject.GetComponent<NavMeshAgent> ();
	}
	
	void Update()
	{
		if (index  != destinations.Length)

		NextDestination ();
	}

	private void NextDestination()
	{
		agent.SetDestination (destinations [index].transform.position);

		if (agent.remainingDistance <= agent.stoppingDistance) 
			index++;
	}
}
