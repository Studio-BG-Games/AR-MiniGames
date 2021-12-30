/*==============================================================================
Copyright (c) 2013-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/
#if !UNITY_EDITOR
using System.IO;
using UnityEditor;
namespace Vuforia.EditorClasses
{
    /// <summary>
    /// class wrapping a JS functionality to unzip a file, registers itself at the Unzipper Singleton to provide the functionality.
    /// </summary>
    [InitializeOnLoad]
    public class SharpZipLibUnzipper : IUnzipper
    {
        /// <summary>
        /// register an instance of this class at the singleton immediately
        /// </summary>
        static SharpZipLibUnzipper()
        {
            Unzipper.Instance = new SharpZipLibUnzipper();
        }

        public Stream UnzipFile(string path, string fileNameinZip)
        {
#if !EXCLUDE_JAVASCRIPT
            return Unzipper.Instance.UnzipFile(path, fileNameinZip);
#else
    return null;
#endif
        }
    }
}
#endif
