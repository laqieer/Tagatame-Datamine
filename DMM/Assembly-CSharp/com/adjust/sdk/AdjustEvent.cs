// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036D8")]
  public class AdjustEvent
  {
    [Token(Token = "0x40101F8")]
    [FieldOffset(Offset = "0x8")]
    internal string currency;
    [Token(Token = "0x40101F9")]
    [FieldOffset(Offset = "0xC")]
    internal string eventToken;
    [Token(Token = "0x40101FA")]
    [FieldOffset(Offset = "0x10")]
    internal string callbackId;
    [Token(Token = "0x40101FB")]
    [FieldOffset(Offset = "0x14")]
    internal string transactionId;
    [Token(Token = "0x40101FC")]
    [FieldOffset(Offset = "0x18")]
    internal string productId;
    [Token(Token = "0x40101FD")]
    [FieldOffset(Offset = "0x20")]
    internal double? revenue;
    [Token(Token = "0x40101FE")]
    [FieldOffset(Offset = "0x30")]
    internal List<string> partnerList;
    [Token(Token = "0x40101FF")]
    [FieldOffset(Offset = "0x34")]
    internal List<string> callbackList;
    [Token(Token = "0x4010200")]
    [FieldOffset(Offset = "0x38")]
    internal string receipt;
    [Token(Token = "0x4010201")]
    [FieldOffset(Offset = "0x3C")]
    internal string receiptBase64;
    [Token(Token = "0x4010202")]
    [FieldOffset(Offset = "0x40")]
    internal bool isReceiptSet;
    [Token(Token = "0x4010203")]
    [FieldOffset(Offset = "0x44")]
    internal string purchaseToken;

    [Token(Token = "0x600F8DF")]
    [Address(RVA = "0xB67A90", Offset = "0xB66890", VA = "0x10B67A90")]
    public AdjustEvent(string eventToken)
    {
    }

    [Token(Token = "0x600F8E0")]
    [Address(RVA = "0xB67C20", Offset = "0xB66A20", VA = "0x10B67C20")]
    public void setRevenue(double amount, string currency)
    {
    }

    [Token(Token = "0x600F8E1")]
    [Address(RVA = "0xB67AC0", Offset = "0xB668C0", VA = "0x10B67AC0")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x600F8E2")]
    [Address(RVA = "0xB67B70", Offset = "0xB66970", VA = "0x10B67B70")]
    public void addPartnerParameter(string key, string value)
    {
    }

    [Token(Token = "0x600F8E3")]
    [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
    public void setCallbackId(string callbackId)
    {
    }

    [Token(Token = "0x600F8E4")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void setTransactionId(string transactionId)
    {
    }

    [Token(Token = "0x600F8E5")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void setProductId(string productId)
    {
    }

    [Token(Token = "0x600F8E6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    [Obsolete("This is an obsolete method. Please use separate setter methods for purchase verification parameters.")]
    public void setReceipt(string receipt, string transactionId)
    {
    }

    [Token(Token = "0x600F8E7")]
    [Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")]
    public void setReceipt(string receipt)
    {
    }

    [Token(Token = "0x600F8E8")]
    [Address(RVA = "0x36F610", Offset = "0x36E410", VA = "0x1036F610")]
    public void setReceiptBase64(string receiptBase64)
    {
    }

    [Token(Token = "0x600F8E9")]
    [Address(RVA = "0x2886E0", Offset = "0x2874E0", VA = "0x102886E0")]
    public void setPurchaseToken(string purchaseToken)
    {
    }
  }
}
