using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class boom : MonoBehaviour
{
    public GameObject bam;
    public Transform point;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1c");
        if (other.gameObject.tag == "Hand")
        {
            Debug.Log("2");

            Instantiate(bam, point.position, Quaternion.identity);
        }
    }
}
