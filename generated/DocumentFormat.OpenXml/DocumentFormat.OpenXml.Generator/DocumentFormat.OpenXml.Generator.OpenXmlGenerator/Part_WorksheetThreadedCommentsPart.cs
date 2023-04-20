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
    /// Defines the WorksheetThreadedCommentsPart
    /// </summary>
    public partial class WorksheetThreadedCommentsPart : OpenXmlPart,
        IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.threadedcomments+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/10/relationships/threadedComment";
        private DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComments? _rootElement;

        /// <summary>
        /// Creates an instance of the WorksheetThreadedCommentsPart OpenXmlType
        /// </summary>
        internal WorksheetThreadedCommentsPart()
        {
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
                _rootElement = value as DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComments;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => ThreadedComments;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComments ThreadedComments
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComments>();
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

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "threadedcomment";
            string ITargetFeature.Path => "../threadedcomments";
        }
    
    }
}
