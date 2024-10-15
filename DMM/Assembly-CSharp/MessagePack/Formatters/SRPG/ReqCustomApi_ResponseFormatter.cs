// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCustomApi_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AE1")]
  public sealed class ReqCustomApi_ResponseFormatter : 
    IMessagePackFormatter<ReqCustomApi.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A52")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A53")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029F1")]
    [Address(RVA = "0xF27330", Offset = "0xF26130", VA = "0x10F27330")]
    public ReqCustomApi_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029F2")]
    [Address(RVA = "0xF271C0", Offset = "0xF25FC0", VA = "0x10F271C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCustomApi.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029F3")]
    [Address(RVA = "0xF26EF0", Offset = "0xF25CF0", VA = "0x10F26EF0", Slot = "5")]
    public ReqCustomApi.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCustomApi.Response) null;
    }
  }
}
