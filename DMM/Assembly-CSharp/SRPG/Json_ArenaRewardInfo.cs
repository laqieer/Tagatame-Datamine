// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaRewardInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E52")]
  public class Json_ArenaRewardInfo
  {
    [Token(Token = "0x4002BA0")]
    [FieldOffset(Offset = "0x8")]
    public int gold;
    [Token(Token = "0x4002BA1")]
    [FieldOffset(Offset = "0xC")]
    public int coin;
    [Token(Token = "0x4002BA2")]
    [FieldOffset(Offset = "0x10")]
    public int arenacoin;
    [Token(Token = "0x4002BA3")]
    [FieldOffset(Offset = "0x14")]
    public Json_Item[] items;

    [Token(Token = "0x6003B0C")]
    [Address(RVA = "0x10DDFB0", Offset = "0x10DCDB0", VA = "0x110DDFB0")]
    public bool IsReward() => new bool();

    [Token(Token = "0x6003B0D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaRewardInfo()
    {
    }
  }
}
