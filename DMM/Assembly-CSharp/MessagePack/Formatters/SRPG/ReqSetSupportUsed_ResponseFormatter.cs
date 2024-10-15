// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetSupportUsed_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD2")]
  public sealed class ReqSetSupportUsed_ResponseFormatter : 
    IMessagePackFormatter<ReqSetSupportUsed.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A34")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A35")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029C4")]
    [Address(RVA = "0xF164B0", Offset = "0xF152B0", VA = "0x10F164B0")]
    public ReqSetSupportUsed_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029C5")]
    [Address(RVA = "0xF16340", Offset = "0xF15140", VA = "0x10F16340", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetSupportUsed.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029C6")]
    [Address(RVA = "0xF16070", Offset = "0xF14E70", VA = "0x10F16070", Slot = "5")]
    public ReqSetSupportUsed.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetSupportUsed.Response) null;
    }
  }
}
