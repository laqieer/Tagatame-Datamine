// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePrideBonusStatusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA5")]
  public sealed class RunePrideBonusStatusParamFormatter : 
    IMessagePackFormatter<RunePrideBonusStatusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600293D")]
    [Address(RVA = "0xF014F0", Offset = "0xF002F0", VA = "0x10F014F0")]
    public RunePrideBonusStatusParamFormatter()
    {
    }

    [Token(Token = "0x600293E")]
    [Address(RVA = "0xF01310", Offset = "0xF00110", VA = "0x10F01310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePrideBonusStatusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600293F")]
    [Address(RVA = "0xF01000", Offset = "0xEFFE00", VA = "0x10F01000", Slot = "5")]
    public RunePrideBonusStatusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePrideBonusStatusParam) null;
    }
  }
}
