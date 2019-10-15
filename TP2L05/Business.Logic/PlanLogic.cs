using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        Data.Database.PlanAdapter _planData;

        public Data.Database.PlanAdapter PlanData
        {
            get { return _planData; }
            set { _planData = value; }
        }

        public List<Plan> GetAll()
        {
            PlanAdapter plan = new PlanAdapter();
            return plan.GetAll();
        }

        public Plan GetOne(int Id)
        {
            PlanAdapter plan = new PlanAdapter();
            return plan.GetOne(Id);
        }

        public void Delete(int Id)
        {
            PlanAdapter plan = new PlanAdapter();
            plan.Delete(Id);
        }

        public void Save(Plan plan)
        {
            PlanAdapter pla = new PlanAdapter();
            pla.Save(plan);
        }
    }
}
