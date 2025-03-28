using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDirection;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {        
      rb.MovePosition(rb.position + moveDirection*(moveSpeed*Time.fixedDeltaTime));
    }

    public void MoveTo(Vector2 targetPosition){
        moveDirection = targetPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
