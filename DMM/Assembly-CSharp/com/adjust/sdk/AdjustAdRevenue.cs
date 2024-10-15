// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustAdRevenue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036D1")]
  public class AdjustAdRevenue
  {
    [Token(Token = "0x4010197")]
    [FieldOffset(Offset = "0x8")]
    internal string source;
    [Token(Token = "0x4010198")]
    [FieldOffset(Offset = "0x10")]
    internal double? revenue;
    [Token(Token = "0x4010199")]
    [FieldOffset(Offset = "0x20")]
    internal string currency;
    [Token(Token = "0x401019A")]
    [FieldOffset(Offset = "0x24")]
    internal int? adImpressionsCount;
    [Token(Token = "0x401019B")]
    [FieldOffset(Offset = "0x2C")]
    internal string adRevenueNetwork;
    [Token(Token = "0x401019C")]
    [FieldOffset(Offset = "0x30")]
    internal string adRevenueUnit;
    [Token(Token = "0x401019D")]
    [FieldOffset(Offset = "0x34")]
    internal string adRevenuePlacement;
    [Token(Token = "0x401019E")]
    [FieldOffset(Offset = "0x38")]
    internal List<string> partnerList;
    [Token(Token = "0x401019F")]
    [FieldOffset(Offset = "0x3C")]
    internal List<string> callbackList;

    [Token(Token = "0x600F887")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public AdjustAdRevenue(string source)
    {
    }

    [Token(Token = "0x600F888")]
    [Address(RVA = "0xB651F0", Offset = "0xB63FF0", VA = "0x10B651F0")]
    public void setRevenue(double amount, string currency)
    {
    }

    [Token(Token = "0x600F889")]
    [Address(RVA = "0xB65190", Offset = "0xB63F90", VA = "0x10B65190")]
    public void setAdImpressionsCount(int adImpressionsCount)
    {
    }

    [Token(Token = "0x600F88A")]
    [Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")]
    public void setAdRevenueNetwork(string adRevenueNetwork)
    {
    }

    [Token(Token = "0x600F88B")]
    [Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")]
    public void setAdRevenueUnit(string adRevenueUnit)
    {
    }

    [Token(Token = "0x600F88C")]
    [Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")]
    public void setAdRevenuePlacement(string adRevenuePlacement)
    {
    }

    [Token(Token = "0x600F88D")]
    [Address(RVA = "0xB65030", Offset = "0xB63E30", VA = "0x10B65030")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x600F88E")]
    [Address(RVA = "0xB650E0", Offset = "0xB63EE0", VA = "0x10B650E0")]
    public void addPartnerParameter(string key, string value)
    {
    }
  }
}
