// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGHalfTime_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B8")]
  public sealed class ReqGvGHalfTime_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGHalfTime.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001800")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001801")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002676")]
    [Address(RVA = "0xE7A3C0", Offset = "0xE791C0", VA = "0x10E7A3C0")]
    public ReqGvGHalfTime_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002677")]
    [Address(RVA = "0xE7A250", Offset = "0xE79050", VA = "0x10E7A250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGHalfTime.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002678")]
    [Address(RVA = "0xE79F80", Offset = "0xE78D80", VA = "0x10E79F80", Slot = "5")]
    public ReqGvGHalfTime.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGHalfTime.Response) null;
    }
  }
}
