using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class LumarcaAnimation : MonoBehaviour {

	public string fileName;

	public List<LumarcaFrame> frames = new List<LumarcaFrame>();

	int currentFrame = 0;

	public int CurrentFrame{
		get{

			int frameNum = currentFrame;

			currentFrame++;

			if(currentFrame >= frames.Count){
				currentFrame = 0;
			}

			return frameNum;
		}
	}

	public LumarcaFrame GetCurrentFrame(){
		return frames[CurrentFrame];
	}

	public void AddFrame(LumarcaFrame lf){
		frames.Add(lf);
	}

	public void LoadFromJSON(){
		TextAsset asset = Resources.Load(fileName) as TextAsset;

		JArray jFrames = JArray.Parse(asset.text);

		foreach(JArray jFrame in jFrames){
			LumarcaFrame lf = LumarcaFrame.LoadFromJSON(jFrame);
			frames.Add(lf);
		}
	}

	public void SaveToJSON(string file){

		JArray jArray = new JArray();


		foreach(LumarcaFrame frame in frames){
			JArray jsonFrame = frame.GetJSONLine();

			jArray.Add(jsonFrame);
		}

		string jStr = JsonConvert.SerializeObject(jArray, Formatting.Indented);

		string exportPath = Application.dataPath + "/" + file + "-anim.json";

		UtilScript.SaveStringToFile(exportPath, jStr);
	}
}
