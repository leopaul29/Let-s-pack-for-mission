using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public Health Health;

    CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;

    public event System.Action GameEnded;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Health.CurrentHealth = Health.MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
        moveDirection *= speed;
        characterController.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "damage")
        {
            Debug.Log("damage");
            Health.DecreaseCurrentLife();
        }

        if(other.gameObject.tag == "pickup")
        {
            Debug.Log("pickup");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "exit")
        {
            Debug.Log("exit");
            GameEnded?.Invoke();
        }
    }
}
