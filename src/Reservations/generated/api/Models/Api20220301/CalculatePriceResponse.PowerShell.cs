// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(CalculatePriceResponseTypeConverter))]
    public partial class CalculatePriceResponse
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CalculatePriceResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponsePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).BillingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponsePropertiesBillingCurrencyTotal) content.GetValueForProperty("BillingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).BillingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponsePropertiesBillingCurrencyTotalTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).NetTotal = (double?) content.GetValueForProperty("NetTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).NetTotal, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("TaxTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).TaxTotal = (double?) content.GetValueForProperty("TaxTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).TaxTotal, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("GrandTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).GrandTotal = (double?) content.GetValueForProperty("GrandTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).GrandTotal, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("IsTaxIncluded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsTaxIncluded = (bool?) content.GetValueForProperty("IsTaxIncluded",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsTaxIncluded, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsBillingPartnerManaged"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsBillingPartnerManaged = (bool?) content.GetValueForProperty("IsBillingPartnerManaged",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsBillingPartnerManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReservationOrderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).ReservationOrderId = (string) content.GetValueForProperty("ReservationOrderId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).ReservationOrderId, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuTitle = (string) content.GetValueForProperty("SkuTitle",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuTitle, global::System.Convert.ToString);
            }
            if (content.Contains("SkuDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuDescription = (string) content.GetValueForProperty("SkuDescription",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuDescription, global::System.Convert.ToString);
            }
            if (content.Contains("PricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponsePropertiesPricingCurrencyTotal) content.GetValueForProperty("PricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponsePropertiesPricingCurrencyTotalTypeConverter.ConvertFrom);
            }
            if (content.Contains("PaymentSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PaymentSchedule = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPaymentDetail[]) content.GetValueForProperty("PaymentSchedule",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PaymentSchedule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PaymentDetailTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CalculatePriceResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponsePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).BillingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponsePropertiesBillingCurrencyTotal) content.GetValueForProperty("BillingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).BillingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponsePropertiesBillingCurrencyTotalTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).NetTotal = (double?) content.GetValueForProperty("NetTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).NetTotal, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("TaxTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).TaxTotal = (double?) content.GetValueForProperty("TaxTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).TaxTotal, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("GrandTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).GrandTotal = (double?) content.GetValueForProperty("GrandTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).GrandTotal, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("IsTaxIncluded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsTaxIncluded = (bool?) content.GetValueForProperty("IsTaxIncluded",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsTaxIncluded, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsBillingPartnerManaged"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsBillingPartnerManaged = (bool?) content.GetValueForProperty("IsBillingPartnerManaged",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).IsBillingPartnerManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReservationOrderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).ReservationOrderId = (string) content.GetValueForProperty("ReservationOrderId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).ReservationOrderId, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuTitle = (string) content.GetValueForProperty("SkuTitle",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuTitle, global::System.Convert.ToString);
            }
            if (content.Contains("SkuDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuDescription = (string) content.GetValueForProperty("SkuDescription",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).SkuDescription, global::System.Convert.ToString);
            }
            if (content.Contains("PricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponsePropertiesPricingCurrencyTotal) content.GetValueForProperty("PricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponsePropertiesPricingCurrencyTotalTypeConverter.ConvertFrom);
            }
            if (content.Contains("PaymentSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PaymentSchedule = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPaymentDetail[]) content.GetValueForProperty("PaymentSchedule",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponseInternal)this).PaymentSchedule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.PaymentDetailTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CalculatePriceResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.CalculatePriceResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CalculatePriceResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CalculatePriceResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CalculatePriceResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ICalculatePriceResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(CalculatePriceResponseTypeConverter))]
    public partial interface ICalculatePriceResponse

    {

    }
}