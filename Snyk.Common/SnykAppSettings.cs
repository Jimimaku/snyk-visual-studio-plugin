﻿namespace Snyk.Common
{
    /// <summary>
    /// Snyk application settings.
    /// </summary>
    public class SnykAppSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether Analytics write key.
        /// </summary>
        public string SegmentAnalyticsWriteKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating Snyk code API endpoint.
        /// </summary>
        public string SnykCodeApiEndpoinUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating Snyk Sentry DSN.
        /// </summary>
        public string SentryDsn { get; set; }
    }
}