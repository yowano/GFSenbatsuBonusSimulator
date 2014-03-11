using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GFBonusSimulator
{
    public class Girl
    {
        private readonly string name;
        public readonly Bonus.eAtk[] atkBonus;
        public readonly Bonus.eDef[] defBonus;

        public string Name
        {
            get { return this.name; }
        }


		public Girl()
			: this( "----------", new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE, }, new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE, } )
		{
			
		}

        public Girl( string name, Bonus.eAtk[] atkBonus, Bonus.eDef[] defBonus )
        {
            this.name = name;
            this.atkBonus = atkBonus;
            this.defBonus = defBonus;
        }
    }
}
