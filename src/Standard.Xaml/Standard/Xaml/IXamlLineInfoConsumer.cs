﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Standard.Xaml
{
    public interface IXamlLineInfoConsumer
    {
        void SetLineInfo(int lineNumber, int linePosition);
        bool ShouldProvideLineInfo { get; }
    }
}
