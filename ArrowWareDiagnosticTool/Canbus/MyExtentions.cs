﻿using ArrowWareDiagnosticTool;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowWareDiagnosticTool
{
    public static class MyExtentions
    {

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;

            if (NumberChars % 2 == 1) {
                hex = String.Concat("0", hex);
            }

            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static string ByteArrayToString(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}