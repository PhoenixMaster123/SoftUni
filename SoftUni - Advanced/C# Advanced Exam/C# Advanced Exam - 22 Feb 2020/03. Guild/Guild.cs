using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Guild(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            if(this.Capacity > 0 && !roster.Any(x => x.Name == player.Name))
            {
                this.roster.Add(player);
            }    
        }
        public bool RemovePlayer(string name)
        {
            if (this.roster.Any(x => x.Name == name)) 
            {               
                this.roster.RemoveAll(x => x.Name == name);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PromotePlayer(string name)
        {           
            if (roster.Any(x => x.Name == name))
            {
                Player promotedPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
                promotedPlayer.Rank = "Member";
            }

        }
        public void DemotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player demotedPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
                demotedPlayer.Rank = "Trial";
            }            
        }
        public Player[] KickPlayersByClass(string @class)
        {

            List<Player> kickPlayerList = new List<Player>();
            foreach (var player in this.roster)
            {
                if (player.Class == @class)
                {
                    kickPlayerList.Add(player);
                }
            }
            Player[] myArrayToReturn = kickPlayerList.ToArray();

            this.roster = this.roster.Where(x => x.Class != @class).ToList();

            return myArrayToReturn;

        }
        public int Count => this.roster.Count;
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach(var players in roster)
            {
                sb.AppendLine(players.ToString());
                //sb.AppendLine($"Player {players.Name}: {players.Class}");
                //sb.AppendLine($"Rank: {players.Rank}");
                //sb.AppendLine($"Description: {players.Description}");
            }
            return sb.ToString().TrimEnd();

        }


    }
}
