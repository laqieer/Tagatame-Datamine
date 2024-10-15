// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerScoreFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000600")]
  public sealed class JSON_TowerScoreFormatter : 
    IMessagePackFormatter<JSON_TowerScore>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001098")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001099")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B4E")]
    [Address(RVA = "0xBAEA20", Offset = "0xBAD820", VA = "0x10BAEA20")]
    public JSON_TowerScoreFormatter()
    {
    }

    [Token(Token = "0x6001B4F")]
    [Address(RVA = "0xBAE840", Offset = "0xBAD640", VA = "0x10BAE840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerScore value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B50")]
    [Address(RVA = "0xBAE500", Offset = "0xBAD300", VA = "0x10BAE500", Slot = "5")]
    public JSON_TowerScore Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerScore) null;
    }
  }
}
