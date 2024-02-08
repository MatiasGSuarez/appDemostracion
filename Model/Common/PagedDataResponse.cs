using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class PagedDataResponse<T> where T : class
    {
        public PagedDataResponse()
        { }

        public PagedDataResponse(IList<T> result, int rowCount, int pageNumber, int pageSize)
        {
            this.PageSize = pageSize == 0 ? rowCount : pageSize;
            this.PageNumber = pageNumber;
            this.PageCount = pageSize > 0 ? Convert.ToInt32(Math.Ceiling((decimal)rowCount / (decimal)pageSize)) : 1;
            this.RowCount = rowCount;
            this.Results = result;
        }

        public int PageNumber { get; set; }

        public int PageCount { get; set; }

        public int PageSize { get; set; }

        public int RowCount { get; set; }

        public IList<T> Results { get; set; }
    }
}