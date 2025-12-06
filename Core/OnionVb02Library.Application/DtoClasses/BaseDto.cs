using OnionVb02Library.Application.DtoInterfaces;
using OnionVb02Library.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Application.DtoClasses
{
    public class BaseDto : IDto
    {
        public int Id { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        public DateTime? DeletedDate { get ; set ; }
        public DataStatus Status { get ; set ; }
    }
}
