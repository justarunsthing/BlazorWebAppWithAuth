using BlazorWebAppWithAuth.Models;

namespace BlazorWebAppWithAuth.Helpers
{
    public static class ImageHelper
    {
        private static readonly string DefaultProfilePictureUrl = "/images/undraw_person.svg";

        public static async Task<ImageUpload> GetImageUploadAsync(IFormFile file)
        {
            using var ms = new MemoryStream();
            await file.CopyToAsync(ms);
            byte[] data = ms.ToArray();

            if (ms.Length > 1 * 1024 * 1024)
            {
                throw new Exception("The image size cannot exceed 1 MB.");
            }

            var imageUpload = new ImageUpload
            {
                Id = Guid.NewGuid(),
                Data = data,
                Type = file.ContentType
            };

            return imageUpload;
        }
    }
}