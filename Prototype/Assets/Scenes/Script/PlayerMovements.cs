using System.Collections;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float MovementSpeed = 1;

    [SerializeField]
    GameObject player, objectToPossess;

    [SerializeField]
    Transform possess;


    Rigidbody2D GhostRB, ObjectRB;

    bool isPossessed;
    public static bool NearTheObject;
    private void Start()
    {
        GhostRB = GetComponent<Rigidbody2D>();
        ObjectRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * (Time.deltaTime * MovementSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * (Time.deltaTime * MovementSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * (Time.deltaTime * MovementSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * (Time.deltaTime * MovementSpeed);
        }

        if(NearTheObject)
        {
            Debug.Log("You can now possess this object");
        }
    }

    void FixedUpdate()
    {
        if (isPossessed)
            ObjectRB.velocity = new Vector2(ObjectRB.velocity.x, ObjectRB.velocity.y);
        else
            GhostRB.velocity = new Vector2(GhostRB.velocity.x, GhostRB.velocity.y);
    }

    public void EnterExitObject()
    {
            if (!isPossessed)
            {
                
            }

            if (isPossessed)
            {
                player.gameObject.SetActive(true);
                player.transform.position = new Vector2(possess.position.x, possess.position.y);
            }

            isPossessed = !isPossessed;
    }
}
