﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceLink
{
    public interface Interfaces
    {
        void AppendBytes(byte[] buffPort);
        void Write(string text);
        void Write(char[] buffer, int offset, int count);
        bool Write(byte[] buffer, int offset, int count);
        void WriteLine(string text);
        void Recall_DataReceived(object sender, object e);
    }
}