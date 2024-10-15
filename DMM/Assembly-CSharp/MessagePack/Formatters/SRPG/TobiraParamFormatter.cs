// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TobiraParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000795")]
  public sealed class TobiraParamFormatter : 
    IMessagePackFormatter<TobiraParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600200D")]
    [Address(RVA = "0xCE3990", Offset = "0xCE2790", VA = "0x10CE3990")]
    public TobiraParamFormatter()
    {
    }

    [Token(Token = "0x600200E")]
    [Address(RVA = "0xCE34B0", Offset = "0xCE22B0", VA = "0x10CE34B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TobiraParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600200F")]
    [Address(RVA = "0xCE30E0", Offset = "0xCE1EE0", VA = "0x10CE30E0", Slot = "5")]
    public TobiraParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TobiraParam) null;
    }
  }
}
