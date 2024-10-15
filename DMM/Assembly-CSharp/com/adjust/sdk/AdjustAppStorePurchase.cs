// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustAppStorePurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036D2")]
  public class AdjustAppStorePurchase
  {
    [Token(Token = "0x40101A0")]
    [FieldOffset(Offset = "0x8")]
    internal string transactionId;
    [Token(Token = "0x40101A1")]
    [FieldOffset(Offset = "0xC")]
    internal string productId;
    [Token(Token = "0x40101A2")]
    [FieldOffset(Offset = "0x10")]
    internal string receipt;

    [Token(Token = "0x600F88F")]
    [Address(RVA = "0x42CC30", Offset = "0x42BA30", VA = "0x1042CC30")]
    public AdjustAppStorePurchase(string transactionId, string productId, string receipt)
    {
    }
  }
}
