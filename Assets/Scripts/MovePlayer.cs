using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    CharacterController agente;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 move = new Vector3();
        move.x = moveHorizontal;
        move.z += moveVertical;
        agente.Move(move);
    }
}
