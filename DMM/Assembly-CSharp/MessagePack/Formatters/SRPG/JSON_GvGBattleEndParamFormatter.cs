// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGBattleEndParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005CA")]
  public sealed class JSON_GvGBattleEndParamFormatter : 
    IMessagePackFormatter<JSON_GvGBattleEndParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400102C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400102D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AAC")]
    [Address(RVA = "0x94FCD0", Offset = "0x94EAD0", VA = "0x1094FCD0")]
    public JSON_GvGBattleEndParamFormatter()
    {
    }

    [Token(Token = "0x6001AAD")]
    [Address(RVA = "0x94FA80", Offset = "0x94E880", VA = "0x1094FA80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGBattleEndParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AAE")]
    [Address(RVA = "0x94F6D0", Offset = "0x94E4D0", VA = "0x1094F6D0", Slot = "5")]
    public JSON_GvGBattleEndParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGBattleEndParam) null;
    }
  }
}
