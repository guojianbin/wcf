// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.ServiceModel
{
    [Serializable]
    public class CommunicationObjectFaultedException : CommunicationException
    {
        public CommunicationObjectFaultedException() { }
        public CommunicationObjectFaultedException(string message) : base(message) { }
        public CommunicationObjectFaultedException(string message, Exception innerException) : base(message, innerException) { }
        protected CommunicationObjectFaultedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
