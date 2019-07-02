﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web;

namespace Syncfusion.EJ2.FileManager.Base
{
    public interface FileProviderBase
    {

        FileManagerResponse GetFiles(string path, bool showHiddenItems, params FileManagerDirectoryContent[] data);
        FileManagerResponse Create(string path, string name, params FileManagerDirectoryContent[] data);

        FileManagerResponse Details(string path, string[] names, params FileManagerDirectoryContent[] data);

        FileManagerResponse Delete(string path, string[] names, params FileManagerDirectoryContent[] data);

        FileManagerResponse Rename(string path, string name, string newName, bool replace = false, params FileManagerDirectoryContent[] data);

        FileManagerResponse Copy(string path, string targetPath, string[] names, string[] replacedItemNames, params FileManagerDirectoryContent[] data);

        FileManagerResponse Move(string path, string targetPath, string[] names, string[] replacedItemNames, params FileManagerDirectoryContent[] data);

        FileManagerResponse Search(string path, string searchString, bool showHiddenItems, bool caseSensitive, params FileManagerDirectoryContent[] data);

        FileStreamResult Download(string path, string[] names, params FileManagerDirectoryContent[] data);

        FileManagerResponse Upload(string path, IList<System.Web.HttpPostedFileBase> uploadFiles, string action, params FileManagerDirectoryContent[] data);


        FileStreamResult GetImage(string path, string id, bool allowCompress, ImageSize size, params FileManagerDirectoryContent[] data);
      
    }

}




