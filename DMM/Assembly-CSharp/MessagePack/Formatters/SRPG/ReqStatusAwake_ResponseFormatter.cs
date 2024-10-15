// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqStatusAwake_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AFC")]
  public sealed class ReqStatusAwake_ResponseFormatter : 
    IMessagePackFormatter<ReqStatusAwake.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A88")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A89")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A42")]
    [Address(RVA = "0xF2D2B0", Offset = "0xF2C0B0", VA = "0x10F2D2B0")]
    public ReqStatusAwake_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A43")]
    [Address(RVA = "0xF2D150", Offset = "0xF2BF50", VA = "0x10F2D150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqStatusAwake.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A44")]
    [Address(RVA = "0xF2CE10", Offset = "0xF2BC10", VA = "0x10F2CE10", Slot = "5")]
    public ReqStatusAwake.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqStatusAwake.Response) null;
    }
  }
}
