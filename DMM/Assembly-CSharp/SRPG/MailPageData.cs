// Decompiled with JetBrains decompiler
// Type: SRPG.MailPageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001045")]
  public class MailPageData
  {
    [Token(Token = "0x4003A10")]
    [FieldOffset(Offset = "0x8")]
    public List<MailData> mails;
    [Token(Token = "0x4003A11")]
    [FieldOffset(Offset = "0xC")]
    public bool hasNext;
    [Token(Token = "0x4003A12")]
    [FieldOffset(Offset = "0xD")]
    public bool hasPrev;
    [Token(Token = "0x4003A13")]
    [FieldOffset(Offset = "0x10")]
    public int page;
    [Token(Token = "0x4003A14")]
    [FieldOffset(Offset = "0x14")]
    public int pageMax;
    [Token(Token = "0x4003A15")]
    [FieldOffset(Offset = "0x18")]
    public int mailCount;

    [Token(Token = "0x60042CB")]
    [Address(RVA = "0x11DE240", Offset = "0x11DD040", VA = "0x111DE240")]
    public void Deserialize(Json_Mail[] mailArray)
    {
    }

    [Token(Token = "0x60042CC")]
    [Address(RVA = "0x11DE200", Offset = "0x11DD000", VA = "0x111DE200")]
    public void Deserialize(Json_MailOption mailOption)
    {
    }

    [Token(Token = "0x60042CD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MailPageData()
    {
    }
  }
}
