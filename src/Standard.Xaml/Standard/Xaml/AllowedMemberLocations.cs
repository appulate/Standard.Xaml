﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Standard.Xaml.Schema
{
    [Flags]
    public enum AllowedMemberLocations
    {
        None = 0,
        Attribute = 1,
        MemberElement = 2,
        Any = Attribute | MemberElement,
    }
}
