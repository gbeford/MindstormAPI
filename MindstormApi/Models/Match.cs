﻿namespace MindstormApi.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        public int MatchDefinitionId { get; set; }
        public MatchDefinition MatchDefinition { get; set; }
        public int MatchNumber { get; set; }
        public int TableNumber { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int Score { get; set; }
       
        

       

        
        public string ChildSignature { get; set; }

        //public List<Post> Posts { get; set; }

    }
}