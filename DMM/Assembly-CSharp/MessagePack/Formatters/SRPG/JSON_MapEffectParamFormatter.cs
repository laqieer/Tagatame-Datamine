// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MapEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A72")]
  public sealed class JSON_MapEffectParamFormatter : 
    IMessagePackFormatter<JSON_MapEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001974")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001975")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028A4")]
    [Address(RVA = "0xEC9BE0", Offset = "0xEC89E0", VA = "0x10EC9BE0")]
    public JSON_MapEffectParamFormatter()
    {
    }

    [Token(Token = "0x60028A5")]
    [Address(RVA = "0xEC99C0", Offset = "0xEC87C0", VA = "0x10EC99C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MapEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028A6")]
    [Address(RVA = "0xEC95E0", Offset = "0xEC83E0", VA = "0x10EC95E0", Slot = "5")]
    public JSON_MapEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MapEffectParam) null;
    }
  }
}
