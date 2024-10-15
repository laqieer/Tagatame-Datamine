// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidInfo_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000926")]
  public sealed class ReqGuildRaidInfo_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidInfo.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024C0")]
    [Address(RVA = "0xE04560", Offset = "0xE03360", VA = "0x10E04560")]
    public ReqGuildRaidInfo_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024C1")]
    [Address(RVA = "0xE04330", Offset = "0xE03130", VA = "0x10E04330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidInfo.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024C2")]
    [Address(RVA = "0xE03FF0", Offset = "0xE02DF0", VA = "0x10E03FF0", Slot = "5")]
    public ReqGuildRaidInfo.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidInfo.Response) null;
    }
  }
}
