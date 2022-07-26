// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support
{

    /// <summary>A flag to determine whether or not NtlmV1 is enabled or disabled.</summary>
    public partial struct NtlmV1 :
        System.IEquatable<NtlmV1>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="NtlmV1" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to NtlmV1</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NtlmV1" />.</param>
        internal static object CreateFrom(object value)
        {
            return new NtlmV1(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type NtlmV1</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type NtlmV1 (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is NtlmV1 && Equals((NtlmV1)obj);
        }

        /// <summary>Returns hashCode for enum NtlmV1</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="NtlmV1"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private NtlmV1(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for NtlmV1</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to NtlmV1</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NtlmV1" />.</param>

        public static implicit operator NtlmV1(string value)
        {
            return new NtlmV1(value);
        }

        /// <summary>Implicit operator to convert NtlmV1 to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="NtlmV1" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum NtlmV1</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 e1, Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum NtlmV1</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 e1, Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Support.NtlmV1 e2)
        {
            return e2.Equals(e1);
        }
    }
}