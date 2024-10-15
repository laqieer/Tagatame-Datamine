// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeSkillDistanceFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200074D")]
  public sealed class MultiPlayResumeSkillDistanceFormatter : 
    IMessagePackFormatter<MultiPlayResumeSkillDistance>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001332")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001333")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F35")]
    [Address(RVA = "0xC8EE80", Offset = "0xC8DC80", VA = "0x10C8EE80")]
    public MultiPlayResumeSkillDistanceFormatter()
    {
    }

    [Token(Token = "0x6001F36")]
    [Address(RVA = "0xC8ECF0", Offset = "0xC8DAF0", VA = "0x10C8ECF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeSkillDistance value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F37")]
    [Address(RVA = "0xC8E980", Offset = "0xC8D780", VA = "0x10C8E980", Slot = "5")]
    public MultiPlayResumeSkillDistance Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeSkillDistance) null;
    }
  }
}
