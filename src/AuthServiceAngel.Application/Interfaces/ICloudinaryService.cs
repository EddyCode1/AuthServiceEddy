namespace AuthServiceAngel.Application.Interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData imageFile, string FileName);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaulAvatar  (); 
    string GetFullImageUrl(string imagePath);
}