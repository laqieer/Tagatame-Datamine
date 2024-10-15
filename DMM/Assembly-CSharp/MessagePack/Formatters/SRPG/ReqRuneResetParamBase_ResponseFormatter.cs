// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneResetParamBase_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000998")]
  public sealed class ReqRuneResetParamBase_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneResetParamBase.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002616")]
    [Address(RVA = "0xE49440", Offset = "0xE48240", VA = "0x10E49440")]
    public ReqRuneResetParamBase_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002617")]
    [Address(RVA = "0xE49270", Offset = "0xE48070", VA = "0x10E49270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneResetParamBase.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002618")]
    [Address(RVA = "0xE48EC0", Offset = "0xE47CC0", VA = "0x10E48EC0", Slot = "5")]
    public ReqRuneResetParamBase.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneResetParamBase.Response) null;
    }
  }
}
