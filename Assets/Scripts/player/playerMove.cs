using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour

{
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward  * Time.deltaTime * moveSpeed , Space.World);
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)) 
            {
                if(this.gameObject.transform.position.x > LevelBoundry.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
                
            }
            if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)) 
            {
                if(this.gameObject.transform.position.x < LevelBoundry.rightSide)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
                }
            }
        }
    }
}
