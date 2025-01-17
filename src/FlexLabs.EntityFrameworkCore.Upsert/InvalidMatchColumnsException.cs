﻿using System;

namespace FlexLabs.EntityFrameworkCore.Upsert
{
    /// <summary>
    /// Thrown when using unsupported columns as the upsert match expression.
    /// See: https://go.flexlabs.org/upsert.identitykeymatch
    /// </summary>
    public sealed class InvalidMatchColumnsException : Exception
    {
        internal InvalidMatchColumnsException()
            : base(Resources.UsingAutogeneratedIdentityKeysAsTheUpsertMatchExpressionIsNotSupportedPickANonGeneratedUniqueKey + " " +
                  Resources.FormatSeeLinkForMoreDetails(HelpLinks.IdentityKeyMatchError))
        {
            HelpLink = HelpLinks.IdentityKeyMatchError;
        }
    }
}
