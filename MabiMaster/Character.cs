using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MabiMaster.Char
{
	public enum RaceEnum
	{
		Human,
		Elf,
		Giant
	};

	public class Character
	{
		public string Name { get; set; }
		public RaceEnum Race { get; set; }
	}

	public class Skill
	{
		private static readonly char[] ranks = "NFEDCBA987654321".ToCharArray();

		public string Name { get; set; }
		public int RankValue { get; set; }

		public string Rank { get { return ranks[RankValue].ToString(); } }
	}
}
