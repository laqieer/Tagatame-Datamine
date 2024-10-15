// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustAppStoreSubscription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036D3")]
  public class AdjustAppStoreSubscription
  {
    [Token(Token = "0x40101A3")]
    [FieldOffset(Offset = "0x8")]
    internal string price;
    [Token(Token = "0x40101A4")]
    [FieldOffset(Offset = "0xC")]
    internal string currency;
    [Token(Token = "0x40101A5")]
    [FieldOffset(Offset = "0x10")]
    internal string transactionId;
    [Token(Token = "0x40101A6")]
    [FieldOffset(Offset = "0x14")]
    internal string receipt;
    [Token(Token = "0x40101A7")]
    [FieldOffset(Offset = "0x18")]
    internal string billingStore;
    [Token(Token = "0x40101A8")]
    [FieldOffset(Offset = "0x1C")]
    internal string transactionDate;
    [Token(Token = "0x40101A9")]
    [FieldOffset(Offset = "0x20")]
    internal string salesRegion;
    [Token(Token = "0x40101AA")]
    [FieldOffset(Offset = "0x24")]
    internal List<string> partnerList;
    [Token(Token = "0x40101AB")]
    [FieldOffset(Offset = "0x28")]
    internal List<string> callbackList;

    [Token(Token = "0x600F890")]
    [Address(RVA = "0x6DE410", Offset = "0x6DD210", VA = "0x106DE410")]
    public AdjustAppStoreSubscription(
      string price,
      string currency,
      string transactionId,
      string receipt)
    {
    }

    [Token(Token = "0x600F891")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void setTransactionDate(string transactionDate)
    {
    }

    [Token(Token = "0x600F892")]
    [Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")]
    public void setSalesRegion(string salesRegion)
    {
    }

    [Token(Token = "0x600F893")]
    [Address(RVA = "0xB65260", Offset = "0xB64060", VA = "0x10B65260")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x600F894")]
    [Address(RVA = "0xB65310", Offset = "0xB64110", VA = "0x10B65310")]
    public void addPartnerParameter(string key, string value)
    {
    }
  }
}
