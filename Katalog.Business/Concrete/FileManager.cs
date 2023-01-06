using Katalog.Business.Abstracts;
using Katalog.Core.Utilities.Helpers.File;
using Katalog.Core.Utilities.Results;
using Katalog.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog.Business.Concrete
{
    public class FileManager : IFileService
    {
        private readonly IUrunService _urunService;
        private readonly IFileHelper _fileHelper;

        public FileManager(IUrunService urunService, IFileHelper fileHelper)
        {
            _urunService = urunService;
            _fileHelper = fileHelper;
        }

        public async Task<IResult> Add(IFormFile file, Urun urun)
        {
            if(!string.IsNullOrEmpty(urun.Resim))
            {
                _fileHelper.Remove(urun.Resim);
            }
            var imageresult = _fileHelper.Upload(file);
            if(!imageresult.Success)
            {
                return new ErrorResult("Resim Yüklenemedi...");
            }

            urun.Resim = imageresult.Message;
            _urunService.Update(urun);
            return new SuccessResult("Resim Yüklendi");
        }
    }
}