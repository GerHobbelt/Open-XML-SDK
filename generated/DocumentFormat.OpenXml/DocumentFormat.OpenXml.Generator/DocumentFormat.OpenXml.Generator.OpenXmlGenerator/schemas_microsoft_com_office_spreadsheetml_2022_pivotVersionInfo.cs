﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo
{
    /// <summary>
    /// <para>Defines the CacheVersionInfo Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpvi:cacheVersionInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.RequiredFeatureXsdstring" /> <c>&lt;xxpvi:requiredFeature></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.LastRefreshFeatureXsdstring" /> <c>&lt;xxpvi:lastRefreshFeature></c></description></item>
    /// </list>
    /// </remark>
    public partial class CacheVersionInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CacheVersionInfo class.
        /// </summary>
        public CacheVersionInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CacheVersionInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CacheVersionInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CacheVersionInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CacheVersionInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CacheVersionInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CacheVersionInfo(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxpvi:cacheVersionInfo");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.RequiredFeatureXsdstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.LastRefreshFeatureXsdstring>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.RequiredFeatureXsdstring), 0, 0, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.LastRefreshFeatureXsdstring), 0, 0, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheVersionInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotVersionInfo Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpvi:pivotVersionInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.RequiredFeatureXsdstring" /> <c>&lt;xxpvi:requiredFeature></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.LastUpdateFeatureXsdstring" /> <c>&lt;xxpvi:lastUpdateFeature></c></description></item>
    /// </list>
    /// </remark>
    public partial class PivotVersionInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotVersionInfo class.
        /// </summary>
        public PivotVersionInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotVersionInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotVersionInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotVersionInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotVersionInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotVersionInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotVersionInfo(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxpvi:pivotVersionInfo");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.RequiredFeatureXsdstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.LastUpdateFeatureXsdstring>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.RequiredFeatureXsdstring), 0, 0, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo.LastUpdateFeatureXsdstring), 0, 0, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotVersionInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the RequiredFeatureXsdstring Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpvi:requiredFeature.</para>
    /// </summary>
    public partial class RequiredFeatureXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RequiredFeatureXsdstring class.
        /// </summary>
        public RequiredFeatureXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RequiredFeatureXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RequiredFeatureXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxpvi:requiredFeature");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RequiredFeatureXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the LastRefreshFeatureXsdstring Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpvi:lastRefreshFeature.</para>
    /// </summary>
    public partial class LastRefreshFeatureXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LastRefreshFeatureXsdstring class.
        /// </summary>
        public LastRefreshFeatureXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LastRefreshFeatureXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LastRefreshFeatureXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxpvi:lastRefreshFeature");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LastRefreshFeatureXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the LastUpdateFeatureXsdstring Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpvi:lastUpdateFeature.</para>
    /// </summary>
    public partial class LastUpdateFeatureXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LastUpdateFeatureXsdstring class.
        /// </summary>
        public LastUpdateFeatureXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LastUpdateFeatureXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LastUpdateFeatureXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxpvi:lastUpdateFeature");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LastUpdateFeatureXsdstring>(deep);
    }
}