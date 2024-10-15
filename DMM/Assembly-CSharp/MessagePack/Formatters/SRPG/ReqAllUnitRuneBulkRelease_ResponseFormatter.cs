// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAllUnitRuneBulkRelease_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200098E")]
  public sealed class ReqAllUnitRuneBulkRelease_ResponseFormatter : 
    IMessagePackFormatter<ReqAllUnitRuneBulkRelease.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025F8")]
    [Address(RVA = "0xE3E960", Offset = "0xE3D760", VA = "0x10E3E960")]
    public ReqAllUnitRuneBulkRelease_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025F9")]
    [Address(RVA = "0xE3E800", Offset = "0xE3D600", VA = "0x10E3E800", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAllUnitRuneBulkRelease.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025FA")]
    [Address(RVA = "0xE3E4C0", Offset = "0xE3D2C0", VA = "0x10E3E4C0", Slot = "5")]
    public ReqAllUnitRuneBulkRelease.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAllUnitRuneBulkRelease.Response) null;
    }
  }
}
