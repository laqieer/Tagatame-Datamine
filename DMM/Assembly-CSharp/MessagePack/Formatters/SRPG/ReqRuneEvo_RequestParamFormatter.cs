// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEvo_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000991")]
  public sealed class ReqRuneEvo_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneEvo.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002601")]
    [Address(RVA = "0xE46240", Offset = "0xE45040", VA = "0x10E46240")]
    public ReqRuneEvo_RequestParamFormatter()
    {
    }

    [Token(Token = "0x6002602")]
    [Address(RVA = "0xE46180", Offset = "0xE44F80", VA = "0x10E46180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEvo.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002603")]
    [Address(RVA = "0xE45EC0", Offset = "0xE44CC0", VA = "0x10E45EC0", Slot = "5")]
    public ReqRuneEvo.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEvo.RequestParam) null;
    }
  }
}
