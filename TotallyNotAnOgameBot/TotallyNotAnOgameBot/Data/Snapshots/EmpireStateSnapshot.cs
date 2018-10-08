using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.EmpireStateData;


namespace TotallyNotAnOgameBot.Data.Snapshots
{
    public class EmpireStateSnapshot
    {
		public readonly EmpireState empireState;
		public readonly DateTime date;
		
		public EmpireStateSnapshot(EmpireState empireState, DateTime date)
		{
           this.empireState = empireState;
           this.date = date;
        }
	}
}