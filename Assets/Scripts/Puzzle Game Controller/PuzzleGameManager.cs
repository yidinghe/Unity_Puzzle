using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleGameManager : MonoBehaviour
{

	private List<Button> puzzleButtons = new List<Button> ();

	private List<Animator> puzzleButtonsAnimators = new List<Animator> ();

	[SerializeField]
	private List<Sprite> gamePuzzleSprites = new List<Sprite> ();

	private int level;

	private string selectedPuzzle;

	private Sprite puzzleBackgroundImage;

	private bool firstGuess, secondGuess;
	private int firstGuessIndex, secondGuessIndex;
	private string firstGuessPuzzle, secondGuessPuzzle;

	private int countTryGuess;

	private int countCorrectGuess;
	private int gameGuess;

	[SerializeField]
	private GameFinished gameFinished;


	public void PickAPuzzle ()
	{
		if (!firstGuess) {
			firstGuess = true;
			firstGuessIndex = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			firstGuessPuzzle = gamePuzzleSprites [firstGuessIndex].name;
			StartCoroutine (TurnPuzzleButtonUp (puzzleButtonsAnimators [firstGuessIndex], puzzleButtons [firstGuessIndex], gamePuzzleSprites [firstGuessIndex]));
		} else if (!secondGuess) {
			secondGuess = true;
			secondGuessIndex = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			secondGuessPuzzle = gamePuzzleSprites [secondGuessIndex].name;
			StartCoroutine (TurnPuzzleButtonUp (puzzleButtonsAnimators [secondGuessIndex], puzzleButtons [secondGuessIndex], gamePuzzleSprites [secondGuessIndex]));
			StartCoroutine (CheckPuzzleMatch (puzzleBackgroundImage));
			countTryGuess++;
		}
	}

	IEnumerator CheckPuzzleMatch (Sprite puzzleBackgroundImage)
	{
		yield return new WaitForSeconds (1.7f);

		if (firstGuessPuzzle == secondGuessPuzzle) {
			puzzleButtonsAnimators [firstGuessIndex].Play ("FadeOut");
			puzzleButtonsAnimators [secondGuessIndex].Play ("FadeOut");
			CheckIfTheGameIsFinished ();
		} else {
			StartCoroutine (TurnPuzzleButtonBack (puzzleButtonsAnimators [firstGuessIndex], puzzleButtons [firstGuessIndex], puzzleBackgroundImage));
			StartCoroutine (TurnPuzzleButtonBack (puzzleButtonsAnimators [secondGuessIndex], puzzleButtons [secondGuessIndex], puzzleBackgroundImage));
		}

		yield return new WaitForSeconds (.7f);

		firstGuess = secondGuess = false;
	}

	void CheckIfTheGameIsFinished ()
	{
		countCorrectGuess++;
		if (countCorrectGuess == gameGuess) {
			CheckHowManyGuesses ();
		}
	}

	void CheckHowManyGuesses ()
	{
		int howManGuesses = 0;
		switch (level) {
		case 0:
			howManGuesses = 5;
			break;
		case 1:
			howManGuesses = 10;
			break;
		case 2:
			howManGuesses = 15;
			break;
		case 3:
			howManGuesses = 20;
			break;
		case 4:
			howManGuesses = 25;
			break;
		}

		if (countTryGuess < howManGuesses) {
			gameFinished.ShowGameFinishedPanel (3);		
		} else if (countTryGuess < (howManGuesses + 5)) {
			gameFinished.ShowGameFinishedPanel (2);
		} else {
			gameFinished.ShowGameFinishedPanel (1);
		}
	}

	public List<Animator> ResetGameplay() {
		gameFinished.HideGameFinishedPanel ();
		firstGuess = secondGuess = false;
		countTryGuess = 0;
		countCorrectGuess = 0;

		return puzzleButtonsAnimators;
	}

	IEnumerator TurnPuzzleButtonUp (Animator anim, Button btn, Sprite puzzleImage)
	{
		anim.Play ("TurnUp");
		yield return new WaitForSeconds (.4f);
		btn.image.sprite = puzzleImage;
	}

	IEnumerator TurnPuzzleButtonBack (Animator anim, Button btn, Sprite puzzleImage)
	{
		anim.Play ("TurnBack");
		yield return new WaitForSeconds (.4f);
		btn.image.sprite = puzzleImage;
	}

	void AddListeners ()
	{
		foreach (Button btn in puzzleButtons) {
			btn.onClick.RemoveAllListeners ();
			btn.onClick.AddListener (() => PickAPuzzle ());
		}
	}

	public void SetUpButtonsAndAnimators (List<Button> buttons, List<Animator> animators)
	{
		this.puzzleButtons = buttons;
		this.puzzleButtonsAnimators = animators;

		gameGuess = puzzleButtons.Count / 2;
		puzzleBackgroundImage = puzzleButtons [0].image.sprite;

		AddListeners ();
	}

	public void SetGamePuzzleSprites (List<Sprite> gamePuzzleSprites)
	{
		this.gamePuzzleSprites = gamePuzzleSprites;
	}

	public void SetLevel (int level)
	{
		this.level = level;
	}

	public void SetSelectedPuzzle (string selectedPuzzle)
	{
		this.selectedPuzzle = selectedPuzzle;
	}
}
