// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Http.Features
{
    /// <summary>
    /// Represents the HTTP request body as a <see cref="PipeReader"/>.
    /// </summary>
    public interface IRequestBodyPipeFeature
    {
        /// <summary>
        /// Gets a <see cref="PipeReader"/> representing the request body, if any.
        /// </summary>
        PipeReader Reader { get; }
    }
}
