// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildTrainingSet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E0")]
  public sealed class ReqGuildTrainingSet_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildTrainingSet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001850")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001851")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026EE")]
    [Address(RVA = "0xE8F6F0", Offset = "0xE8E4F0", VA = "0x10E8F6F0")]
    public ReqGuildTrainingSet_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026EF")]
    [Address(RVA = "0xE8F380", Offset = "0xE8E180", VA = "0x10E8F380", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildTrainingSet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026F0")]
    [Address(RVA = "0xE8EE60", Offset = "0xE8DC60", VA = "0x10E8EE60", Slot = "5")]
    public ReqGuildTrainingSet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildTrainingSet.Response) null;
    }
  }
}
