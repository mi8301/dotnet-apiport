﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Fx.Portability
{
    public interface IProgressTask : IDisposable
    {
        void ReportUnitComplete();
        void Abort();
    }
}