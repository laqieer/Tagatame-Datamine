// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustPlayStoreSubscription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036DE")]
  public class AdjustPlayStoreSubscription
  {
    [Token(Token = "0x401021B")]
    [FieldOffset(Offset = "0x8")]
    internal string price;
    [Token(Token = "0x401021C")]
    [FieldOffset(Offset = "0xC")]
    internal string currency;
    [Token(Token = "0x401021D")]
    [FieldOffset(Offset = "0x10")]
    internal string sku;
    [Token(Token = "0x401021E")]
    [FieldOffset(Offset = "0x14")]
    internal string orderId;
    [Token(Token = "0x401021F")]
    [FieldOffset(Offset = "0x18")]
    internal string signature;
    [Token(Token = "0x4010220")]
    [FieldOffset(Offset = "0x1C")]
    internal string purchaseToken;
    [Token(Token = "0x4010221")]
    [FieldOffset(Offset = "0x20")]
    internal string billingStore;
    [Token(Token = "0x4010222")]
    [FieldOffset(Offset = "0x24")]
    internal string purchaseTime;
    [Token(Token = "0x4010223")]
    [FieldOffset(Offset = "0x28")]
    internal List<string> partnerList;
    [Token(Token = "0x4010224")]
    [FieldOffset(Offset = "0x2C")]
    internal List<string> callbackList;

    [Token(Token = "0x600F911")]
    [Address(RVA = "0xB67E30", Offset = "0xB66C30", VA = "0x10B67E30")]
    public AdjustPlayStoreSubscription(
      string price,
      string currency,
      string sku,
      string orderId,
      string signature,
      string purchaseToken)
    {
    }

    [Token(Token = "0x600F912")]
    [Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")]
    public void setPurchaseTime(string purchaseTime)
    {
    }

    [Token(Token = "0x600F913")]
    [Address(RVA = "0xB67EA0", Offset = "0xB66CA0", VA = "0x10B67EA0")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x600F914")]
    [Address(RVA = "0xB67F50", Offset = "0xB66D50", VA = "0x10B67F50")]
    public void addPartnerParameter(string key, string value)
    {
    }
  }
}
