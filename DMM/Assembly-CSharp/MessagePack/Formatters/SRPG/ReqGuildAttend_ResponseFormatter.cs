// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildAttend_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D9")]
  public sealed class ReqGuildAttend_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildAttend.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001842")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001843")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026D9")]
    [Address(RVA = "0xE78DE0", Offset = "0xE77BE0", VA = "0x10E78DE0")]
    public ReqGuildAttend_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026DA")]
    [Address(RVA = "0xE78760", Offset = "0xE77560", VA = "0x10E78760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildAttend.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026DB")]
    [Address(RVA = "0xE78170", Offset = "0xE76F70", VA = "0x10E78170", Slot = "5")]
    public ReqGuildAttend.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildAttend.Response) null;
    }
  }
}
