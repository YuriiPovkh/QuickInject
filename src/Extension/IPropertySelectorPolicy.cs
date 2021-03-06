﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.QuickInject
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public interface IPropertySelectorPolicy
    {
        IEnumerable<PropertyInfo> GetProperties(Type t);
    }
}