// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterArtifactParam_ConditionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000670")]
  public sealed class JSON_FilterArtifactParam_ConditionFormatter : 
    IMessagePackFormatter<JSON_FilterArtifactParam.Condition>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001178")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001179")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C9E")]
    [Address(RVA = "0xBE3480", Offset = "0xBE2280", VA = "0x10BE3480")]
    public JSON_FilterArtifactParam_ConditionFormatter()
    {
    }

    [Token(Token = "0x6001C9F")]
    [Address(RVA = "0xBE3170", Offset = "0xBE1F70", VA = "0x10BE3170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterArtifactParam.Condition value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CA0")]
    [Address(RVA = "0xBE2C90", Offset = "0xBE1A90", VA = "0x10BE2C90", Slot = "5")]
    public JSON_FilterArtifactParam.Condition Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterArtifactParam.Condition) null;
    }
  }
}
