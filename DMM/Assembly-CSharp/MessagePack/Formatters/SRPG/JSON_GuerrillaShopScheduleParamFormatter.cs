// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuerrillaShopScheduleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008EF")]
  public sealed class JSON_GuerrillaShopScheduleParamFormatter : 
    IMessagePackFormatter<JSON_GuerrillaShopScheduleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400166E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400166F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600241B")]
    [Address(RVA = "0xDE33D0", Offset = "0xDE21D0", VA = "0x10DE33D0")]
    public JSON_GuerrillaShopScheduleParamFormatter()
    {
    }

    [Token(Token = "0x600241C")]
    [Address(RVA = "0xDE3070", Offset = "0xDE1E70", VA = "0x10DE3070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuerrillaShopScheduleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600241D")]
    [Address(RVA = "0xDE2BD0", Offset = "0xDE19D0", VA = "0x10DE2BD0", Slot = "5")]
    public JSON_GuerrillaShopScheduleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuerrillaShopScheduleParam) null;
    }
  }
}
