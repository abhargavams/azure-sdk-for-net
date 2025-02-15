// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> scale settings for AML Compute. </summary>
    public partial class AmlComputeScaleSettings
    {
        /// <summary> Initializes a new instance of AmlComputeScaleSettings. </summary>
        /// <param name="maxNodeCount"> Max number of nodes to use. </param>
        public AmlComputeScaleSettings(int maxNodeCount)
        {
            MaxNodeCount = maxNodeCount;
        }

        /// <summary> Initializes a new instance of AmlComputeScaleSettings. </summary>
        /// <param name="maxNodeCount"> Max number of nodes to use. </param>
        /// <param name="minNodeCount"> Min number of nodes to use. </param>
        /// <param name="nodeIdleTimeBeforeScaleDown"> Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format. </param>
        internal AmlComputeScaleSettings(int maxNodeCount, int? minNodeCount, TimeSpan? nodeIdleTimeBeforeScaleDown)
        {
            MaxNodeCount = maxNodeCount;
            MinNodeCount = minNodeCount;
            NodeIdleTimeBeforeScaleDown = nodeIdleTimeBeforeScaleDown;
        }

        /// <summary> Max number of nodes to use. </summary>
        public int MaxNodeCount { get; set; }
        /// <summary> Min number of nodes to use. </summary>
        public int? MinNodeCount { get; set; }
        /// <summary> Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format. </summary>
        public TimeSpan? NodeIdleTimeBeforeScaleDown { get; set; }
    }
}
