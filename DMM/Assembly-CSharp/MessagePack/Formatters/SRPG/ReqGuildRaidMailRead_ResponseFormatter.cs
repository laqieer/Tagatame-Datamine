// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidMailRead_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000905")]
  public sealed class ReqGuildRaidMailRead_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidMailRead.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400169A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400169B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600245D")]
    [Address(RVA = "0xDEBCD0", Offset = "0xDEAAD0", VA = "0x10DEBCD0")]
    public ReqGuildRaidMailRead_ResponseFormatter()
    {
    }

    [Token(Token = "0x600245E")]
    [Address(RVA = "0xDEB690", Offset = "0xDEA490", VA = "0x10DEB690", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidMailRead.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600245F")]
    [Address(RVA = "0xDEB020", Offset = "0xDE9E20", VA = "0x10DEB020", Slot = "5")]
    public ReqGuildRaidMailRead.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidMailRead.Response) null;
    }
  }
}
