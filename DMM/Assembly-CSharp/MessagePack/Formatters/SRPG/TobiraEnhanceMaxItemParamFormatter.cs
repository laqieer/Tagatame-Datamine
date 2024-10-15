// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TobiraEnhanceMaxItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA6")]
  public sealed class TobiraEnhanceMaxItemParamFormatter : 
    IMessagePackFormatter<TobiraEnhanceMaxItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002940")]
    [Address(RVA = "0xF01B40", Offset = "0xF00940", VA = "0x10F01B40")]
    public TobiraEnhanceMaxItemParamFormatter()
    {
    }

    [Token(Token = "0x6002941")]
    [Address(RVA = "0xF01960", Offset = "0xF00760", VA = "0x10F01960", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TobiraEnhanceMaxItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002942")]
    [Address(RVA = "0xF01670", Offset = "0xF00470", VA = "0x10F01670", Slot = "5")]
    public TobiraEnhanceMaxItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TobiraEnhanceMaxItemParam) null;
    }
  }
}
