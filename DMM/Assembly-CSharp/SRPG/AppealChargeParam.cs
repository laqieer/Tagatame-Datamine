// Decompiled with JetBrains decompiler
// Type: SRPG.AppealChargeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023B8")]
  public class AppealChargeParam
  {
    [Token(Token = "0x400A150")]
    [FieldOffset(Offset = "0x8")]
    public string m_AppealId;
    [Token(Token = "0x400A151")]
    [FieldOffset(Offset = "0xC")]
    public string m_BeforeImg;
    [Token(Token = "0x400A152")]
    [FieldOffset(Offset = "0x10")]
    public string m_AfterImg;
    [Token(Token = "0x400A153")]
    [FieldOffset(Offset = "0x18")]
    public long m_StartAt;
    [Token(Token = "0x400A154")]
    [FieldOffset(Offset = "0x20")]
    public long m_EndAt;

    [Token(Token = "0x17001574")]
    public string appeal_id
    {
      [Token(Token = "0x6009A8A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001575")]
    public string before_img
    {
      [Token(Token = "0x6009A8B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001576")]
    public string after_img
    {
      [Token(Token = "0x6009A8C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001577")]
    public long start_at
    {
      [Token(Token = "0x6009A8D"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001578")]
    public long end_at
    {
      [Token(Token = "0x6009A8E"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6009A8F")]
    [Address(RVA = "0x5E06E0", Offset = "0x5DF4E0", VA = "0x105E06E0")]
    public AppealChargeParam()
    {
    }

    [Token(Token = "0x6009A90")]
    [Address(RVA = "0x5E0480", Offset = "0x5DF280", VA = "0x105E0480")]
    public void Deserialize(JSON_AppealChargeParam _json)
    {
    }
  }
}
