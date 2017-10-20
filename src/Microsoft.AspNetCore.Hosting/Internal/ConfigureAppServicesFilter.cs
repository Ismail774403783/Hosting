// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Hosting.Internal
{
    internal class ConfigureAppServicesFilter: IStartupConfigureServicesFilter
    {
        private readonly Action<IServiceCollection> _action;

        public ConfigureAppServicesFilter(Action<IServiceCollection> action)
        {
            _action = action;
        }

        public Action<IServiceCollection> ConfigureServices(Action<IServiceCollection> next)
        {
            return collection => _action(collection);
        }
    }
}