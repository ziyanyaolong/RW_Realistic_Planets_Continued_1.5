﻿using RimWorld.Planet;
using Verse;

namespace Planets_Code
{
	public class BiomeWorker_TeSwUrban : BiomeWorker_RRP_TemperateSwamp
		{
			public BiomeWorker_TeSwUrban() { }
			public override float GetScore(Tile tile, int tileID)
			{
				float single;
				float single1 = 0.002f;
				float score = base.GetScore(tile, tileID);
				single = ((score <= 0f ? false : Rand.Value <= single1) ? score + 0.1f : score - 1f);
				return single;
			}
		}
	
}
