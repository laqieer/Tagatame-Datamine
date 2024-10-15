// Decompiled with JetBrains decompiler
// Type: SRPG.MailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001044")]
  public class MailData
  {
    [Token(Token = "0x4003A0A")]
    [FieldOffset(Offset = "0x8")]
    public long mid;
    [Token(Token = "0x4003A0B")]
    [FieldOffset(Offset = "0x10")]
    public string msg;
    [Token(Token = "0x4003A0C")]
    [FieldOffset(Offset = "0x14")]
    public GiftData[] gifts;
    [Token(Token = "0x4003A0D")]
    [FieldOffset(Offset = "0x18")]
    public long read;
    [Token(Token = "0x4003A0E")]
    [FieldOffset(Offset = "0x20")]
    public long post_at;
    [Token(Token = "0x4003A0F")]
    [FieldOffset(Offset = "0x28")]
    public int period;

    [Token(Token = "0x60042C5")]
    [Address(RVA = "0x11DDC30", Offset = "0x11DCA30", VA = "0x111DDC30")]
    public bool Deserialize(Json_Mail json) => new bool();

    [Token(Token = "0x17000624")]
    public bool IsPeriod
    {
      [Token(Token = "0x60042C6"), Address(RVA = "0x59D8E0", Offset = "0x59C6E0", VA = "0x1059D8E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60042C7")]
    [Address(RVA = "0x11DE1E0", Offset = "0x11DCFE0", VA = "0x111DE1E0")]
    public bool IsReadMail() => new bool();

    [Token(Token = "0x60042C8")]
    [Address(RVA = "0x11DDBC0", Offset = "0x11DC9C0", VA = "0x111DDBC0")]
    public bool Contains(GiftTypes giftType) => new bool();

    [Token(Token = "0x60042C9")]
    [Address(RVA = "0x11DE160", Offset = "0x11DCF60", VA = "0x111DE160")]
    public GiftData Find(GiftTypes giftType) => (GiftData) null;

    [Token(Token = "0x60042CA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MailData()
    {
    }
  }
}
