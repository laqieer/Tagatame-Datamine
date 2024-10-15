// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidLogDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200088F")]
  public sealed class JSON_WorldRaidLogDataFormatter : 
    IMessagePackFormatter<JSON_WorldRaidLogData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022FB")]
    [Address(RVA = "0xDA1D60", Offset = "0xDA0B60", VA = "0x10DA1D60")]
    public JSON_WorldRaidLogDataFormatter()
    {
    }

    [Token(Token = "0x60022FC")]
    [Address(RVA = "0xDA1BA0", Offset = "0xDA09A0", VA = "0x10DA1BA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidLogData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022FD")]
    [Address(RVA = "0xDA17F0", Offset = "0xDA05F0", VA = "0x10DA17F0", Slot = "5")]
    public JSON_WorldRaidLogData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidLogData) null;
    }
  }
}
