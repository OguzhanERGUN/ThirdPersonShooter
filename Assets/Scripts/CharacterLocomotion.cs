using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLocomotion : MonoBehaviour
{
    private Animator charAnimator;
    private Vector2 input;
    // Start is called before the first frame update
    void Start()
    {
        charAnimator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        charAnimator.SetFloat("InputX", input.x);
        charAnimator.SetFloat("InputY", input.y);
    }
}
