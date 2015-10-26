using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eolande.AspNet.Domain
{
    [System.Serializable]
    [System.Runtime.Serialization.DataContract]
    public partial class SysUserDomain
    {
        [System.Runtime.Serialization.DataMember]
        public virtual string Id { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string LoginName { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string Password { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string Name { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string Email { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string CreatedBy { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual DateTime? CreatedAt { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string ModifiedBy { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual DateTime? ModifiedAt { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string DeletedBy { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual DateTime? DeletedAt { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual bool IsDeleted { get; set; }
        [System.Runtime.Serialization.DataMember]
        public virtual string Status { get; set; }

    }
}