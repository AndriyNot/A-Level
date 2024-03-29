using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.DTOs
{
    public class PageDto
    {
        public int PageSize { get; set; }
        public FilterDto Filter { get; set; }

        public PageDto() 
        {
            PageSize = 20;
            Filter = new FilterDto();
        }
    }
}
