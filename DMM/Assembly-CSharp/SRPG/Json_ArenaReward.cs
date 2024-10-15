// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E57")]
  public class Json_ArenaReward
  {
    [Token(Token = "0x4002BB6")]
    [FieldOffset(Offset = "0x8")]
    public long day;
    [Token(Token = "0x4002BB7")]
    [FieldOffset(Offset = "0x10")]
    public Json_ArenaRewardInfo rank;
    [Token(Token = "0x4002BB8")]
    [FieldOffset(Offset = "0x14")]
    public Json_ArenaRewardInfo defense;

    [Token(Token = "0x6003B13")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaReward()
    {
    }
  }
}
