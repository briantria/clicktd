﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStateBehaviour : StateBehaviour
{
    public override void SetGameManager( GameManager p_gameManager )
    {
        m_gameManager = p_gameManager;
    }

    override void OnStateEnter( Animator p_animator, AnimatorStateInfo p_stateInfo, int p_layerIndex )
    {
        
    }
}
