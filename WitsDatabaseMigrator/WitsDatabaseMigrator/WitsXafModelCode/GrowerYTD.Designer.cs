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

    public partial class GrowerYTD : XPCustomObject
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
        [Indexed(Name = @"iOrganization_GrowerYTD")]
        public Guid Organization
        {
            get { return fOrganization; }
            set { SetPropertyValue<Guid>("Organization", ref fOrganization, value); }
        }
        Guid fLocation;
        [Indexed(Name = @"iLocation_GrowerYTD")]
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
        Customer fCustomer;
        [Association(@"GrowerYTDReferencesCustomer")]
        public Customer Customer
        {
            get { return fCustomer; }
            set { SetPropertyValue<Customer>("Customer", ref fCustomer, value); }
        }
        LotNumber fLot;
        [Association(@"GrowerYTDReferencesLotNumber")]
        public LotNumber Lot
        {
            get { return fLot; }
            set { SetPropertyValue<LotNumber>("Lot", ref fLot, value); }
        }
        long fFK_fromID;
        public long FK_fromID
        {
            get { return fFK_fromID; }
            set { SetPropertyValue<long>("FK_fromID", ref fFK_fromID, value); }
        }
        long fFK_commodity;
        public long FK_commodity
        {
            get { return fFK_commodity; }
            set { SetPropertyValue<long>("FK_commodity", ref fFK_commodity, value); }
        }
        long fFK_affil_id;
        public long FK_affil_id
        {
            get { return fFK_affil_id; }
            set { SetPropertyValue<long>("FK_affil_id", ref fFK_affil_id, value); }
        }
        long fFK_storage;
        public long FK_storage
        {
            get { return fFK_storage; }
            set { SetPropertyValue<long>("FK_storage", ref fFK_storage, value); }
        }
        string fGroYtdGroup;
        [Size(10)]
        public string GroYtdGroup
        {
            get { return fGroYtdGroup; }
            set { SetPropertyValue<string>("GroYtdGroup", ref fGroYtdGroup, value); }
        }
        string fGroYtdPcn;
        [Size(10)]
        public string GroYtdPcn
        {
            get { return fGroYtdPcn; }
            set { SetPropertyValue<string>("GroYtdPcn", ref fGroYtdPcn, value); }
        }
        string fGroYtdTransactionCode;
        [Size(2)]
        public string GroYtdTransactionCode
        {
            get { return fGroYtdTransactionCode; }
            set { SetPropertyValue<string>("GroYtdTransactionCode", ref fGroYtdTransactionCode, value); }
        }
        DateTime fGroYtdDate;
        public DateTime GroYtdDate
        {
            get { return fGroYtdDate; }
            set { SetPropertyValue<DateTime>("GroYtdDate", ref fGroYtdDate, value); }
        }
        int fGroYtdNet;
        public int GroYtdNet
        {
            get { return fGroYtdNet; }
            set { SetPropertyValue<int>("GroYtdNet", ref fGroYtdNet, value); }
        }
        int fGroYtdDry;
        public int GroYtdDry
        {
            get { return fGroYtdDry; }
            set { SetPropertyValue<int>("GroYtdDry", ref fGroYtdDry, value); }
        }
        int fGroYtdCredit;
        public int GroYtdCredit
        {
            get { return fGroYtdCredit; }
            set { SetPropertyValue<int>("GroYtdCredit", ref fGroYtdCredit, value); }
        }
        int fGroYtdDebit;
        public int GroYtdDebit
        {
            get { return fGroYtdDebit; }
            set { SetPropertyValue<int>("GroYtdDebit", ref fGroYtdDebit, value); }
        }
        string fGroYtdDesc;
        [Size(75)]
        public string GroYtdDesc
        {
            get { return fGroYtdDesc; }
            set { SetPropertyValue<string>("GroYtdDesc", ref fGroYtdDesc, value); }
        }
        string fGroYtdCompanyLocation;
        [Size(10)]
        public string GroYtdCompanyLocation
        {
            get { return fGroYtdCompanyLocation; }
            set { SetPropertyValue<string>("GroYtdCompanyLocation", ref fGroYtdCompanyLocation, value); }
        }
        decimal fGroYtdStoreCost;
        public decimal GroYtdStoreCost
        {
            get { return fGroYtdStoreCost; }
            set { SetPropertyValue<decimal>("GroYtdStoreCost", ref fGroYtdStoreCost, value); }
        }
        decimal fGroYtdDryCost;
        public decimal GroYtdDryCost
        {
            get { return fGroYtdDryCost; }
            set { SetPropertyValue<decimal>("GroYtdDryCost", ref fGroYtdDryCost, value); }
        }
        decimal fGroYtdOtherCost;
        public decimal GroYtdOtherCost
        {
            get { return fGroYtdOtherCost; }
            set { SetPropertyValue<decimal>("GroYtdOtherCost", ref fGroYtdOtherCost, value); }
        }
        decimal fGroYtdPaidDate;
        public decimal GroYtdPaidDate
        {
            get { return fGroYtdPaidDate; }
            set { SetPropertyValue<decimal>("GroYtdPaidDate", ref fGroYtdPaidDate, value); }
        }
        bool fGroYtdPaidFull;
        public bool GroYtdPaidFull
        {
            get { return fGroYtdPaidFull; }
            set { SetPropertyValue<bool>("GroYtdPaidFull", ref fGroYtdPaidFull, value); }
        }
        DateTime fGroYtdPayReceive;
        public DateTime GroYtdPayReceive
        {
            get { return fGroYtdPayReceive; }
            set { SetPropertyValue<DateTime>("GroYtdPayReceive", ref fGroYtdPayReceive, value); }
        }
        double fGroYtdHead;
        public double GroYtdHead
        {
            get { return fGroYtdHead; }
            set { SetPropertyValue<double>("GroYtdHead", ref fGroYtdHead, value); }
        }
        double fGroYtdTotal;
        public double GroYtdTotal
        {
            get { return fGroYtdTotal; }
            set { SetPropertyValue<double>("GroYtdTotal", ref fGroYtdTotal, value); }
        }
        string fGroYtdPsr;
        [Size(10)]
        public string GroYtdPsr
        {
            get { return fGroYtdPsr; }
            set { SetPropertyValue<string>("GroYtdPsr", ref fGroYtdPsr, value); }
        }
        string fGroYtdInvoiceNumber;
        [Size(12)]
        public string GroYtdInvoiceNumber
        {
            get { return fGroYtdInvoiceNumber; }
            set { SetPropertyValue<string>("GroYtdInvoiceNumber", ref fGroYtdInvoiceNumber, value); }
        }
        string fGroYtdReceiptNumber;
        [Size(12)]
        public string GroYtdReceiptNumber
        {
            get { return fGroYtdReceiptNumber; }
            set { SetPropertyValue<string>("GroYtdReceiptNumber", ref fGroYtdReceiptNumber, value); }
        }
        DateTime fGroYtdReceiveDate;
        public DateTime GroYtdReceiveDate
        {
            get { return fGroYtdReceiveDate; }
            set { SetPropertyValue<DateTime>("GroYtdReceiveDate", ref fGroYtdReceiveDate, value); }
        }
        DateTime fGroYtdRedeemDate;
        public DateTime GroYtdRedeemDate
        {
            get { return fGroYtdRedeemDate; }
            set { SetPropertyValue<DateTime>("GroYtdRedeemDate", ref fGroYtdRedeemDate, value); }
        }
        string fGroYtdOriginalLotNumber;
        [Size(15)]
        public string GroYtdOriginalLotNumber
        {
            get { return fGroYtdOriginalLotNumber; }
            set { SetPropertyValue<string>("GroYtdOriginalLotNumber", ref fGroYtdOriginalLotNumber, value); }
        }
        string fGroYtdNotes;
        [Size(50)]
        public string GroYtdNotes
        {
            get { return fGroYtdNotes; }
            set { SetPropertyValue<string>("GroYtdNotes", ref fGroYtdNotes, value); }
        }
        int fGroYtdBankIncrement;
        public int GroYtdBankIncrement
        {
            get { return fGroYtdBankIncrement; }
            set { SetPropertyValue<int>("GroYtdBankIncrement", ref fGroYtdBankIncrement, value); }
        }
        int fGroYtdBankDecrement;
        public int GroYtdBankDecrement
        {
            get { return fGroYtdBankDecrement; }
            set { SetPropertyValue<int>("GroYtdBankDecrement", ref fGroYtdBankDecrement, value); }
        }
        int fGroYtdComUNIncrement;
        public int GroYtdComUNIncrement
        {
            get { return fGroYtdComUNIncrement; }
            set { SetPropertyValue<int>("GroYtdComUNIncrement", ref fGroYtdComUNIncrement, value); }
        }
        int fGroYtdComUNDecrement;
        public int GroYtdComUNDecrement
        {
            get { return fGroYtdComUNDecrement; }
            set { SetPropertyValue<int>("GroYtdComUNDecrement", ref fGroYtdComUNDecrement, value); }
        }
        int fGroYtdComPDIncrement;
        public int GroYtdComPDIncrement
        {
            get { return fGroYtdComPDIncrement; }
            set { SetPropertyValue<int>("GroYtdComPDIncrement", ref fGroYtdComPDIncrement, value); }
        }
        int fGroYtdComPDDecrement;
        public int GroYtdComPDDecrement
        {
            get { return fGroYtdComPDDecrement; }
            set { SetPropertyValue<int>("GroYtdComPDDecrement", ref fGroYtdComPDDecrement, value); }
        }
    }

}
