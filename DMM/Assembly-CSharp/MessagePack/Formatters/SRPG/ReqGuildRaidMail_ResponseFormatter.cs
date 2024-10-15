// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidMail_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A99")]
  public sealed class ReqGuildRaidMail_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidMail.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002919")]
    [Address(RVA = "0xEFF1D0", Offset = "0xEFDFD0", VA = "0x10EFF1D0")]
    public ReqGuildRaidMail_ResponseFormatter()
    {
    }

    [Token(Token = "0x600291A")]
    [Address(RVA = "0xEFF060", Offset = "0xEFDE60", VA = "0x10EFF060", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidMail.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600291B")]
    [Address(RVA = "0xEFED90", Offset = "0xEFDB90", VA = "0x10EFED90", Slot = "5")]
    public ReqGuildRaidMail.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidMail.Response) null;
    }
  }
}
