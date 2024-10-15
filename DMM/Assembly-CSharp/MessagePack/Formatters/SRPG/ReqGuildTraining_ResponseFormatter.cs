// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildTraining_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009DF")]
  public sealed class ReqGuildTraining_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildTraining.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400184E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400184F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026EB")]
    [Address(RVA = "0xE90240", Offset = "0xE8F040", VA = "0x10E90240")]
    public ReqGuildTraining_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026EC")]
    [Address(RVA = "0xE8FF40", Offset = "0xE8ED40", VA = "0x10E8FF40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildTraining.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026ED")]
    [Address(RVA = "0xE8FA90", Offset = "0xE8E890", VA = "0x10E8FA90", Slot = "5")]
    public ReqGuildTraining.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildTraining.Response) null;
    }
  }
}
