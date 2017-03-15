// Copyright (c) 2012-2017 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace System.IO
{
    public static class StreamExtensions
    {
        public static void CopyTo(this Stream source, Stream destination)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (destination == null) throw new ArgumentNullException(nameof(destination));

            int b;
            while ((b = source.ReadByte()) >= 0)
            {
                destination.WriteByte((byte)b);
            }
        }
    }
}