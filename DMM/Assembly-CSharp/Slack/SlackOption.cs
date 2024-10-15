// Decompiled with JetBrains decompiler
// Type: Slack.SlackOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Slack
{
  [Token(Token = "0x2000B49")]
  public class SlackOption
  {
    [Token(Token = "0x4001B30")]
    [FieldOffset(Offset = "0x8")]
    public string Mention;
    [Token(Token = "0x4001B31")]
    [FieldOffset(Offset = "0xC")]
    public string TicketNo;
    [Token(Token = "0x4001B32")]
    [FieldOffset(Offset = "0x10")]
    public string Comment;

    [Token(Token = "0x6002B35")]
    [Address(RVA = "0xFCDB80", Offset = "0xFCC980", VA = "0x10FCDB80")]
    public string GetMention() => (string) null;

    [Token(Token = "0x6002B36")]
    [Address(RVA = "0xFCDBB0", Offset = "0xFCC9B0", VA = "0x10FCDBB0")]
    public string GetTicket() => (string) null;

    [Token(Token = "0x6002B37")]
    [Address(RVA = "0xFCDBE0", Offset = "0xFCC9E0", VA = "0x10FCDBE0")]
    public SlackOption()
    {
    }
  }
}
