// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Processor that allows for extensions outside of the Live Video Analytics Edge module to be integrated into the graph. It is the base class for various different kinds of extension processor types. </summary>
    public partial class MediaGraphExtensionProcessorBase : MediaGraphProcessor
    {
        /// <summary> Initializes a new instance of MediaGraphExtensionProcessorBase. </summary>
        /// <param name="name"> The name for this processor node. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this processor node. </param>
        /// <param name="endpoint"> Endpoint to which this processor should connect. </param>
        /// <param name="image"> Describes the parameters of the image that is sent as input to the endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="inputs"/>, <paramref name="endpoint"/>, or <paramref name="image"/> is null. </exception>
        public MediaGraphExtensionProcessorBase(string name, IEnumerable<MediaGraphNodeInput> inputs, MediaGraphEndpoint endpoint, MediaGraphImage image) : base(name, inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            Endpoint = endpoint;
            Image = image;
            Type = "#Microsoft.Media.MediaGraphExtensionProcessorBase";
        }

        /// <summary> Initializes a new instance of MediaGraphExtensionProcessorBase. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="name"> The name for this processor node. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this processor node. </param>
        /// <param name="endpoint"> Endpoint to which this processor should connect. </param>
        /// <param name="image"> Describes the parameters of the image that is sent as input to the endpoint. </param>
        /// <param name="samplingOptions"> Describes the sampling options to be applied when forwarding samples to the extension. </param>
        internal MediaGraphExtensionProcessorBase(string type, string name, IList<MediaGraphNodeInput> inputs, MediaGraphEndpoint endpoint, MediaGraphImage image, MediaGraphSamplingOptions samplingOptions) : base(type, name, inputs)
        {
            Endpoint = endpoint;
            Image = image;
            SamplingOptions = samplingOptions;
            Type = type ?? "#Microsoft.Media.MediaGraphExtensionProcessorBase";
        }

        /// <summary> Endpoint to which this processor should connect. </summary>
        public MediaGraphEndpoint Endpoint { get; set; }
        /// <summary> Describes the parameters of the image that is sent as input to the endpoint. </summary>
        public MediaGraphImage Image { get; set; }
        /// <summary> Describes the sampling options to be applied when forwarding samples to the extension. </summary>
        public MediaGraphSamplingOptions SamplingOptions { get; set; }
    }
}
