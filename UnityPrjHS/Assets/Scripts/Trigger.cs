using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile.SetActive(true); 
            //Check isTrigger in Inspector 
        }
    }
}
