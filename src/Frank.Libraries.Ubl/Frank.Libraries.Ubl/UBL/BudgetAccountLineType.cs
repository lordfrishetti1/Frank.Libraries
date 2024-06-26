using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("BudgetAccountLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class BudgetAccountLineType
{
    private BudgetAccountType[] budgetAccountField;

    private IDType idField;

    private TotalAmountType totalAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalAmountType TotalAmount
    {
        get => totalAmountField;
        set => totalAmountField = value;
    }

    /// <remarks />
    [XmlElement("BudgetAccount")]
    public BudgetAccountType[] BudgetAccount
    {
        get => budgetAccountField;
        set => budgetAccountField = value;
    }
}