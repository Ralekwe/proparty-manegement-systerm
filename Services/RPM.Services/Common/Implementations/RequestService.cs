﻿namespace RPM.Services.Common.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using RPM.Data;
    using RPM.Data.Models;
    using RPM.Services.Common.Models.Listing;
    using RPM.Services.Common.Models.Request;

    public class RequestService : IRequestService
    {
        private readonly ApplicationDbContext context;
        private readonly IListingService listingService;

        public RequestService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> CreateRequestAsync(RequestCreateServiceModel model)
        {
            return true;
        }

    }
}