// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEvo_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000887")]
  public sealed class ReqRuneEvo_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneEvo.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400159E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400159F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022E3")]
    [Address(RVA = "0xDAB730", Offset = "0xDAA530", VA = "0x10DAB730")]
    public ReqRuneEvo_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022E4")]
    [Address(RVA = "0xDAB4D0", Offset = "0xDAA2D0", VA = "0x10DAB4D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEvo.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022E5")]
    [Address(RVA = "0xDAB120", Offset = "0xDA9F20", VA = "0x10DAB120", Slot = "5")]
    public ReqRuneEvo.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEvo.Response) null;
    }
  }
}
