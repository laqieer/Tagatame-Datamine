// Decompiled with JetBrains decompiler
// Type: SRPG.ExpansionPurchaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AD9")]
  public class ExpansionPurchaseData
  {
    [Token(Token = "0x40063A0")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40063A1")]
    [FieldOffset(Offset = "0x10")]
    private long mExpiredAt;
    [Token(Token = "0x40063A2")]
    [FieldOffset(Offset = "0x18")]
    private ExpansionPurchaseParam mParam;

    [Token(Token = "0x17000C87")]
    public string iname
    {
      [Token(Token = "0x6006E9E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C88")]
    public long expired_at
    {
      [Token(Token = "0x6006E9F"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000C89")]
    public ExpansionPurchaseParam param
    {
      [Token(Token = "0x6006EA0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (ExpansionPurchaseParam) null;
      }
    }

    [Token(Token = "0x6006EA1")]
    [Address(RVA = "0x360F50", Offset = "0x35FD50", VA = "0x10360F50")]
    public void Deserialize(Json_ExpansionPurchase json)
    {
    }

    [Token(Token = "0x6006EA2")]
    [Address(RVA = "0x361160", Offset = "0x35FF60", VA = "0x10361160")]
    public bool IsExpansionPurchaseType(ExpansionPurchaseParam.eType _type) => new bool();

    [Token(Token = "0x6006EA3")]
    [Address(RVA = "0x361090", Offset = "0x35FE90", VA = "0x10361090")]
    public bool IsExpansionPurchaseTypeAndValue(ExpansionPurchaseParam.eType _type, int _value)
    {
      return new bool();
    }

    [Token(Token = "0x6006EA4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExpansionPurchaseData()
    {
    }
  }
}
