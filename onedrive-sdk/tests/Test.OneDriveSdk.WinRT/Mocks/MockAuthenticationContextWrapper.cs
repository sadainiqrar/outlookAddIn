﻿// ------------------------------------------------------------------------------
//  Copyright (c) 2015 Microsoft Corporation
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

namespace Test.OneDriveSdk.WinRT.Mocks
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.OneDrive.Sdk;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    public class MockAuthenticationContextWrapper : IAuthenticationContextWrapper
    {
        public delegate IAuthenticationResult AuthenticationResultCallback(
            string resource,
            string clientId,
            Uri redirectUri,
            UserIdentifier userIdentifier);

        public delegate IAuthenticationResult AuthenticationResultSilentCallback(
            string resource,
            string clientId,
            UserIdentifier userIdentifier);

        public AuthenticationResultCallback AcquireTokenAsyncCallback { get; set; }
        public AuthenticationResultSilentCallback AcquireTokenSilentAsyncCallback { get; set; }

        public Task<IAuthenticationResult> AcquireTokenAsync(
            string resource,
            string clientId,
            Uri redirectUri,
            PromptBehavior promptBehavior,
            UserIdentifier userIdentifier)
        {
            return Task.FromResult(this.AcquireTokenAsyncCallback(resource, clientId, redirectUri, userIdentifier));
        }

        public Task<IAuthenticationResult> AcquireTokenSilentAsync(string resource, string clientId, UserIdentifier userIdentifier)
        {
            return Task.FromResult(this.AcquireTokenSilentAsyncCallback(resource, clientId, userIdentifier));
        }
    }
}
