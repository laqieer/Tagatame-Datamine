// Decompiled with JetBrains decompiler
// Type: SRPG.RentalQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E9B")]
  public class RentalQuestInfo
  {
    [Token(Token = "0x4007FFA")]
    [FieldOffset(Offset = "0x8")]
    public string QuestId;
    [Token(Token = "0x4007FFB")]
    [FieldOffset(Offset = "0xC")]
    public OInt Point;
    [Token(Token = "0x4007FFC")]
    [FieldOffset(Offset = "0x20")]
    private QuestParam mQuestParam;

    [Token(Token = "0x1700118D")]
    public QuestParam Quest
    {
      [Token(Token = "0x6007D8D"), Address(RVA = "0x3EC490", Offset = "0x3EB290", VA = "0x103EC490")] get
      {
        return (QuestParam) null;
      }
    }

    [Token(Token = "0x6007D8E")]
    [Address(RVA = "0x3EC430", Offset = "0x3EB230", VA = "0x103EC430")]
    public RentalQuestInfo(string quest_id, int point)
    {
    }
  }
}
