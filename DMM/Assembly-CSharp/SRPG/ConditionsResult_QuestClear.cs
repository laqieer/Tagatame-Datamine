// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult_QuestClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EA7")]
  public class ConditionsResult_QuestClear : ConditionsResult
  {
    [Token(Token = "0x4002CF9")]
    [FieldOffset(Offset = "0x14")]
    private QuestParam mQuestParam;

    [Token(Token = "0x170004D2")]
    public override string text
    {
      [Token(Token = "0x6003CF8"), Address(RVA = "0x10F4150", Offset = "0x10F2F50", VA = "0x110F4150", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004D3")]
    public override string errorText
    {
      [Token(Token = "0x6003CF9"), Address(RVA = "0x10F4100", Offset = "0x10F2F00", VA = "0x110F4100", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003CFA")]
    [Address(RVA = "0x10F40B0", Offset = "0x10F2EB0", VA = "0x110F40B0")]
    public ConditionsResult_QuestClear(QuestParam questParam)
    {
    }
  }
}
