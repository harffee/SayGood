namespace SayGood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class Detail
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? UpdateDate { get; set; }

       
        public string Descrip { get; set; }

        
        public string ToWho { get; set; }

       
      

       // public int Month { get; set; }
    }
}
