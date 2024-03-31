using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class QuotationDetail
    {
        public int QuotationDetailId { get; set; }
        public int? QuotationId { get; set; }
        public int? InteriorId { get; set; }
        public int? Quantity { get; set; }

        public virtual Interior? Interior { get; set; }
        public virtual Quotation? Quotation { get; set; }
    }
}
