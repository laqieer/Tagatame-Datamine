// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PlayerParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005EA")]
  public sealed class JSON_PlayerParamFormatter : 
    IMessagePackFormatter<JSON_PlayerParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400106C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400106D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B0C")]
    [Address(RVA = "0xB98F60", Offset = "0xB97D60", VA = "0x10B98F60")]
    public JSON_PlayerParamFormatter()
    {
    }

    [Token(Token = "0x6001B0D")]
    [Address(RVA = "0xB98DC0", Offset = "0xB97BC0", VA = "0x10B98DC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PlayerParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B0E")]
    [Address(RVA = "0xB98A30", Offset = "0xB97830", VA = "0x10B98A30", Slot = "5")]
    public JSON_PlayerParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PlayerParam) null;
    }
  }
}
