// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrophyObjective
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D88")]
  public class GuildTrophyObjective : TrophyObjective
  {
    [Token(Token = "0x40074DA")]
    [FieldOffset(Offset = "0x1C")]
    public GuildTrophyConditionTypes type;

    [Token(Token = "0x17001046")]
    public new int RequiredCount
    {
      [Token(Token = "0x60078CD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60078CE")]
    [Address(RVA = "0x3A1EC0", Offset = "0x3A0CC0", VA = "0x103A1EC0", Slot = "4")]
    public override string GetDescription() => (string) null;

    [Token(Token = "0x60078CF")]
    [Address(RVA = "0x3A2C60", Offset = "0x3A1A60", VA = "0x103A2C60")]
    private string GetQuestDifficultName(QuestDifficulties qdiff) => (string) null;

    [Token(Token = "0x60078D0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrophyObjective()
    {
    }
  }
}
