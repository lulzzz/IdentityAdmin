﻿// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Microsoft.Extensions.Configuration;
using System;
using Wangkanai.IdentityAdmin.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminServiceCollectionExtensions
    {
        public static IdentityAdminBuilder AddIdentityAdmin(
            this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddIdentityAdminCore()
                .AddDefaultUI()
                .AddWebApiService();

            return new IdentityAdminBuilder(services);
        }

        public static IdentityAdminBuilder AddIdentityAdmin(
            this IServiceCollection services,
            Action<IdentityAdminOptions> setAction)
        {
            services.Configure(setAction);

            return services.AddIdentityAdmin();
        }

        public static IdentityAdminBuilder AddIdentityAdmin(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<IdentityAdminOptions>(configuration);

            return services.AddIdentityAdmin();
        }
    }
}