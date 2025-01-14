/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2industries.ZUGFeRD
{
    /// <summary>
    /// Reference documents are supposed to hold additional data you might want to show on item level.
    /// 
    /// Reference documents are used e.g. for commissions on item level
    /// </summary>
    public class AdditionalReferencedDocument : BaseReferencedDocument
    {
        /// <summary>
        /// Reference documents are strongly typed, specify ReferenceTypeCode to allow easy processing by invoicee
        /// </summary>
        public ReferenceTypeCodes ReferenceTypeCode { get; set; }
        
        public string IssuerAssignedID { get; set; }

        public string Name { get; set; }

        public string AttachmentBinaryObject { get; set; }

        public string mimeCode { get; set; }

        public AdditionalReferencedDocumentTypeCode TypeCode { get; set; }
    }
}
