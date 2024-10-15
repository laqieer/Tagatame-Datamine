// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneResetParamBase_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000997")]
  public sealed class ReqRuneResetParamBase_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneResetParamBase.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002613")]
    [Address(RVA = "0xE48D40", Offset = "0xE47B40", VA = "0x10E48D40")]
    public ReqRuneResetParamBase_RequestParamFormatter()
    {
    }

    [Token(Token = "0x6002614")]
    [Address(RVA = "0xE48C40", Offset = "0xE47A40", VA = "0x10E48C40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneResetParamBase.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002615")]
    [Address(RVA = "0xE48940", Offset = "0xE47740", VA = "0x10E48940", Slot = "5")]
    public ReqRuneResetParamBase.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneResetParamBase.RequestParam) null;
    }
  }
}
