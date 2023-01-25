using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace w_koper_DBAuta.Logika
{
    public class AutaManager
    {
        public AutaManager AddAuto(AutaModel autaModel)
        {
            using (var context = new AutaContext())
            {
                try
                {
                    context.Autas.Add(autaModel);
                    context.SaveChanges();
                }
                catch (System.Exception e)
                {

                    // throw e;
                    if (autaModel.Id !=0)
                    {
                        autaModel.Id = 0;
                        context.Autas.Add(autaModel);
                        context.SaveChanges();
                    }
                }
               
            }
            return this;
        }

        public AutaManager RemoveAuto(int id)
        {
            using (var context = new AutaContext())
            {
                var auto = context.Autas.Single(x => x.Id == id);
                context.Autas.Remove(auto);
                context.SaveChanges();
             }


            return this;
        }
        public AutaManager UpdateAuto(AutaModel autaModel)
        {
            using (var context = new AutaContext())
            {
                var auto = context.Autas.Update(autaModel);
                context.SaveChanges();
            }
            return this;
        }

        public AutaManager ChangeDostepnosc(int id, int newDostepnosc)
        {
            using (var context = new AutaContext())
            {
                
                var auto = context.Autas.Single(x => x.Id == id);
                //zabezpieczyć czy nowa dostępność jest 1 lub 0
                auto.Dostepnosc = newDostepnosc;
                this.UpdateAuto(auto);
                context.SaveChanges();
            }
            return this;
        }

        public AutaModel GetAuta(int id)
        {
            using (var context = new AutaContext())
            {
                var auto = context.Autas.Single(x => x.Id == id);
                return auto;
            }
        }

        public List<AutaModel> GetAutas()
        {
            using (var context = new AutaContext())
            {
                var auto = context.Autas.ToList();
                return auto;
            }
        }
    }
}
