// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGNodeOffenseEntry_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A46")]
  public sealed class ReqGvGNodeOffenseEntry_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGNodeOffenseEntry.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400191C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400191D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002820")]
    [Address(RVA = "0xEB8420", Offset = "0xEB7220", VA = "0x10EB8420")]
    public ReqGvGNodeOffenseEntry_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002821")]
    [Address(RVA = "0xEB8110", Offset = "0xEB6F10", VA = "0x10EB8110", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGNodeOffenseEntry.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002822")]
    [Address(RVA = "0xEB7D60", Offset = "0xEB6B60", VA = "0x10EB7D60", Slot = "5")]
    public ReqGvGNodeOffenseEntry.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGNodeOffenseEntry.Response) null;
    }
  }
}
