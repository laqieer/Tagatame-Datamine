// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRunePride_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200059E")]
  public sealed class ReqRunePride_ResponseFormatter : 
    IMessagePackFormatter<ReqRunePride.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FD4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FD5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A28")]
    [Address(RVA = "0x7A4980", Offset = "0x7A3780", VA = "0x107A4980")]
    public ReqRunePride_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001A29")]
    [Address(RVA = "0x7A48C0", Offset = "0x7A36C0", VA = "0x107A48C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRunePride.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A2A")]
    [Address(RVA = "0x7A4620", Offset = "0x7A3420", VA = "0x107A4620", Slot = "5")]
    public ReqRunePride.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRunePride.Response) null;
    }
  }
}
