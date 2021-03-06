﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.ResourceAuth
{
    public class ApplicationAuthorizationHandler : AuthorizationHandler<ApplicationAuthorRequirement, Application>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ApplicationAuthorRequirement requirement, Application resource)
        {
            if (context.User.Identity.Name == resource.Author.Id)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }

    public class ApplicationAuthorRequirement : IAuthorizationRequirement
    {
        public string UserId { get; set; }

    }
}
