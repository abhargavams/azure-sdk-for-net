// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Blob restore parameters. </summary>
    public partial class BlobRestoreContent
    {
        /// <summary> Initializes a new instance of BlobRestoreContent. </summary>
        /// <param name="timeToRestore"> Restore blob to the specified time. </param>
        /// <param name="blobRanges"> Blob ranges to restore. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobRanges"/> is null. </exception>
        public BlobRestoreContent(DateTimeOffset timeToRestore, IEnumerable<BlobRestoreRange> blobRanges)
        {
            Argument.AssertNotNull(blobRanges, nameof(blobRanges));

            TimeToRestore = timeToRestore;
            BlobRanges = blobRanges.ToList();
        }

        /// <summary> Initializes a new instance of BlobRestoreContent. </summary>
        /// <param name="timeToRestore"> Restore blob to the specified time. </param>
        /// <param name="blobRanges"> Blob ranges to restore. </param>
        internal BlobRestoreContent(DateTimeOffset timeToRestore, IList<BlobRestoreRange> blobRanges)
        {
            TimeToRestore = timeToRestore;
            BlobRanges = blobRanges;
        }

        /// <summary> Restore blob to the specified time. </summary>
        public DateTimeOffset TimeToRestore { get; set; }
        /// <summary> Blob ranges to restore. </summary>
        public IList<BlobRestoreRange> BlobRanges { get; }
    }
}
