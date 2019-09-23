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
        Data.Database.PlanesAdapter _planData;

        public Data.Database.PlanesAdapter PlanData
        {
            get { return _planData; }
            set { _planData = value; }
        }

        public List<Plan> GetAll()
        {
            PlanesAdapter usuario = new PlanAdapter();
            return plan.GetAll();
        }

        public Planes GetOne(int Id)
        {
            PlanesAdapter usuario = new PlanesAdapter();
            return plan.GetOne(Id);
        }

        public void Delete(int Id)
        {
            PlanesAdapter plan = new PlanesAdapter();
            plan.Delete(Id);
        }

        public void Save(Plan plan)
        {
            PlanAdapter pla = new PlanAdapter();
            pla.Save(plan);
        }
    }
}
