using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        List<Renovator> Renovators;
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.Renovators = new List<Renovator>();
        }
        public int Count => Renovators.Count;
        public string AddRenovator(Renovator renovator)
        {
            if(string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator's information.";
            }
            if(this.Renovators.Count >= this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if(renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            this.Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public bool RemoveRenovator(string name)
        {      
            if(this.Renovators.Any(x=>x.Name == name))
            {
               this.Renovators.RemoveAll(x => x.Name == name);
                return true;
            }
            else
            {
                return false;
            }          
            
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            if (this.Renovators.Any(x => x.Type == type))
            {
                int remove = this.Renovators.RemoveAll(x => x.Type == type);
                if(remove > 0)
                {
                    return remove;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
            // int remove = this.Renovators.RemoveAll(x => x.Type == type);
            //if(remove > 0)
            //{
            //    return remove;
            //}
            //else
            //{
            //    return 0;
            //}
        }
        public Renovator HireRenovator(string name)
        {
            Renovator renovator = this.Renovators.FirstOrDefault(x => x.Name == name);
            if(this.Renovators.Contains(renovator))
            {
                return renovator;
            }
            else
            {
               return null;
            }
            //if(renovator != null)
            //{
            //    return renovator;
            //}
            //else
            //{
            //    return null;
            //}
        }
        public List<Renovator> PayRenovators(int days)
        {

            List<Renovator> payday = this.Renovators.Where(d => d.Days >= 8).ToList();
            foreach (var renovator in payday)
            {
                Console.WriteLine(renovator);
            }
            return payday;
          
        }
        public string Report()
        {
            var renovatorsAvailable = this.Renovators.Where(renov => renov.Hired == false);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");

            foreach (var item in renovatorsAvailable)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();




        }

    }
}
