// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustPlayStorePurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036DD")]
  public class AdjustPlayStorePurchase
  {
    [Token(Token = "0x4010219")]
    [FieldOffset(Offset = "0x8")]
    internal string productId;
    [Token(Token = "0x401021A")]
    [FieldOffset(Offset = "0xC")]
    internal string purchaseToken;

    [Token(Token = "0x600F910")]
    [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
    public AdjustPlayStorePurchase(string productId, string purchaseToken)
    {
    }
  }
}
