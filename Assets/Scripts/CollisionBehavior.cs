using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour
{
    BoxCollider thisCollider;
    float scalingRate = 1.5f;
    public GameObject playerGraphic;

    // Start is called before the first frame update
    void Start()
    {
        thisCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.ToLower() == "bots")
        {
            BoxCollider theOpponentCollider = collision.gameObject.GetComponent<BoxCollider>();

            float opponentSize = theOpponentCollider.size.x*theOpponentCollider.size.y*theOpponentCollider.size.z*collision.gameObject.GetComponent<Transform>().localScale.x;
            float currentSize = thisCollider.size.x * thisCollider.size.y * thisCollider.size.z* transform.localScale.x;
            if (currentSize >= opponentSize)
            {
                transform.localScale *= scalingRate;
                collision.gameObject.SetActive(false);
            }
            else
            {
                playerGraphic.SetActive(false);
            }
        }
    }
}
