﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{
	[SerializeField]
	private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

	[SerializeField]
	private Animator selectPuzzleMenuAnim, puzzleLevelSelectAnim;

	private string selectedPuzzle;

	public void BackToPuzzleSelectMenu ()
	{
		StartCoroutine (ShowPuzzleSelectMenu ());
	}


	IEnumerator ShowPuzzleSelectMenu ()
	{
		selectPuzzleMenuPanel.SetActive (true);
		puzzleLevelSelectAnim.Play ("SlideOut");
		selectPuzzleMenuAnim.Play ("SlideIn");
		yield return new WaitForSeconds (1f);
		puzzleLevelSelectPanel.SetActive (false);
	}

}