﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("BudgetAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class BudgetAccountType
    {

        private IDType idField;

        private BudgetYearNumericType budgetYearNumericField;

        private ClassificationSchemeType requiredClassificationSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BudgetYearNumericType BudgetYearNumeric
        {
            get
            {
                return budgetYearNumericField;
            }
            set
            {
                budgetYearNumericField = value;
            }
        }

        /// <remarks/>
        public ClassificationSchemeType RequiredClassificationScheme
        {
            get
            {
                return requiredClassificationSchemeField;
            }
            set
            {
                requiredClassificationSchemeField = value;
            }
        }
    }
}