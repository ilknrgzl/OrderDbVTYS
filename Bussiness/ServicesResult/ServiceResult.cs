using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.ServicesResult
{
	public class ServiceResult<T>
	{
		public T? Result { get; set; } // Obje verisi
		public List<T>? Results { get; set; } // Liste Verisi
		public ResponseStatus ResponseStatus { get; set; }  // Varsayılan Mesaj
		public string? ResponseMessage { get; set; }        // Ekstra mesaj yazılmak istenirse

	}

	public enum ResponseStatus
	{
		IsSuccess = 1,
		IsError = 2,
		IsWarning = 3,
	}
	public class ServiceResult
	{
		public ResponseStatus ResponseStatus { get; set; }  // Varsayılan Mesaj
		public string? ResponseMessage { get; set; }        // Ekstra mesaj yazılmak istenirse
	}
}
