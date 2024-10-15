// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.InspirationSkillDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000791")]
  public sealed class InspirationSkillDataFormatter : 
    IMessagePackFormatter<InspirationSkillData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002001")]
    [Address(RVA = "0xCDC180", Offset = "0xCDAF80", VA = "0x10CDC180")]
    public InspirationSkillDataFormatter()
    {
    }

    [Token(Token = "0x6002002")]
    [Address(RVA = "0xCDBD80", Offset = "0xCDAB80", VA = "0x10CDBD80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      InspirationSkillData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002003")]
    [Address(RVA = "0xCDB960", Offset = "0xCDA760", VA = "0x10CDB960", Slot = "5")]
    public InspirationSkillData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (InspirationSkillData) null;
    }
  }
}
