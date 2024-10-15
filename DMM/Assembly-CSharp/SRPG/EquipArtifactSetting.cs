// Decompiled with JetBrains decompiler
// Type: SRPG.EquipArtifactSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C25")]
  [MessagePackObject(true)]
  public class EquipArtifactSetting
  {
    [Token(Token = "0x4001FBF")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001FC0")]
    [FieldOffset(Offset = "0xC")]
    public int level;
    [Token(Token = "0x4001FC1")]
    [FieldOffset(Offset = "0x10")]
    public int rare;
    [Token(Token = "0x4001FC2")]
    [FieldOffset(Offset = "0x14")]
    public EquipAbilitySetting[] abils;

    [Token(Token = "0x600303D")]
    [Address(RVA = "0xFE4230", Offset = "0xFE3030", VA = "0x10FE4230")]
    public EquipArtifactSetting()
    {
    }
  }
}
