﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the RdArrayPart
    /// </summary>
    public partial class RdArrayPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.rdarray+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/06/relationships/rdArray";
        private DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayData? _rootElement;

        /// <summary>
        /// Creates an instance of the RdArrayPart OpenXmlType
        /// </summary>
        internal RdArrayPart()
        {
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayData ArrayData
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayData>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayData;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => ArrayData;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "rdarray";
            string ITargetFeature.Path => "richData";
        }
    
    }
}
