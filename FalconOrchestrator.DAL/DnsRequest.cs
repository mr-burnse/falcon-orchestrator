//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FalconOrchestrator.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DnsRequest
    {
        public int DnsRequestId { get; set; }
        public System.DateTime Timestamp { get; set; }
        public bool CausedDetect { get; set; }
        public string DomainName { get; set; }
        public string RequestType { get; set; }
        public int InterfaceIndex { get; set; }
        public int DetectionId { get; set; }
    
        public virtual Detection Detection { get; set; }
    }
}
