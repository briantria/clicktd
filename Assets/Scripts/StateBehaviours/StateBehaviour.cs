using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBehaviour : StateMachineBehaviour
{
	protected GameManager m_gameManager;
	public abstract void SetGameManager( GameManager p_gameManager );
}
