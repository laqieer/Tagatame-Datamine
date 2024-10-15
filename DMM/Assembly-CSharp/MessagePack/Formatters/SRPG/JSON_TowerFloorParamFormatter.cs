// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerFloorParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D2")]
  public sealed class JSON_TowerFloorParamFormatter : 
    IMessagePackFormatter<JSON_TowerFloorParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001834")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001835")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026C4")]
    [Address(RVA = "0xE73EB0", Offset = "0xE72CB0", VA = "0x10E73EB0")]
    public JSON_TowerFloorParamFormatter()
    {
    }

    [Token(Token = "0x60026C5")]
    [Address(RVA = "0xE73570", Offset = "0xE72370", VA = "0x10E73570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerFloorParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026C6")]
    [Address(RVA = "0xE72BF0", Offset = "0xE719F0", VA = "0x10E72BF0", Slot = "5")]
    public JSON_TowerFloorParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerFloorParam) null;
    }
  }
}
