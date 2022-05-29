using LostManken.Entities;
using LostManken.Services.Upload;
using LostManken.Validators;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostManken.Services
{
   public class ServiceResult
    {
        public string Message { get; set; }
        public bool Succeded { get; set; }
        public List<string> ErorList { get; set; } = new List<string>();
    }
    
    public class ProductService
    {
        private readonly IFileUploader _fileUploader;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ProductCreateValidator _validator;

        public ProductService(IFileUploader fileUploader, ApplicationDbContext applicationDbContext, ProductCreateValidator validators)
        {
            _fileUploader = fileUploader;
            _applicationDbContext = applicationDbContext;
            _validator = validators;
        }

        public ServiceResult CreateProduct(Product product, List<IFormFile> file)
        {
            var serviceResult = new ServiceResult();

            var mainPhoto = file.FirstOrDefault();
            var d = new FileSystemFileUploader();
            var uploadResult = d.Upload(mainPhoto);

            if (uploadResult.FileResult == FileResult.Succeded)
            {
                product.MainPhoto = uploadResult.FileUrl;
                product.OriginalName = uploadResult.OriginalName;

                var validationResult = _validator.Validate(product);

                if (validationResult.IsValid)
                {

                    product.Photos = new List<ProductPhoto>();

                    foreach (IFormFile item in file.Where(x=>x.FileName != mainPhoto.FileName))
                    {
                        var fileResult = d.Upload(item);

                        if (fileResult.FileResult == Services.Upload.FileResult.Succeded)
                        {
                            var photo = new ProductPhoto
                            {
                                OrginalFileName = fileResult.OriginalName,
                                FileUrl = fileResult.FileUrl
                            };

                            product.Photos.Add(photo);
                        }
                    }


                    _applicationDbContext.Add(product);
                    int result = _applicationDbContext.SaveChanges();

                    if (result > 0 )
                    {
                        serviceResult.Succeded = true;
                        serviceResult.Message = "Kayıt başarılı";
                    }
                    else
                    {
                        serviceResult.ErorList.Add("Kayıt işlemi gerçekleşemedi!");
                        serviceResult.Succeded = false;
                    }
                }
            }
            else
            {
                //serviceResult.ErorList.Add(uploadResult.Message);
                //serviceResult.Succeded = false;
            }
            return serviceResult;
        }
    }
}
