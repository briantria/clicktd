using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Bootloader : MonoBehaviour
{
	private GameManager m_gameManager;
	private Animator m_statemachineAnimator;

	private void Awake()
	{
		m_statemachineAnimator = this.GetComponent<Animator>();
		Assert.IsNotNull(m_statemachineAnimator);

		m_gameManager = new GameManager(m_statemachineAnimator);//GameManager.Instance;
		Assert.IsNotNull(m_gameManager);
	}

	private void Start()
	{
		StateBehaviour[] stateBehaviours = m_statemachineAnimator.GetBehaviours<StateBehaviour>();
		for(int idx = stateBehaviours.Length-1; idx >= 0; --idx)
		{
			stateBehaviours[idx].SetGameManager( m_gameManager );
		}
	}
}
