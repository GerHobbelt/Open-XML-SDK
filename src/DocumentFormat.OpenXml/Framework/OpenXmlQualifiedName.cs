﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct OpenXmlQualifiedName : IComparable<OpenXmlQualifiedName>, IEquatable<OpenXmlQualifiedName>
    {
        internal OpenXmlQualifiedName(in OpenXmlNamespace ns, string name)
        {
            Namespace = ns;
            Name = name;
        }

        public OpenXmlNamespace Namespace { get; }

        public string Name { get; }

        public override bool Equals(object? obj) => obj is OpenXmlQualifiedName qname && Equals(qname);

        public int CompareTo(OpenXmlQualifiedName other)
        {
            var nsCompare = Namespace.CompareTo(other.Namespace);

            if (nsCompare != 0)
            {
                return nsCompare;
            }

            return string.CompareOrdinal(Name, other.Name);
        }

        public override string ToString() => Namespace.IsEmpty ? Name : string.Concat(Namespace.ToString(), ":", Name);

        public bool Equals(OpenXmlQualifiedName other)
            => Namespace.Equals(other.Namespace)
            && string.Equals(Name, other.Name, StringComparison.Ordinal);

        public override int GetHashCode()
        {
            var hashcode = default(HashCode);

            hashcode.Add(Namespace);
            hashcode.Add(Name, StringComparer.Ordinal);

            return hashcode.ToHashCode();
        }

        public static implicit operator OpenXmlQualifiedName(string input) => Parse(input);

        public static OpenXmlQualifiedName Create(string nsUri, string prefix, string name)
            => new(nsUri, name);

        public static OpenXmlQualifiedName Parse(string name, string? nsUri = null)
            => FeatureCollection.TypedOrDefault.GetNamespaceResolver().ParseQName(name, nsUri);
    }
}
