﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.444.0.

using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.SBDH
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.444.0")]
    [Serializable()]
    [XmlType("Scope", Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class Scope : IScopeAttributes
    {

        [Required()]
        [XmlElement("Type")]
        public string Type { get; set; }

        [Required()]
        [XmlElement("InstanceIdentifier")]
        public string InstanceIdentifier { get; set; }

        [XmlElement("Identifier")]
        public string Identifier { get; set; }

        [XmlIgnore()]
        private Collection<object> _scopeInformation;

        [XmlElement("ScopeInformation")]
        public Collection<object> ScopeInformation
        {
            get
            {
                return this._scopeInformation;
            }
            private set
            {
                this._scopeInformation = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ScopeInformation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ScopeInformation collection is empty.</para>
        /// </summary>
        [XmlIgnore()]
        public bool ScopeInformationSpecified
        {
            get
            {
                return (this.ScopeInformation.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Scope" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Scope" /> class.</para>
        /// </summary>
        public Scope()
        {
            this._scopeInformation = new Collection<object>();
        }
    }
}