using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEP.Forms
{
    [Table("AppForm")]
    public class Form : Entity
    {
        public string Json { get; set; }
    }
}
