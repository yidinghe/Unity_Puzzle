﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayoutPuzzleButtons : MonoBehaviour
{

	[SerializeField]
	private Transform puzzleLevel1, puzzleLevel2, puzzleLevel3, puzzleLevel4, puzzleLevel5;

	public List<Button> level1Buttons, level2Buttons, level3Buttons, level4Buttons, level5Buttons;

	public List<Animator> level1Anims, level2Anims, level3Anims, level4Anims, level5Anims;

	[SerializeField]
	private Sprite[] puzzleButtonsBacksideImages;

	private int puzzleLevel;

	private string selectedPuzzle;

	public void LayoutButtons (int level, string puzzle)
	{
		this.selectedPuzzle = puzzle;
		this.puzzleLevel = level;
		LayoutPuzzle ();
	}

	void LayoutPuzzle ()
	{
		switch (puzzleLevel) {
		case 0:
			foreach (Button btn in level1Buttons) {
				if (!btn.gameObject.activeInHierarchy) {
					btn.gameObject.SetActive (true);
					btn.gameObject.transform.SetParent (puzzleLevel1, false);

					if (selectedPuzzle == "Candy Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [0];
					} else if (selectedPuzzle == "Transport Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [1];
					} else if (selectedPuzzle == "Fruit Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [2];
					}
						
				}
			}
			break;
		case 1:
			foreach (Button btn in level2Buttons) {
				if (!btn.gameObject.activeInHierarchy) {
					btn.gameObject.SetActive (true);
					btn.gameObject.transform.SetParent (puzzleLevel2, false);
					if (selectedPuzzle == "Candy Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [0];
					} else if (selectedPuzzle == "Transport Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [1];
					} else if (selectedPuzzle == "Fruit Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [2];
					}
				}
			}
			break;
		case 2:
			foreach (Button btn in level3Buttons) {
				if (!btn.gameObject.activeInHierarchy) {
					btn.gameObject.SetActive (true);
					btn.gameObject.transform.SetParent (puzzleLevel3, false);
					if (selectedPuzzle == "Candy Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [0];
					} else if (selectedPuzzle == "Transport Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [1];
					} else if (selectedPuzzle == "Fruit Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [2];
					}
				}
			}
			break;
		case 3:
			foreach (Button btn in level4Buttons) {
				if (!btn.gameObject.activeInHierarchy) {
					btn.gameObject.SetActive (true);
					btn.gameObject.transform.SetParent (puzzleLevel4, false);
					if (selectedPuzzle == "Candy Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [0];
					} else if (selectedPuzzle == "Transport Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [1];
					} else if (selectedPuzzle == "Fruit Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [2];
					}
				}
			}
			break;
		case 4:
			foreach (Button btn in level5Buttons) {
				if (!btn.gameObject.activeInHierarchy) {
					btn.gameObject.SetActive (true);
					btn.gameObject.transform.SetParent (puzzleLevel5, false);
					if (selectedPuzzle == "Candy Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [0];
					} else if (selectedPuzzle == "Transport Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [1];
					} else if (selectedPuzzle == "Fruit Puzzle") {
						btn.image.sprite = puzzleButtonsBacksideImages [2];
					}
				}
			}
			break;
		}
	}

}