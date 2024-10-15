// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.InspSkillParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000790")]
  public sealed class InspSkillParamFormatter : 
    IMessagePackFormatter<InspSkillParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FFE")]
    [Address(RVA = "0xCDA430", Offset = "0xCD9230", VA = "0x10CDA430")]
    public InspSkillParamFormatter()
    {
    }

    [Token(Token = "0x6001FFF")]
    [Address(RVA = "0xCD9D00", Offset = "0xCD8B00", VA = "0x10CD9D00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      InspSkillParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002000")]
    [Address(RVA = "0xCD9840", Offset = "0xCD8640", VA = "0x10CD9840", Slot = "5")]
    public InspSkillParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (InspSkillParam) null;
    }
  }
}
