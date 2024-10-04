using System;
using System.Collections.Generic;

namespace Aspose.Pdf.Cloud.Sdk
{
    internal static class ListExtensions
    {
        internal static void Add(this List<KeyValuePair<string, string>> list, string key, string value)
        {
            list.Add(new KeyValuePair<string, string>(key, value));
        }
    }
}

