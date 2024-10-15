// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MultiTowerRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000879")]
  public sealed class JSON_MultiTowerRewardParamFormatter : 
    IMessagePackFormatter<JSON_MultiTowerRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001582")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001583")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022B9")]
    [Address(RVA = "0xD9FCC0", Offset = "0xD9EAC0", VA = "0x10D9FCC0")]
    public JSON_MultiTowerRewardParamFormatter()
    {
    }

    [Token(Token = "0x60022BA")]
    [Address(RVA = "0xD9FAE0", Offset = "0xD9E8E0", VA = "0x10D9FAE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MultiTowerRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022BB")]
    [Address(RVA = "0xD9F7A0", Offset = "0xD9E5A0", VA = "0x10D9F7A0", Slot = "5")]
    public JSON_MultiTowerRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MultiTowerRewardParam) null;
    }
  }
}
