// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGBattle_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200094D")]
  public sealed class ReqGvGBattle_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGBattle.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400172A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400172B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002535")]
    [Address(RVA = "0xE1AF70", Offset = "0xE19D70", VA = "0x10E1AF70")]
    public ReqGvGBattle_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002536")]
    [Address(RVA = "0xE1A910", Offset = "0xE19710", VA = "0x10E1A910", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGBattle.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002537")]
    [Address(RVA = "0xE1A2D0", Offset = "0xE190D0", VA = "0x10E1A2D0", Slot = "5")]
    public ReqGvGBattle.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGBattle.Response) null;
    }
  }
}
