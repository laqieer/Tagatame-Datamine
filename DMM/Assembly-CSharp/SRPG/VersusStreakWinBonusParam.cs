// Decompiled with JetBrains decompiler
// Type: SRPG.VersusStreakWinBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EE1")]
  public class VersusStreakWinBonusParam
  {
    [Token(Token = "0x40081E0")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40081E1")]
    [FieldOffset(Offset = "0xC")]
    public int wincnt;
    [Token(Token = "0x40081E2")]
    [FieldOffset(Offset = "0x10")]
    public VersusWinBonusRewardParam[] rewards;

    [Token(Token = "0x6007E49")]
    [Address(RVA = "0x3FBB70", Offset = "0x3FA970", VA = "0x103FBB70")]
    public bool Deserialize(JSON_VersusStreakWinBonus json) => new bool();

    [Token(Token = "0x6007E4A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusStreakWinBonusParam()
    {
    }
  }
}
