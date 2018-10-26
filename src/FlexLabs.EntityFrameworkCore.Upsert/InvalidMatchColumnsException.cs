﻿using System;

namespace FlexLabs.EntityFrameworkCore.Upsert
{
    /// <summary>
    /// Thrown when using unsupported columns as the upsert match expression.
    /// See: https://flexlabs.org/plink/upsert.sqlite3
    /// </summary>
    /// <seealso cref=""/>
    public sealed class InvalidMatchColumnsException : Exception
    {
        internal InvalidMatchColumnsException()
            : base("Using autogenerated / identity keys as the upsert match excession is not supported. Pick a non generated unique key. " +
                  "See " + HelpLinks.IdentityKeyMatchError + " for more details")
        {
            HelpLink = HelpLinks.IdentityKeyMatchError;
        }
    }
}