using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Test : Player_Base
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Status_Setting();
        }
    }
}
