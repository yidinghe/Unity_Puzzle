﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupPuzzleGame : MonoBehaviour
{
	[SerializeField]
	private PuzzleGameManager puzzleGameManager;

	private Sprite[] candyPuzzleSprites, transportPuzzleSprites, fruitPuzzleSprites;

	[SerializeField]
	private List<Sprite> gamePuzzles = new List<Sprite> ();

	private List<Button> puzzleButtons = new List<Button> ();

	private List<Animator> puzzleButtonsAnimators = new List<Animator> ();

	private int level;

	private string selectedPuzzle;

	private int looper;

	void Awake ()
	{
		candyPuzzleSprites = Resources.LoadAll<Sprite> ("Sprites/Game Assets/Candy");
		transportPuzzleSprites = Resources.LoadAll<Sprite> ("Sprites/Game Assets/Transport");
		fruitPuzzleSprites = Resources.LoadAll<Sprite> ("Sprites/Game Assets/Fruits");
	}

	void PrepareGameSprites ()
	{
		gamePuzzles.Clear ();
		gamePuzzles = new List<Sprite> ();

		int index = 0;

		switch (level) {
		case 0:
			looper = 6;
			break;
		case 1:
			looper = 12;
			break;
		case 2:
			looper = 18;
			break;
		case 3:
			looper = 24;
			break;
		case 4:
			looper = 30;
			break;
		}

		for (int i = 0; i < looper; i++) {
			if (index == (looper / 2)) {
				index = 0;
			}
			if (selectedPuzzle == "Candy Puzzle") {
				gamePuzzles.Add (candyPuzzleSprites [index]);
			} else if (selectedPuzzle == "Transport Puzzle") {
				gamePuzzles.Add (transportPuzzleSprites [index]);
			} else if (selectedPuzzle == "Fruit Puzzle") {
				gamePuzzles.Add (fruitPuzzleSprites [index]);
			}
			index++;
		}
		Shuffle (gamePuzzles);
	}

	void Shuffle (List<Sprite> list)
	{
		for (int i = 0; i < list.Count; i++) {
			Sprite temp = list [i];
			int randomIndex = Random.Range (i, list.Count);
			list [i] = list [randomIndex];
			list [randomIndex] = temp;
		}
	}

	public void SetLevelAndPuzzle (int level, string selectedPuzzle)
	{
		this.level = level;
		this.selectedPuzzle = selectedPuzzle;
		PrepareGameSprites ();
		puzzleGameManager.SetGamePuzzleSprites (gamePuzzles);
	}

	public void SetPuzzleButtonsAndAnimators (List<Button> puzzleButtons, List<Animator> puzzleButtonsAnimators)
	{
		this.puzzleButtons = puzzleButtons;
		this.puzzleButtonsAnimators = puzzleButtonsAnimators;

		puzzleGameManager.SetUpButtonsAndAnimators (puzzleButtons, puzzleButtonsAnimators);
	}

}
