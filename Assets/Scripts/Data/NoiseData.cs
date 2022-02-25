using UnityEngine;
using System.Collections;
using UnityEditor;

[CreateAssetMenu()]
public class NoiseData : UpdatableData {

	public Noise.NormalizeMode normalizeMode;

	public float noiseScale;

	public int octaves;
	[Range(0,1)]
	public float persistance;
	public float lacunarity;

	public int seed;

	public Vector2 offset;

	public int worldscene;


	#if UNITY_EDITOR

	protected override void OnValidate() {
		if (lacunarity < 1) {
			lacunarity = 1;
		}
		if (octaves < 0) {
			octaves = 0;
		}


		base.OnValidate ();
	}
	#endif

}
