using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameStateBehaviour : StateBehaviour
{
    public override void SetGameManager( GameManager p_gameManager )
    {
        m_gameManager = p_gameManager;
    }
}
