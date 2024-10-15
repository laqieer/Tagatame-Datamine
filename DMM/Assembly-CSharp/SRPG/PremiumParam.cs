// Decompiled with JetBrains decompiler
// Type: SRPG.PremiumParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C1B")]
  public class PremiumParam
  {
    [Token(Token = "0x4006CE0")]
    [FieldOffset(Offset = "0x8")]
    public string m_Iname;
    [Token(Token = "0x4006CE1")]
    [FieldOffset(Offset = "0xC")]
    public string m_Image;
    [Token(Token = "0x4006CE2")]
    [FieldOffset(Offset = "0x10")]
    public long m_BeginAt;
    [Token(Token = "0x4006CE3")]
    [FieldOffset(Offset = "0x18")]
    public long m_EndAt;
    [Token(Token = "0x4006CE4")]
    [FieldOffset(Offset = "0x20")]
    public int m_Span;
    [Token(Token = "0x4006CE5")]
    [FieldOffset(Offset = "0x24")]
    private string mPremiumProduct;
    [Token(Token = "0x4006CE6")]
    [FieldOffset(Offset = "0x28")]
    private string mTableID;
    [Token(Token = "0x4006CE7")]
    [FieldOffset(Offset = "0x2C")]
    private int mType;

    [Token(Token = "0x17000E86")]
    public string PremiumProduct
    {
      [Token(Token = "0x60073CA"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E87")]
    public string TableID
    {
      [Token(Token = "0x60073CB"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E88")]
    public int Type
    {
      [Token(Token = "0x60073CC"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60073CD")]
    [Address(RVA = "0x37F930", Offset = "0x37E730", VA = "0x1037F930")]
    public bool Deserialize(JSON_PremiumParam json) => new bool();

    [Token(Token = "0x60073CE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PremiumParam()
    {
    }
  }
}
