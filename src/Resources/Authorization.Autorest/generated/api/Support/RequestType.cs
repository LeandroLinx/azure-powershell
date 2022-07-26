// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support
{

    /// <summary>
    /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
    /// </summary>
    public partial struct RequestType :
        System.IEquatable<RequestType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType AdminAssign = @"AdminAssign";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType AdminExtend = @"AdminExtend";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType AdminRemove = @"AdminRemove";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType AdminRenew = @"AdminRenew";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType AdminUpdate = @"AdminUpdate";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType SelfActivate = @"SelfActivate";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType SelfDeactivate = @"SelfDeactivate";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType SelfExtend = @"SelfExtend";

        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType SelfRenew = @"SelfRenew";

        /// <summary>the value for an instance of the <see cref="RequestType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RequestType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RequestType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RequestType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RequestType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RequestType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RequestType && Equals((RequestType)obj);
        }

        /// <summary>Returns hashCode for enum RequestType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RequestType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RequestType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RequestType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RequestType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RequestType" />.</param>

        public static implicit operator RequestType(string value)
        {
            return new RequestType(value);
        }

        /// <summary>Implicit operator to convert RequestType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RequestType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RequestType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType e1, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RequestType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType e1, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.RequestType e2)
        {
            return e2.Equals(e1);
        }
    }
}