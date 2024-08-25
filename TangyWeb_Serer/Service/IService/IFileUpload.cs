using Microsoft.AspNetCore.Components.Forms;

namespace TangyWeb_Serer.Service.IService
{
	public interface IFileUpload
	{

		Task<string> UploadFile(IBrowserFile file);



		bool DeleteFile(string filePath);


	}
}
