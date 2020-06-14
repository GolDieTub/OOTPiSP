using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1
{
	[Serializable]
	public  class MenuItem
	{
		public enum TCategorys { ComplexDishes, Desserts, Meat, Salads, Snacks, Soups };
		public TCategorys Category;
		public string Name;
		public int Count;
		public double Calorie_content;
		public double Price;

		public MenuItem(string name, int count, double calorie_content, double price)
		{
			this.Name = name;
			this.Count = count;
			this.Price = price;
			this.Calorie_content = calorie_content;
		}

	}

	[Serializable]
	public class ColdDishes : MenuItem
	{
		public enum TServing_size { small, medium, large };
		public TServing_size Serving_size;
		public ColdDishes(TServing_size serving_size, string name, int count, double price, double calorie_content) : base(name, count, price, calorie_content)
		{
			this.Serving_size = serving_size;
		}

	}

	[Serializable]
	public class HotDishes : MenuItem
	{
		public enum TServing_size { small, medium, large };
		public TServing_size Serving_size;
		public HotDishes(TServing_size serving_size, string name, int count, double price, double calorie_content) : base(name, count, price, calorie_content)
		{
			this.Serving_size = serving_size;
		}
	}

	[Serializable]
	public class Desserts : MenuItem
	{
		public enum TDesserts { Аruit_and_berry_mix, Ice_cream, Сake, Pie };
		public TDesserts MyDesserts;

		public Desserts(TDesserts desserts, string name, int count, double price, double calorie_content) : base(name, count, price, calorie_content)
		{
			this.MyDesserts = desserts;
			this.Category = TCategorys.Desserts;
		}
	}

	[Serializable]
	public class Soups : HotDishes
	{
		public bool WithMeat;
		public bool ColdSoup;
		public enum TliquidType { Kvas, Pivo, Moloko, Rassol, Vino };
		public TliquidType LiquidType;
		public Soups(bool withMeat, bool coldSoup, TliquidType liquidType, TServing_size serving_size, string name, int count, double price, double calorie_content) : base(serving_size, name, count, price, calorie_content)
		{
			this.WithMeat = withMeat;
			this.ColdSoup = coldSoup;
			this.LiquidType = liquidType;
			this.Serving_size = serving_size;
			this.Category = TCategorys.Soups;
		}
	}

	[Serializable]
	public class Meat : HotDishes
	{
		public enum TMeatType { chicken, beef, pork, fish };
		public TMeatType MeatType;
		public Meat(TMeatType meatType, TServing_size serving_size, string name, int count, double price, double calorie_content) : base(serving_size, name, count, price, calorie_content)
		{
			this.MeatType = meatType;
			this.Serving_size = serving_size;
			this.Category = TCategorys.Meat;
		}
	}

	[Serializable]
	public class ComplexDishes : HotDishes
	{

		public Meat Meat;
		public Soups Soups;

		public ComplexDishes(Meat meat, Soups soups, TServing_size serving_size, string name, int count, double price, double calorie_content) : base(serving_size, name, count, price, calorie_content)
		{
			this.Meat = meat;
			this.Soups = soups;
			this.Category = TCategorys.ComplexDishes;
		}
	}

	[Serializable]
	public class Salads : ColdDishes
	{
		public enum TEddition { None, Sour_cream, Oil };
		public TEddition Eddition;
		public bool FruitSalad;
		public bool VegetableSalad;
		public Salads(TEddition eddition, bool fruitSalad, bool vegetableSalad, TServing_size serving_size, string name, int count, double price, double calorie_content) : base(serving_size, name, count, price, calorie_content)
		{
			this.Eddition = eddition;
			this.FruitSalad = fruitSalad;
			this.VegetableSalad = vegetableSalad;
			this.Category = TCategorys.Salads;
		}
	}


	[Serializable]
	public class Snacks : ColdDishes
	{
		public enum TFromWhat { Fish, Meat, Vegan };
		public TFromWhat FromWhat;

		public Snacks(TFromWhat fromWhat, TServing_size serving_size, string name, int count, double price, double calorie_content) : base(serving_size, name, count, price, calorie_content)
		{
			this.FromWhat = fromWhat;
			this.Category = TCategorys.Snacks;
		}
	}
}


