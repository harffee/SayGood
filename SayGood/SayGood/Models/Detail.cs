namespace SayGood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class Detail
    {

        public int UpdateId { get; set; }
        public string Name { get; set; }

        public DateTime? UpDate { get; set; }

       
        public string Desc { get; set; }

        
        public string ToWho { get; set; }

       
      

       // public int Month { get; set; }
    }
}
