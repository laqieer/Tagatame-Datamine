// Decompiled with JetBrains decompiler
// Type: SRPG.ExpansionPurchaseType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AD7")]
  public class ExpansionPurchaseType
  {
    [Token(Token = "0x400639B")]
    [FieldOffset(Offset = "0x8")]
    private ExpansionPurchaseParam.eType mType;
    [Token(Token = "0x400639C")]
    [FieldOffset(Offset = "0xC")]
    private int mValue;
    [Token(Token = "0x400639D")]
    [FieldOffset(Offset = "0x10")]
    private ExpansionPurchaseParam.eQuestType mQuestType;
    [Token(Token = "0x400639E")]
    [FieldOffset(Offset = "0x14")]
    private string mQuestsId;

    [Token(Token = "0x17000C83")]
    public ExpansionPurchaseParam.eType Type
    {
      [Token(Token = "0x6006E91"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new ExpansionPurchaseParam.eType();
      }
    }

    [Token(Token = "0x17000C84")]
    public int Value
    {
      [Token(Token = "0x6006E92"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C85")]
    public ExpansionPurchaseParam.eQuestType QuestType
    {
      [Token(Token = "0x6006E93"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new ExpansionPurchaseParam.eQuestType();
      }
    }

    [Token(Token = "0x17000C86")]
    public string QuestsId
    {
      [Token(Token = "0x6006E94"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006E95")]
    [Address(RVA = "0x362390", Offset = "0x361190", VA = "0x10362390")]
    public bool Deserialize(JSON_ExpansionPurchaseType json) => new bool();

    [Token(Token = "0x6006E96")]
    [Address(RVA = "0x3625B0", Offset = "0x3613B0", VA = "0x103625B0")]
    public bool IsIncludeQuest(string _quest_iname) => new bool();

    [Token(Token = "0x6006E97")]
    [Address(RVA = "0x3623D0", Offset = "0x3611D0", VA = "0x103623D0")]
    public bool IsIncludeQuestType(string _iname) => new bool();

    [Token(Token = "0x6006E98")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExpansionPurchaseType()
    {
    }
  }
}
