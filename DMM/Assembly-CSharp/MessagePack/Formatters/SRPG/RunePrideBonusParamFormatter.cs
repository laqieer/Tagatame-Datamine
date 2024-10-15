// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePrideBonusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009CC")]
  public sealed class RunePrideBonusParamFormatter : 
    IMessagePackFormatter<RunePrideBonusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001828")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001829")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026B2")]
    [Address(RVA = "0xE7B160", Offset = "0xE79F60", VA = "0x10E7B160")]
    public RunePrideBonusParamFormatter()
    {
    }

    [Token(Token = "0x60026B3")]
    [Address(RVA = "0xE7AF20", Offset = "0xE79D20", VA = "0x10E7AF20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePrideBonusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026B4")]
    [Address(RVA = "0xE7AC30", Offset = "0xE79A30", VA = "0x10E7AC30", Slot = "5")]
    public RunePrideBonusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePrideBonusParam) null;
    }
  }
}
