// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventureTimeReduce_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000942")]
  public sealed class ReqAdventureTimeReduce_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventureTimeReduce.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001714")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001715")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002514")]
    [Address(RVA = "0xE18170", Offset = "0xE16F70", VA = "0x10E18170")]
    public ReqAdventureTimeReduce_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002515")]
    [Address(RVA = "0xE17F90", Offset = "0xE16D90", VA = "0x10E17F90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventureTimeReduce.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002516")]
    [Address(RVA = "0xE17C50", Offset = "0xE16A50", VA = "0x10E17C50", Slot = "5")]
    public ReqAdventureTimeReduce.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventureTimeReduce.Response) null;
    }
  }
}
