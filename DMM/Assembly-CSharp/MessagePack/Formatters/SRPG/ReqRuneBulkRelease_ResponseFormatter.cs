// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneBulkRelease_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200094B")]
  public sealed class ReqRuneBulkRelease_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneBulkRelease.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001726")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001727")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600252F")]
    [Address(RVA = "0xE1D840", Offset = "0xE1C640", VA = "0x10E1D840")]
    public ReqRuneBulkRelease_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002530")]
    [Address(RVA = "0xE1D6E0", Offset = "0xE1C4E0", VA = "0x10E1D6E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneBulkRelease.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002531")]
    [Address(RVA = "0xE1D3A0", Offset = "0xE1C1A0", VA = "0x10E1D3A0", Slot = "5")]
    public ReqRuneBulkRelease.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneBulkRelease.Response) null;
    }
  }
}
