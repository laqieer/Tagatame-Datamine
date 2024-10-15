// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MultiTowerFloorParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C1")]
  public sealed class JSON_MultiTowerFloorParamFormatter : 
    IMessagePackFormatter<JSON_MultiTowerFloorParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001812")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001813")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002691")]
    [Address(RVA = "0xE72280", Offset = "0xE71080", VA = "0x10E72280")]
    public JSON_MultiTowerFloorParamFormatter()
    {
    }

    [Token(Token = "0x6002692")]
    [Address(RVA = "0xE71B80", Offset = "0xE70980", VA = "0x10E71B80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MultiTowerFloorParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002693")]
    [Address(RVA = "0xE71300", Offset = "0xE70100", VA = "0x10E71300", Slot = "5")]
    public JSON_MultiTowerFloorParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MultiTowerFloorParam) null;
    }
  }
}
