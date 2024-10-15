// Decompiled with JetBrains decompiler
// Type: SRPG.ExpansionPurchaseQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ADC")]
  public class ExpansionPurchaseQuest
  {
    [Token(Token = "0x40063A7")]
    [FieldOffset(Offset = "0x8")]
    private string mAreaIname;
    [Token(Token = "0x40063A8")]
    [FieldOffset(Offset = "0xC")]
    private string mQuestIname;

    [Token(Token = "0x17000C8A")]
    public string AreaIname
    {
      [Token(Token = "0x6006EA8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C8B")]
    public string QuestIname
    {
      [Token(Token = "0x6006EA9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006EAA")]
    [Address(RVA = "0x362350", Offset = "0x361150", VA = "0x10362350")]
    public bool Deserialize(JSON_ExpansionPurchaseQuest json) => new bool();

    [Token(Token = "0x6006EAB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExpansionPurchaseQuest()
    {
    }
  }
}
