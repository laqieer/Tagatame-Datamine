// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBossChallengedDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200088D")]
  public sealed class JSON_WorldRaidBossChallengedDataFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBossChallengedData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022F5")]
    [Address(RVA = "0xDA0880", Offset = "0xD9F680", VA = "0x10DA0880")]
    public JSON_WorldRaidBossChallengedDataFormatter()
    {
    }

    [Token(Token = "0x60022F6")]
    [Address(RVA = "0xDA0710", Offset = "0xD9F510", VA = "0x10DA0710", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBossChallengedData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022F7")]
    [Address(RVA = "0xDA03A0", Offset = "0xD9F1A0", VA = "0x10DA03A0", Slot = "5")]
    public JSON_WorldRaidBossChallengedData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBossChallengedData) null;
    }
  }
}
