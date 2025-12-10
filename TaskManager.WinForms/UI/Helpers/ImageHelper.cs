using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.WinForms.UI.Helpers
{
    public static class ImageHelper
    {
        /// <summary>
        /// Converts a byte array to an image: System.Drawing.Image
        /// </summary>
        public static Image? ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
