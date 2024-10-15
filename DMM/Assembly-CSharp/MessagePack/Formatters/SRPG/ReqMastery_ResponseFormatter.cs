// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqMastery_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D6")]
  public sealed class ReqMastery_ResponseFormatter : 
    IMessagePackFormatter<ReqMastery.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400143C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400143D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020D0")]
    [Address(RVA = "0xD1D160", Offset = "0xD1BF60", VA = "0x10D1D160")]
    public ReqMastery_ResponseFormatter()
    {
    }

    [Token(Token = "0x60020D1")]
    [Address(RVA = "0xD1D000", Offset = "0xD1BE00", VA = "0x10D1D000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqMastery.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020D2")]
    [Address(RVA = "0xD1CCA0", Offset = "0xD1BAA0", VA = "0x10D1CCA0", Slot = "5")]
    public ReqMastery.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqMastery.Response) null;
    }
  }
}
