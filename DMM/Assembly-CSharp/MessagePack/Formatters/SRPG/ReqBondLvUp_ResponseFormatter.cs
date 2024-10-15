// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBondLvUp_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000965")]
  public sealed class ReqBondLvUp_ResponseFormatter : 
    IMessagePackFormatter<ReqBondLvUp.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400175A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400175B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600257D")]
    [Address(RVA = "0xE31D70", Offset = "0xE30B70", VA = "0x10E31D70")]
    public ReqBondLvUp_ResponseFormatter()
    {
    }

    [Token(Token = "0x600257E")]
    [Address(RVA = "0xE31990", Offset = "0xE30790", VA = "0x10E31990", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBondLvUp.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600257F")]
    [Address(RVA = "0xE31590", Offset = "0xE30390", VA = "0x10E31590", Slot = "5")]
    public ReqBondLvUp.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBondLvUp.Response) null;
    }
  }
}
