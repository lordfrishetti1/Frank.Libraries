using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class CreditNoteResult
    {
        /// <summary>
        /// Id of credit note
        /// </summary>
        /// <value>Id of credit note</value>
        [DataMember(Name = "creditNoteId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditNoteId")]
        public long? CreditNoteId { get; set; }

        /// <summary>
        /// Unique credit note number generated by us.
        /// </summary>
        /// <value>Unique credit note number generated by us.</value>
        [DataMember(Name = "creditNoteNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditNoteNumber")]
        public long? CreditNoteNumber { get; set; }

        /// <summary>
        /// Norwegian KID number. Number from 2 to 25 digits long.
        /// </summary>
        /// <value>Norwegian KID number. Number from 2 to 25 digits long.</value>
        [DataMember(Name = "kid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customer")]
        public Contact Customer { get; set; }

        /// <summary>
        /// Net amount (in creditNote currency) in cents.
        /// </summary>
        /// <value>Net amount (in creditNote currency) in cents.</value>
        [DataMember(Name = "net", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "net")]
        public long? Net { get; set; }

        /// <summary>
        /// VAT amount (in creditNote currency) in cents.
        /// </summary>
        /// <value>VAT amount (in creditNote currency) in cents.</value>
        [DataMember(Name = "vat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vat")]
        public long? Vat { get; set; }

        /// <summary>
        /// Gross amount (= net+VAT) (in creditNote currency) in cents.
        /// </summary>
        /// <value>Gross amount (= net+VAT) (in creditNote currency) in cents.</value>
        [DataMember(Name = "gross", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gross")]
        public long? Gross { get; set; }

        /// <summary>
        /// Net amount in NOK (in cents)
        /// </summary>
        /// <value>Net amount in NOK (in cents)</value>
        [DataMember(Name = "netInNok", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "netInNok")]
        public long? NetInNok { get; set; }

        /// <summary>
        /// VAT amount in NOK (in cents)
        /// </summary>
        /// <value>VAT amount in NOK (in cents)</value>
        [DataMember(Name = "vatInNok", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vatInNok")]
        public long? VatInNok { get; set; }

        /// <summary>
        /// Gross amount in NOK (in cents)
        /// </summary>
        /// <value>Gross amount in NOK (in cents)</value>
        [DataMember(Name = "grossInNok", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "grossInNok")]
        public long? GrossInNok { get; set; }

        /// <summary>
        /// Comment/description printed above the credit note lines.
        /// </summary>
        /// <value>Comment/description printed above the credit note lines.</value>
        [DataMember(Name = "creditNoteText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditNoteText")]
        public string CreditNoteText { get; set; }

        /// <summary>
        /// Gets or Sets YourReference
        /// </summary>
        [DataMember(Name = "yourReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "yourReference")]
        public string YourReference { get; set; }

        /// <summary>
        /// Gets or Sets OurReference
        /// </summary>
        [DataMember(Name = "ourReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ourReference")]
        public string OurReference { get; set; }

        /// <summary>
        /// Reference if sending via EHF.
        /// </summary>
        /// <value>Reference if sending via EHF.</value>
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderReference")]
        public string OrderReference { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lines")]
        public List<InvoiceLineResult> Lines { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        /// <value>ISO 4217 currency code</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Issue date of the credit note, format yyyy-mm-dd
        /// </summary>
        /// <value>Issue date of the credit note, format yyyy-mm-dd</value>
        [DataMember(Name = "issueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issueDate")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// If the credit note as been marked as settled (True) or not (False).
        /// </summary>
        /// <value>If the credit note as been marked as settled (True) or not (False).</value>
        [DataMember(Name = "settled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settled")]
        public bool? Settled { get; set; }

        /// <summary>
        /// Id of associated invoice
        /// </summary>
        /// <value>Id of associated invoice</value>
        [DataMember(Name = "associatedInvoiceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "associatedInvoiceId")]
        public long? AssociatedInvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets CreditNotePdf
        /// </summary>
        [DataMember(Name = "creditNotePdf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditNotePdf")]
        public Attachment CreditNotePdf { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "project")]
        public ProjectResult Project { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditNoteResult {\n");
            sb.Append("  CreditNoteId: ")
              .Append(CreditNoteId)
              .Append("\n");
            sb.Append("  CreditNoteNumber: ")
              .Append(CreditNoteNumber)
              .Append("\n");
            sb.Append("  Kid: ")
              .Append(Kid)
              .Append("\n");
            sb.Append("  Customer: ")
              .Append(Customer)
              .Append("\n");
            sb.Append("  Net: ")
              .Append(Net)
              .Append("\n");
            sb.Append("  Vat: ")
              .Append(Vat)
              .Append("\n");
            sb.Append("  Gross: ")
              .Append(Gross)
              .Append("\n");
            sb.Append("  NetInNok: ")
              .Append(NetInNok)
              .Append("\n");
            sb.Append("  VatInNok: ")
              .Append(VatInNok)
              .Append("\n");
            sb.Append("  GrossInNok: ")
              .Append(GrossInNok)
              .Append("\n");
            sb.Append("  CreditNoteText: ")
              .Append(CreditNoteText)
              .Append("\n");
            sb.Append("  YourReference: ")
              .Append(YourReference)
              .Append("\n");
            sb.Append("  OurReference: ")
              .Append(OurReference)
              .Append("\n");
            sb.Append("  OrderReference: ")
              .Append(OrderReference)
              .Append("\n");
            sb.Append("  Address: ")
              .Append(Address)
              .Append("\n");
            sb.Append("  Lines: ")
              .Append(Lines)
              .Append("\n");
            sb.Append("  Currency: ")
              .Append(Currency)
              .Append("\n");
            sb.Append("  IssueDate: ")
              .Append(IssueDate)
              .Append("\n");
            sb.Append("  Settled: ")
              .Append(Settled)
              .Append("\n");
            sb.Append("  AssociatedInvoiceId: ")
              .Append(AssociatedInvoiceId)
              .Append("\n");
            sb.Append("  CreditNotePdf: ")
              .Append(CreditNotePdf)
              .Append("\n");
            sb.Append("  Project: ")
              .Append(Project)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}