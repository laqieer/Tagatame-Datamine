// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillBuffEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B0E")]
  public sealed class SkillBuffEffectParamFormatter : 
    IMessagePackFormatter<SkillBuffEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AAC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AAD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A78")]
    [Address(RVA = "0xF45F30", Offset = "0xF44D30", VA = "0x10F45F30")]
    public SkillBuffEffectParamFormatter()
    {
    }

    [Token(Token = "0x6002A79")]
    [Address(RVA = "0xF45CB0", Offset = "0xF44AB0", VA = "0x10F45CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillBuffEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A7A")]
    [Address(RVA = "0xF45990", Offset = "0xF44790", VA = "0x10F45990", Slot = "5")]
    public SkillBuffEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillBuffEffectParam) null;
    }
  }
}
