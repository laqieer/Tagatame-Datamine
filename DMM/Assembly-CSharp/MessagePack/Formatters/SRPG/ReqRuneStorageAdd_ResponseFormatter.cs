// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneStorageAdd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000871")]
  public sealed class ReqRuneStorageAdd_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneStorageAdd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001572")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001573")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022A1")]
    [Address(RVA = "0xDABD60", Offset = "0xDAAB60", VA = "0x10DABD60")]
    public ReqRuneStorageAdd_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022A2")]
    [Address(RVA = "0xDABC30", Offset = "0xDAAA30", VA = "0x10DABC30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneStorageAdd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022A3")]
    [Address(RVA = "0xDAB920", Offset = "0xDAA720", VA = "0x10DAB920", Slot = "5")]
    public ReqRuneStorageAdd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneStorageAdd.Response) null;
    }
  }
}
