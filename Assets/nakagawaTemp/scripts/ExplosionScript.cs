using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour {
	//  destroy ownself when this function is called  
	public void DeleteExplosion ()
	{
		System.Console.WriteLine ("deleteExplosion.");
		Destroy(gameObject);
	}
}