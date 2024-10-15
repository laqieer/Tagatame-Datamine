// Decompiled with JetBrains decompiler
// Type: SRPG.ChatLogParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002181")]
  public class ChatLogParam
  {
    [Token(Token = "0x400926F")]
    [FieldOffset(Offset = "0x8")]
    public long id;
    [Token(Token = "0x4009270")]
    [FieldOffset(Offset = "0x10")]
    public byte message_type;
    [Token(Token = "0x4009271")]
    [FieldOffset(Offset = "0x14")]
    public string fuid;
    [Token(Token = "0x4009272")]
    [FieldOffset(Offset = "0x18")]
    public string uid;
    [Token(Token = "0x4009273")]
    [FieldOffset(Offset = "0x1C")]
    public string icon;
    [Token(Token = "0x4009274")]
    [FieldOffset(Offset = "0x20")]
    public string skin_iname;
    [Token(Token = "0x4009275")]
    [FieldOffset(Offset = "0x24")]
    public string job_iname;
    [Token(Token = "0x4009276")]
    [FieldOffset(Offset = "0x28")]
    public string message;
    [Token(Token = "0x4009277")]
    [FieldOffset(Offset = "0x2C")]
    public int stamp_id;
    [Token(Token = "0x4009278")]
    [FieldOffset(Offset = "0x30")]
    public string name;
    [Token(Token = "0x4009279")]
    [FieldOffset(Offset = "0x38")]
    public long posted_at;
    [Token(Token = "0x400927A")]
    [FieldOffset(Offset = "0x40")]
    public long gid;
    [Token(Token = "0x400927B")]
    [FieldOffset(Offset = "0x48")]
    public string guild_name;
    [Token(Token = "0x400927C")]
    [FieldOffset(Offset = "0x4C")]
    public int lower_level;
    [Token(Token = "0x400927D")]
    [FieldOffset(Offset = "0x50")]
    public int is_auto_approval;
    [Token(Token = "0x400927E")]
    [FieldOffset(Offset = "0x54")]
    public string award_id;
    [Token(Token = "0x400927F")]
    [FieldOffset(Offset = "0x58")]
    public int policy;
    [Token(Token = "0x4009280")]
    [FieldOffset(Offset = "0x5C")]
    public int report_id;

    [Token(Token = "0x170013E3")]
    public ChatLogParam.eChatMessageType messageType
    {
      [Token(Token = "0x6008D0A"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new ChatLogParam.eChatMessageType();
      }
      [Token(Token = "0x6008D0B"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
      {
      }
    }

    [Token(Token = "0x6008D0C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatLogParam()
    {
    }

    [Token(Token = "0x2002182")]
    public enum eChatMessageType : byte
    {
      [Token(Token = "0x4009282")] UNKNOWN,
      [Token(Token = "0x4009283")] MESSAGE,
      [Token(Token = "0x4009284")] STAMP,
      [Token(Token = "0x4009285")] SYSTEM,
      [Token(Token = "0x4009286")] GUILD_INVITE,
      [Token(Token = "0x4009287")] SYSTEM_GUILD,
      [Token(Token = "0x4009288")] GUILDRAID_PARTY,
    }
  }
}
