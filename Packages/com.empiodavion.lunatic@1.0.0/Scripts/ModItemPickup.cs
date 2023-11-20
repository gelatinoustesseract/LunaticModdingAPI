// items in the scene that a player can pick up, this is not the actual item,
// it is just a object that gives you an item when you touch it
public class ModItemPickup : Item_Pickup_scr, IModObject
{
	// the type variable sets the type of item
	// 0 weapon, 1 spell, 2 gold, 3 item, 4 material
	// Alt_Name is a number which indicates its index in the Resources/txt/eng/MATERIALS.txt file,
	// it is only used for alchemy materials

	public Mod Mod { get; set; }
	public UnityEngine.AssetBundle Bundle { get; set; }
	public string AssetName { get; set; }

	public bool Internal_CheckStart()
	{
		if (type == (int)Lunatic.ItemTypes.Material)
		{
			Alt_Name = Name;

			return false;
		}

		return true;
	}


	public virtual void OnPickup()
	{
		
	}
}
