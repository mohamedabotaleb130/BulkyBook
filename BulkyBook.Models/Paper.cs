using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
	public class Paper
	{
		public int TotalItems { get; set; }
		public int CurrentPage { get; set; }
		public int PageSize{ get; set; }
		public int TotalPages{ get; set; }
		public int StartPage{ get; set; }
		public int EndPage{ get; set; }
		public Paper()
		{

		}
		public Paper(int totalItems,int page,int pageSize=10)
		{
			int totalPages = (int )Math.Ceiling((decimal)totalItems/(decimal)pageSize);
			int currentpage=page;

			int startpage = currentpage - 5;
			int endpage = currentpage + 4;
			if (startpage<=0)
			{
				endpage = endpage - (startpage - 1);
				startpage = 1;
			}
			if (endpage>totalPages)
			{
				endpage = totalPages;
				if (endpage>10)
				{
					startpage = endpage - 9;
				}

			}
			TotalItems = totalItems;
			CurrentPage = startpage;
			PageSize = pageSize;
			TotalPages=totalPages;
			StartPage=startpage;
			EndPage=endpage;



		}
	}
}
