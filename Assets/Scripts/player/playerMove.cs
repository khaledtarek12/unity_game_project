using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour

{
    public float moveSpeed = 10;
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject PlayerObject;
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
            if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)) 
            {
                if (isJumping == false)
                {
                    isJumping =true;
                    PlayerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequances());
                }
            }
        }
        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 4 , Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -4 , Space.World);
            }
        }
    }

    IEnumerator JumpSequances() 
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        PlayerObject.GetComponent<Animator>().Play("Standard Run");
    }
}
