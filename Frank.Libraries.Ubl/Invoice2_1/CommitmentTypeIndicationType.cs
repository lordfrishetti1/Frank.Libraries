﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CommitmentTypeIndicationType
    {

        private ObjectIdentifierType commitmentTypeIdField;

        private object[] itemsField;

        private AnyType[] commitmentTypeQualifiersField;

        /// <remarks/>
        public ObjectIdentifierType CommitmentTypeId
        {
            get
            {
                return commitmentTypeIdField;
            }
            set
            {
                commitmentTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllSignedDataObjects", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ObjectReference", typeof(string), DataType = "anyURI")]
        public object[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CommitmentTypeQualifier", IsNullable = false)]
        public AnyType[] CommitmentTypeQualifiers
        {
            get
            {
                return commitmentTypeQualifiersField;
            }
            set
            {
                commitmentTypeQualifiersField = value;
            }
        }
    }
}