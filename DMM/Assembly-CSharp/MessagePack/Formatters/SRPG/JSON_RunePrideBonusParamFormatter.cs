// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideBonusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E4")]
  public sealed class JSON_RunePrideBonusParamFormatter : 
    IMessagePackFormatter<JSON_RunePrideBonusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001260")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001261")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DFA")]
    [Address(RVA = "0xC2F660", Offset = "0xC2E460", VA = "0x10C2F660")]
    public JSON_RunePrideBonusParamFormatter()
    {
    }

    [Token(Token = "0x6001DFB")]
    [Address(RVA = "0xC2F420", Offset = "0xC2E220", VA = "0x10C2F420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideBonusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DFC")]
    [Address(RVA = "0xC2F020", Offset = "0xC2DE20", VA = "0x10C2F020", Slot = "5")]
    public JSON_RunePrideBonusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideBonusParam) null;
    }
  }
}
