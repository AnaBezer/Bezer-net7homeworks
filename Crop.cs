using System;

public class Crop
{
	public Crop(string name)
	{
		this.name = name;
	}
	string name;
	string currentStage = "Seed";

	public void Water()
	{
		//if (this.currentStage == "Seed")
		//{
		//	this.currentStage = "Sprout";
		//}
		//else if (this.currentStage == "Sprout")
		//{
		//	this.currentStage = "Plant";
		//}
		//else
		//{
		//	this.currentStage = "CanBeHarvested";
		//}

		switch (this.currentStage)
		{
			case "Seed":
                this.currentStage = "Sprout";
				break;
			case "Sprout":
				this.currentStage = "Plant";
				break;
			case "Plant":
				this.currentStage = "CanBeHarvested";
				break;
			default:
				break;
        }
	}

	public void Harvest()
	{
		if (this.currentStage == "CanBeHarvested")
		{
            this.currentStage = "Harvested";
        }	
	}

	public string TellTheCurrentStage()
	{
		return $"The current stage is : {this.currentStage}.";

    }


}
