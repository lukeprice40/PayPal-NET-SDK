using Newtonsoft.Json;

namespace PayPal.Api
{
    public class InvoicingRefundDetail : PayPalSerializableObject
    {
        /// <summary>
        /// PayPal refund type indicating whether refund was done in invoicing flow via PayPal or externally. In the case of the mark-as-refunded API, refund type is EXTERNAL and this is what is now supported. The PAYPAL value is provided for backward compatibility.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string type { get; set; }

        /// <summary>
        /// Date when the invoice was marked as refunded. If no date is specified, the current date and time is used as the default. In addition, the date must be after the invoice payment date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "date")]
        public string date { get; set; }

        /// <summary>
        /// Optional note associated with the refund.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "note")]
        public string note { get; set; }
    }
}