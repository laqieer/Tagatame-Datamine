// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipArtifactSettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007BF")]
  public sealed class EquipArtifactSettingFormatter : 
    IMessagePackFormatter<EquipArtifactSetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400140E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400140F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600208B")]
    [Address(RVA = "0xD013B0", Offset = "0xD001B0", VA = "0x10D013B0")]
    public EquipArtifactSettingFormatter()
    {
    }

    [Token(Token = "0x600208C")]
    [Address(RVA = "0xD011E0", Offset = "0xCFFFE0", VA = "0x10D011E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipArtifactSetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600208D")]
    [Address(RVA = "0xD00E40", Offset = "0xCFFC40", VA = "0x10D00E40", Slot = "5")]
    public EquipArtifactSetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipArtifactSetting) null;
    }
  }
}
