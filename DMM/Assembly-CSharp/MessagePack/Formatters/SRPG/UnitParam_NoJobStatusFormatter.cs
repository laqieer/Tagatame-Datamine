// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitParam_NoJobStatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000768")]
  public sealed class UnitParam_NoJobStatusFormatter : 
    IMessagePackFormatter<UnitParam.NoJobStatus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001368")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001369")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F86")]
    [Address(RVA = "0xCBD860", Offset = "0xCBC660", VA = "0x10CBD860")]
    public UnitParam_NoJobStatusFormatter()
    {
    }

    [Token(Token = "0x6001F87")]
    [Address(RVA = "0xCBD5D0", Offset = "0xCBC3D0", VA = "0x10CBD5D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitParam.NoJobStatus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F88")]
    [Address(RVA = "0xCBD1A0", Offset = "0xCBBFA0", VA = "0x10CBD1A0", Slot = "5")]
    public UnitParam.NoJobStatus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (UnitParam.NoJobStatus) null;
    }
  }
}
