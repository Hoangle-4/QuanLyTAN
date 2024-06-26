using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace DataLayer
{
    public class CloudinaryHelper
    {
        public Cloudinary cloudinary;
        public const string CLOUD_NAME = "";
        public const string API_KEY = "";
        public const string API_SECRET = "";

        public CloudinaryHelper()
        {
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            cloudinary = new Cloudinary(account);
        }

        public string uploadImage(string path)
        {
            var UploadParams = new ImageUploadParams()
            {
                File = new FileDescription(path)
            };
            var uploadResult = cloudinary.Upload(UploadParams);
            return uploadResult.SecureUrl.ToString();
        }
    }
}
