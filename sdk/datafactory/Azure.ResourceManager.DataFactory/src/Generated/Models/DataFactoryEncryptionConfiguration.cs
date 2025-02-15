// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Definition of CMK for the factory. </summary>
    public partial class DataFactoryEncryptionConfiguration
    {
        /// <summary> Initializes a new instance of DataFactoryEncryptionConfiguration. </summary>
        /// <param name="keyName"> The name of the key in Azure Key Vault to use as Customer Managed Key. </param>
        /// <param name="vaultBaseUri"> The url of the Azure Key Vault used for CMK. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="vaultBaseUri"/> is null. </exception>
        public DataFactoryEncryptionConfiguration(string keyName, Uri vaultBaseUri)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));
            Argument.AssertNotNull(vaultBaseUri, nameof(vaultBaseUri));

            KeyName = keyName;
            VaultBaseUri = vaultBaseUri;
        }

        /// <summary> Initializes a new instance of DataFactoryEncryptionConfiguration. </summary>
        /// <param name="keyName"> The name of the key in Azure Key Vault to use as Customer Managed Key. </param>
        /// <param name="vaultBaseUri"> The url of the Azure Key Vault used for CMK. </param>
        /// <param name="keyVersion"> The version of the key used for CMK. If not provided, latest version will be used. </param>
        /// <param name="identity"> User assigned identity to use to authenticate to customer's key vault. If not provided Managed Service Identity will be used. </param>
        internal DataFactoryEncryptionConfiguration(string keyName, Uri vaultBaseUri, string keyVersion, DataFactoryCmkIdentity identity)
        {
            KeyName = keyName;
            VaultBaseUri = vaultBaseUri;
            KeyVersion = keyVersion;
            Identity = identity;
        }

        /// <summary> The name of the key in Azure Key Vault to use as Customer Managed Key. </summary>
        public string KeyName { get; set; }
        /// <summary> The url of the Azure Key Vault used for CMK. </summary>
        public Uri VaultBaseUri { get; set; }
        /// <summary> The version of the key used for CMK. If not provided, latest version will be used. </summary>
        public string KeyVersion { get; set; }
        /// <summary> User assigned identity to use to authenticate to customer's key vault. If not provided Managed Service Identity will be used. </summary>
        internal DataFactoryCmkIdentity Identity { get; set; }
        /// <summary> The resource id of the user assigned identity to authenticate to customer's key vault. </summary>
        public string UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new DataFactoryCmkIdentity();
                Identity.UserAssignedIdentity = value;
            }
        }
    }
}
