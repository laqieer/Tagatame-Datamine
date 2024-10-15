// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqInvalidSkillSetList_RequestSetUnitListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A43")]
  public sealed class ReqInvalidSkillSetList_RequestSetUnitListFormatter : 
    IMessagePackFormatter<ReqInvalidSkillSetList.RequestSetUnitList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001916")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001917")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002817")]
    [Address(RVA = "0xEB9B80", Offset = "0xEB8980", VA = "0x10EB9B80")]
    public ReqInvalidSkillSetList_RequestSetUnitListFormatter()
    {
    }

    [Token(Token = "0x6002818")]
    [Address(RVA = "0xEB99E0", Offset = "0xEB87E0", VA = "0x10EB99E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqInvalidSkillSetList.RequestSetUnitList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002819")]
    [Address(RVA = "0xEB96B0", Offset = "0xEB84B0", VA = "0x10EB96B0", Slot = "5")]
    public ReqInvalidSkillSetList.RequestSetUnitList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqInvalidSkillSetList.RequestSetUnitList) null;
    }
  }
}
