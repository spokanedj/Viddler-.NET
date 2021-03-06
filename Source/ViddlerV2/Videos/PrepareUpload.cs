﻿using System;
using System.Xml.Serialization;

namespace Viddler.Videos
{
  /// <summary>
  ///Provides request parameters for Viddler API remote method:  viddler.videos.prepareUpload
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.prepareUpload", ElementName = "upload", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class PrepareUpload : Viddler.Data.UploadEndPoint
  {
  }
}
