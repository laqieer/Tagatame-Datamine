// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.InspSkillTriggerParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200078F")]
  public sealed class InspSkillTriggerParamFormatter : 
    IMessagePackFormatter<InspSkillTriggerParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FFB")]
    [Address(RVA = "0xCDAFB0", Offset = "0xCD9DB0", VA = "0x10CDAFB0")]
    public InspSkillTriggerParamFormatter()
    {
    }

    [Token(Token = "0x6001FFC")]
    [Address(RVA = "0xCDADD0", Offset = "0xCD9BD0", VA = "0x10CDADD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      InspSkillTriggerParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FFD")]
    [Address(RVA = "0xCDAAC0", Offset = "0xCD98C0", VA = "0x10CDAAC0", Slot = "5")]
    public InspSkillTriggerParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (InspSkillTriggerParam) null;
    }
  }
}
