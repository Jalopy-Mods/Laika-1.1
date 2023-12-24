using JaLoader;
using UnityEngine;

namespace Laika11
{
    public class Laika11 : Mod
    {
        public override string ModID => "Laika11";
		public override string ModName => "Laika 1.1";
		public override string ModAuthor => "MeblIkea";
        public override string ModDescription => "Modify the existing Laika, and turn it into a Laika 1.1!";
        public override string ModVersion => "1.0.0";
        public override bool UseAssets => true;
        // public override string GitHubLink => "https://github.com/Jalopy-Mods/";
		public override WhenToInit WhenToInit => WhenToInit.InMenu; // OR WhenToInit.InMenu (In menu is both)

        public override void Start()
        {
	        // Load the grill
	        var originalGrill = GameObject.Find("FrameHolder").transform.GetChild(9).GetChild(0).GetChild(78);
	        originalGrill.GetComponent<MeshFilter>().mesh = null;
	        var grill = Instantiate(LoadAsset<GameObject>("trabby1.1", "grill", "", ""), originalGrill.transform,
		        false);
	        grill.transform.localScale = new Vector3(100, 100, -100);
	        grill.transform.localPosition = new Vector3(7.7f, -2.9f, 0.35f);

	        // Load rear lights
	        var originalLights = GameObject.Find("FrameHolder").transform.GetChild(9).GetChild(0).GetChild(13);
	        originalLights.GetComponent<MeshFilter>().mesh = null;
	        originalLights.GetChild(0).gameObject.SetActive(false);
	        originalLights.GetChild(1).gameObject.SetActive(false);

	        var originalLights2 = GameObject.Find("FrameHolder").transform.GetChild(9).GetChild(0).GetChild(8);
	        originalLights2.GetComponent<MeshFilter>().mesh = null;
	        originalLights2.GetChild(0).gameObject.SetActive(false);
	        originalLights2.GetChild(1).gameObject.SetActive(false);
	        Instantiate(LoadAsset<GameObject>("trabby1.1", "rLight", "", ""), originalLights.transform,
		        false).transform.localScale = new Vector3(1.2f, 0.7f, 2);
	        Instantiate(LoadAsset<GameObject>("trabby1.1", "rLight", "", ""), originalLights2.transform,
		        false).transform.localScale = new Vector3(-1.2f, 0.7f, 2);

	        var vehicleMaterials = GameObject.Find("TweenHolder").transform.GetChild(0).GetComponent<MeshRenderer>().materials;
	        grill.GetComponent<MeshRenderer>().materials = vehicleMaterials;
        }
    }
}