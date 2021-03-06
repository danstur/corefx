// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class IpHlpApi
    {
        [DllImport(Interop.Libraries.IpHlpApi, ExactSpelling = true)]
        internal static extern uint GetNetworkParams(SafeLocalAllocHandle pFixedInfo, ref uint pOutBufLen);
    }
}
