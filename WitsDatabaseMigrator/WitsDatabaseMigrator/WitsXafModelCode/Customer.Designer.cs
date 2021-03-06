﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace WITS.to.XAF.WITSRej
{

    public partial class Customer : XPCustomObject
    {
        Guid fOid;
        [Key(true)]
        public Guid Oid
        {
            get { return fOid; }
            set { SetPropertyValue<Guid>("Oid", ref fOid, value); }
        }
        bool fIsSystemObject;
        public bool IsSystemObject
        {
            get { return fIsSystemObject; }
            set { SetPropertyValue<bool>("IsSystemObject", ref fIsSystemObject, value); }
        }
        Guid fOrganization;
        [Indexed(Name = @"iOrganization_Customer")]
        public Guid Organization
        {
            get { return fOrganization; }
            set { SetPropertyValue<Guid>("Organization", ref fOrganization, value); }
        }
        Guid fLocation;
        [Indexed(Name = @"iLocation_Customer")]
        public Guid Location
        {
            get { return fLocation; }
            set { SetPropertyValue<Guid>("Location", ref fLocation, value); }
        }
        string fOrganizationName;
        public string OrganizationName
        {
            get { return fOrganizationName; }
            set { SetPropertyValue<string>("OrganizationName", ref fOrganizationName, value); }
        }
        string fLocationName;
        public string LocationName
        {
            get { return fLocationName; }
            set { SetPropertyValue<string>("LocationName", ref fLocationName, value); }
        }
        bool fIsActive;
        public bool IsActive
        {
            get { return fIsActive; }
            set { SetPropertyValue<bool>("IsActive", ref fIsActive, value); }
        }
        string fCreatedBy;
        public string CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<string>("CreatedBy", ref fCreatedBy, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        string fModifiedBy;
        public string ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<string>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fModifiedOn;
        public DateTime ModifiedOn
        {
            get { return fModifiedOn; }
            set { SetPropertyValue<DateTime>("ModifiedOn", ref fModifiedOn, value); }
        }
        string fTag;
        [Size(SizeAttribute.Unlimited)]
        public string Tag
        {
            get { return fTag; }
            set { SetPropertyValue<string>("Tag", ref fTag, value); }
        }
        int fAccessStatus;
        public int AccessStatus
        {
            get { return fAccessStatus; }
            set { SetPropertyValue<int>("AccessStatus", ref fAccessStatus, value); }
        }
        string fFriendlyId;
        public string FriendlyId
        {
            get { return fFriendlyId; }
            set { SetPropertyValue<string>("FriendlyId", ref fFriendlyId, value); }
        }
        long fSequenceId;
        public long SequenceId
        {
            get { return fSequenceId; }
            set { SetPropertyValue<long>("SequenceId", ref fSequenceId, value); }
        }
        string fAccountName;
        [Indexed(Name = @"IDX_ACCOUNTNAME")]
        [Size(255)]
        public string AccountName
        {
            get { return fAccountName; }
            set { SetPropertyValue<string>("AccountName", ref fAccountName, value); }
        }
        int fCustomerType;
        public int CustomerType
        {
            get { return fCustomerType; }
            set { SetPropertyValue<int>("CustomerType", ref fCustomerType, value); }
        }
        byte[] fPhoto;
        [Size(SizeAttribute.Unlimited)]
        public byte[] Photo
        {
            get { return fPhoto; }
            set { SetPropertyValue<byte[]>("Photo", ref fPhoto, value); }
        }
        string fCustomerName;
        public string CustomerName
        {
            get { return fCustomerName; }
            set { SetPropertyValue<string>("CustomerName", ref fCustomerName, value); }
        }
        string fCustomerModifier;
        [Size(10)]
        public string CustomerModifier
        {
            get { return fCustomerModifier; }
            set { SetPropertyValue<string>("CustomerModifier", ref fCustomerModifier, value); }
        }
        string fCustomerOldKey;
        [Size(15)]
        public string CustomerOldKey
        {
            get { return fCustomerOldKey; }
            set { SetPropertyValue<string>("CustomerOldKey", ref fCustomerOldKey, value); }
        }
        decimal fCustomerFee;
        public decimal CustomerFee
        {
            get { return fCustomerFee; }
            set { SetPropertyValue<decimal>("CustomerFee", ref fCustomerFee, value); }
        }
        bool fIsCarrier;
        public bool IsCarrier
        {
            get { return fIsCarrier; }
            set { SetPropertyValue<bool>("IsCarrier", ref fIsCarrier, value); }
        }
        bool fIsBroker;
        public bool IsBroker
        {
            get { return fIsBroker; }
            set { SetPropertyValue<bool>("IsBroker", ref fIsBroker, value); }
        }
        string fNotes;
        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get { return fNotes; }
            set { SetPropertyValue<string>("Notes", ref fNotes, value); }
        }
        Guid fPrimaryAddress;
        [Indexed(Name = @"iPrimaryAddress_Customer")]
        public Guid PrimaryAddress
        {
            get { return fPrimaryAddress; }
            set { SetPropertyValue<Guid>("PrimaryAddress", ref fPrimaryAddress, value); }
        }
        Guid fPrimaryPhone;
        [Indexed(Name = @"iPrimaryPhone_Customer")]
        public Guid PrimaryPhone
        {
            get { return fPrimaryPhone; }
            set { SetPropertyValue<Guid>("PrimaryPhone", ref fPrimaryPhone, value); }
        }
        Guid fPrimaryEmail;
        [Indexed(Name = @"iPrimaryEmail_Customer")]
        public Guid PrimaryEmail
        {
            get { return fPrimaryEmail; }
            set { SetPropertyValue<Guid>("PrimaryEmail", ref fPrimaryEmail, value); }
        }
        [Association(@"CertificateReferencesCustomer")]
        public XPCollection<Certificate> Certificates { get { return GetCollection<Certificate>("Certificates"); } }
        [Association(@"CertificateReferencesCustomer1")]
        public XPCollection<Certificate> Certificates1 { get { return GetCollection<Certificate>("Certificates1"); } }
        [Association(@"CertificateReferencesCustomer2")]
        public XPCollection<Certificate> Certificates2 { get { return GetCollection<Certificate>("Certificates2"); } }
        [Association(@"GrowerYTDReferencesCustomer")]
        public XPCollection<GrowerYTD> GrowerYTDs { get { return GetCollection<GrowerYTD>("GrowerYTDs"); } }
        [Association(@"LotNumberReferencesCustomer")]
        public XPCollection<LotNumber> LotNumbers { get { return GetCollection<LotNumber>("LotNumbers"); } }
        [Association(@"SplitDetailReferencesCustomer")]
        public XPCollection<SplitDetail> SplitDetails { get { return GetCollection<SplitDetail>("SplitDetails"); } }
        [Association(@"SplitDetailReferencesCustomer1")]
        public XPCollection<SplitDetail> SplitDetails1 { get { return GetCollection<SplitDetail>("SplitDetails1"); } }
        [Association(@"SplitSetupReferencesCustomer")]
        public XPCollection<SplitSetup> SplitSetups { get { return GetCollection<SplitSetup>("SplitSetups"); } }
    }

}
