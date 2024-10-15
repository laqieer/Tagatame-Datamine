// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BtlQuestRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DAB")]
  public class Json_BtlQuestRanking
  {
    [Token(Token = "0x4002782")]
    [FieldOffset(Offset = "0x8")]
    public int is_new_score;
    [Token(Token = "0x4002783")]
    [FieldOffset(Offset = "0xC")]
    public int is_join_reward;
    [Token(Token = "0x4002784")]
    [FieldOffset(Offset = "0x10")]
    public int rank;

    [Token(Token = "0x170003C4")]
    public bool IsNewScore
    {
      [Token(Token = "0x600375D"), Address(RVA = "0x4F7530", Offset = "0x4F6330", VA = "0x104F7530")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003C5")]
    public bool IsJoinReward
    {
      [Token(Token = "0x600375E"), Address(RVA = "0x7C1EC0", Offset = "0x7C0CC0", VA = "0x107C1EC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600375F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BtlQuestRanking()
    {
    }
  }
}
