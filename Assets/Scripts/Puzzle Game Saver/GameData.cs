using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class GameData
{
	private bool[] candyPuzzleLevels;
	private bool[] transportPuzzleLevels;
	private bool[] fruitPuzzleLevels;

	private bool[] candyPuzzleLevelStars;
	private bool[] transportPuzzleLevelStars;
	private bool[] fruitPuzzleLevelStars;

	private bool isGameStartedForTheFirstTime;

	private float musicVolume;

	public void SetIsGameStartedForTheFirstTime (bool isGameStartedForTheFirstTime)
	{
		this.isGameStartedForTheFirstTime = isGameStartedForTheFirstTime;
	}

	public bool GetIsGameStartedForTheFirstTime ()
	{
		return this.isGameStartedForTheFirstTime;
	}

	public void SetMusicVolume (float musicVolume)
	{
		this.musicVolume = musicVolume;
	}

	public float GetMusicVolume ()
	{
		return this.musicVolume;
	}

	public void SetCandyPuzzleLevels (bool[] candyPuzzleLevels)
	{
		this.candyPuzzleLevels = candyPuzzleLevels;
	}

	public bool[] GetCandyPuzzleLevels ()
	{
		return this.candyPuzzleLevels;
	}

	public void SetTransportPuzzleLevels (bool[] transportPuzzleLevels)
	{
		this.transportPuzzleLevels = transportPuzzleLevels;
	}

	public bool[] GetTransportPuzzleLevels ()
	{
		return this.transportPuzzleLevels;
	}

	public void SetFruitPuzzleLevels (bool[] fruitPuzzleLevels)
	{
		this.fruitPuzzleLevels = fruitPuzzleLevels;
	}

	public bool[] GetFruitPuzzleLevels ()
	{
		return this.fruitPuzzleLevels;
	}

	public void SetCandyPuzzleLevelStars (bool[] candyPuzzleLevelStars)
	{
		this.candyPuzzleLevelStars = candyPuzzleLevelStars;
	}

	public bool[] GetCandyPuzzleLevelStars ()
	{
		return this.candyPuzzleLevelStars;
	}

	public void SetTransportPuzzleLevelStars (bool[] transportPuzzleLevelStars)
	{
		this.transportPuzzleLevelStars = transportPuzzleLevelStars;
	}

	public bool[] GetTransportPuzzleLevelStars ()
	{
		return this.transportPuzzleLevelStars;
	}

	public void SetFruitPuzzleLevelStars (bool[] fruitPuzzleLevelStars)
	{
		this.fruitPuzzleLevelStars = fruitPuzzleLevelStars;
	}

	public bool[] GetFruitPuzzleLevelStars ()
	{
		return this.fruitPuzzleLevelStars;
	}

}
