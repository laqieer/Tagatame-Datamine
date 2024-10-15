// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C8F")]
  public class RankingQuestRewardParam
  {
    [Token(Token = "0x4007031")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4007032")]
    [FieldOffset(Offset = "0xC")]
    public RankingQuestRewardType type;
    [Token(Token = "0x4007033")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4007034")]
    [FieldOffset(Offset = "0x14")]
    public int num;

    [Token(Token = "0x60075B0")]
    [Address(RVA = "0x393DE0", Offset = "0x392BE0", VA = "0x10393DE0")]
    public bool Deserialize(JSON_RankingQuestRewardParam json) => new bool();

    [Token(Token = "0x60075B1")]
    [Address(RVA = "0x393F90", Offset = "0x392D90", VA = "0x10393F90")]
    public static RankingQuestRewardParam FindByID(int id) => (RankingQuestRewardParam) null;

    [Token(Token = "0x60075B2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankingQuestRewardParam()
    {
    }
  }
}
