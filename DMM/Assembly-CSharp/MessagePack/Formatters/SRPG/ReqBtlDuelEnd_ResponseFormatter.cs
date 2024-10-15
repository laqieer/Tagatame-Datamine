// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBtlDuelEnd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B20")]
  public sealed class ReqBtlDuelEnd_ResponseFormatter : 
    IMessagePackFormatter<ReqBtlDuelEnd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AD0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AD1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AAE")]
    [Address(RVA = "0xF422C0", Offset = "0xF410C0", VA = "0x10F422C0")]
    public ReqBtlDuelEnd_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AAF")]
    [Address(RVA = "0xF41D20", Offset = "0xF40B20", VA = "0x10F41D20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBtlDuelEnd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AB0")]
    [Address(RVA = "0xF415F0", Offset = "0xF403F0", VA = "0x10F415F0", Slot = "5")]
    public ReqBtlDuelEnd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBtlDuelEnd.Response) null;
    }
  }
}
