// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePrideBonusDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA4")]
  public sealed class RunePrideBonusDataFormatter : 
    IMessagePackFormatter<RunePrideBonusData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600293A")]
    [Address(RVA = "0xF00CD0", Offset = "0xEFFAD0", VA = "0x10F00CD0")]
    public RunePrideBonusDataFormatter()
    {
    }

    [Token(Token = "0x600293B")]
    [Address(RVA = "0xF00900", Offset = "0xEFF700", VA = "0x10F00900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePrideBonusData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600293C")]
    [Address(RVA = "0xF00520", Offset = "0xEFF320", VA = "0x10F00520", Slot = "5")]
    public RunePrideBonusData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePrideBonusData) null;
    }
  }
}
