// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGLeague_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A50")]
  public sealed class ReqGvGLeague_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGLeague.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001930")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001931")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600283E")]
    [Address(RVA = "0xEB7B70", Offset = "0xEB6970", VA = "0x10EB7B70")]
    public ReqGvGLeague_ResponseFormatter()
    {
    }

    [Token(Token = "0x600283F")]
    [Address(RVA = "0xEB78F0", Offset = "0xEB66F0", VA = "0x10EB78F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGLeague.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002840")]
    [Address(RVA = "0xEB7570", Offset = "0xEB6370", VA = "0x10EB7570", Slot = "5")]
    public ReqGvGLeague.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGLeague.Response) null;
    }
  }
}
