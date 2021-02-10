using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Animator playerAnim;
    [SerializeField] private float walkSpeed;
    [SerializeField] private Transform hand;
    [SerializeField] private Transform fishingpole;
    [SerializeField] private GameObject pole;
    [SerializeField] private Transform line;

    private float facing = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = (Input.GetAxisRaw("Horizontal"));

        facing = input;

        if (facing < 0)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 90f, 0f), Time.deltaTime * 4f);
        }
        else if (facing > 0)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 270f, 0f), Time.deltaTime * 4f);
        }

        transform.position += new Vector3(input * walkSpeed * Time.deltaTime, 0f);

        playerAnim.SetFloat("MoveSpeed", Mathf.Abs(input));

        if(Input.GetMouseButtonDown(0))
        {
            pole.SetActive(true);
            fishingpole.SetParent(hand);
        }

        Vector3 v3 = line.transform.localScale;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //line.transform.localScale = new Vector3(v3.x, v3.y, v3.z + 2f);
            playerAnim.SetTrigger("go");
        }


    }


}
