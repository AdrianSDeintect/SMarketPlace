﻿using Serenity.Services;

namespace SMarketPlace.Membership
{
    public class SignUpResponse : ServiceResponse
    {
        public string DemoActivationLink { get; set; }
    }
}