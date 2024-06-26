﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadToSheets.Models
{
    public  class ManifestModel
    {
        public ManifestModel(string prebuildId, string prebuildSKU, string orderId, string orderSku, DateTime? PackedDate)
        {
            this.prebuildId = prebuildId;
            this.prebuildSKU = prebuildSKU;
            this.orderId = orderId;
            this.orderSku = orderSku;
            packedDate= PackedDate.HasValue?PackedDate.Value.ToString("f"):"Null";
        }

        public string prebuildId { get; }
        public string prebuildSKU { get; }
        public string orderId { get; }
        public string orderSku { get; }
        public string packedDate { get; private set; }

    }
}
