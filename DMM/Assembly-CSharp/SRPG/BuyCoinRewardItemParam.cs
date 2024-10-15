// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinRewardItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A3C")]
  public class BuyCoinRewardItemParam
  {
    [Token(Token = "0x4006098")]
    [FieldOffset(Offset = "0x8")]
    public BuyCoinManager.PremiumRewadType Type;
    [Token(Token = "0x4006099")]
    [FieldOffset(Offset = "0xC")]
    public string Iname;
    [Token(Token = "0x400609A")]
    [FieldOffset(Offset = "0x10")]
    public int Num;

    [Token(Token = "0x6006BE4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinRewardItemParam()
    {
    }
  }
}
