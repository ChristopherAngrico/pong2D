using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionScript : MonoBehaviour
{
    public BallMovement ball;
    public GameObject instruction;
    public void PressAnyWhere(){
        ball.GetComponent<BallMovement>().EnableScript();
        instruction.SetActive(false);
    }
}
