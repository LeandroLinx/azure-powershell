// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support
{

    /// <summary>backup support feature type.</summary>
    public partial struct FeatureType :
        System.IEquatable<FeatureType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType DataSourceType = @"DataSourceType";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType Invalid = @"Invalid";

        /// <summary>the value for an instance of the <see cref="FeatureType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FeatureType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FeatureType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FeatureType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FeatureType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FeatureType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FeatureType && Equals((FeatureType)obj);
        }

        /// <summary>Creates an instance of the <see cref="FeatureType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FeatureType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FeatureType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FeatureType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FeatureType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FeatureType" />.</param>

        public static implicit operator FeatureType(string value)
        {
            return new FeatureType(value);
        }

        /// <summary>Implicit operator to convert FeatureType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FeatureType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FeatureType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FeatureType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.FeatureType e2)
        {
            return e2.Equals(e1);
        }
    }
}