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
    /// Representation for general information on item level
    /// </summary>
    public class AssociatedDocument
    {
        /// <summary>
        ///  Detailed information in free text form
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// identifier of the invoice line item
        /// </summary>
        public int? LineID { get; set; }


        /// <summary>
        /// Initializes a new associated document object, optionally passing a certain lineID
        /// </summary>
        /// <param name="lineID"></param>
        public AssociatedDocument(int? lineID = null)
        {
            this.LineID = lineID;
        }
    }
}
