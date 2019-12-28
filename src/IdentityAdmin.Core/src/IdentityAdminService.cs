﻿// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace Wangkanai.IdentityAdmin
{
    public class IdentityAdminService : IIdentityAdminService
    {
        public HttpContext Context { get; }

        public IdentityAdminService(HttpContext context)
        {
            Context = context ?? throw new System.ArgumentNullException(nameof(context));
        }
    }
}