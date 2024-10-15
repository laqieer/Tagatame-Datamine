// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BuyCoinStepsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF6")]
  public sealed class Json_BuyCoinStepsFormatter : 
    IMessagePackFormatter<Json_BuyCoinSteps>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A7C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A7D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A30")]
    [Address(RVA = "0xF23FA0", Offset = "0xF22DA0", VA = "0x10F23FA0")]
    public Json_BuyCoinStepsFormatter()
    {
    }

    [Token(Token = "0x6002A31")]
    [Address(RVA = "0xF23DA0", Offset = "0xF22BA0", VA = "0x10F23DA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BuyCoinSteps value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A32")]
    [Address(RVA = "0xF239D0", Offset = "0xF227D0", VA = "0x10F239D0", Slot = "5")]
    public Json_BuyCoinSteps Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BuyCoinSteps) null;
    }
  }
}
