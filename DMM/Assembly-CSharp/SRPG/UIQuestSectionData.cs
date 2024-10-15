// Decompiled with JetBrains decompiler
// Type: SRPG.UIQuestSectionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028C7")]
  public class UIQuestSectionData
  {
    [Token(Token = "0x400C380")]
    [FieldOffset(Offset = "0x8")]
    private SectionParam mParam;

    [Token(Token = "0x600B85A")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public UIQuestSectionData(SectionParam param)
    {
    }

    [Token(Token = "0x1700192C")]
    public string Name
    {
      [Token(Token = "0x600B85B"), Address(RVA = "0x805480", Offset = "0x804280", VA = "0x10805480")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700192D")]
    public string SectionID
    {
      [Token(Token = "0x600B85C"), Address(RVA = "0x8054A0", Offset = "0x8042A0", VA = "0x108054A0")] get
      {
        return (string) null;
      }
    }
  }
}
