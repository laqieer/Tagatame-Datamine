// Decompiled with JetBrains decompiler
// Type: SRPG.ExpansionPurchaseQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ADD")]
  public class ExpansionPurchaseQuestParam
  {
    [Token(Token = "0x40063A9")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40063AA")]
    [FieldOffset(Offset = "0xC")]
    private System.Collections.Generic.List<ExpansionPurchaseQuest> mList;

    [Token(Token = "0x17000C8C")]
    public string Iname
    {
      [Token(Token = "0x6006EAC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C8D")]
    public System.Collections.Generic.List<ExpansionPurchaseQuest> List
    {
      [Token(Token = "0x6006EAD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (System.Collections.Generic.List<ExpansionPurchaseQuest>) null;
      }
    }

    [Token(Token = "0x6006EAE")]
    [Address(RVA = "0x361F50", Offset = "0x360D50", VA = "0x10361F50")]
    public bool Deserialize(JSON_ExpansionPurchaseQuestParam json) => new bool();

    [Token(Token = "0x6006EAF")]
    [Address(RVA = "0x361CB0", Offset = "0x360AB0", VA = "0x10361CB0")]
    public static void Deserialize(
      ref System.Collections.Generic.List<ExpansionPurchaseQuestParam> ref_params,
      JSON_ExpansionPurchaseQuestParam[] json)
    {
    }

    [Token(Token = "0x6006EB0")]
    [Address(RVA = "0x3620C0", Offset = "0x360EC0", VA = "0x103620C0")]
    public bool IsIncludeQuest(string _quest_iname) => new bool();

    [Token(Token = "0x6006EB1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExpansionPurchaseQuestParam()
    {
    }
  }
}
