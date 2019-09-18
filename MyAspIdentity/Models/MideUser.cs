using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspIdentity.Models
{
    public enum Cities
    {
        None, London, Paris, Chicago
    }
    public enum QualificationLevels
    {
        None, Basic, Advanced
    }
    public class MideUser : IdentityUser
    {
        public Cities City { get; set; }
        public QualificationLevels Qualification { get; set; }

    }
}
