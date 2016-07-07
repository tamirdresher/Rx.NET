﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 
#if HAS_AWAIT
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public interface IAwaitable
    {
        IAwaiter GetAwaiter();
    }

    public interface IAwaiter : ICriticalNotifyCompletion
    {
        bool IsCompleted { get; }
        void GetResult();
    }
}
#endif