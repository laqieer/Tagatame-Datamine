// Decompiled with JetBrains decompiler
// Type: SRPG.EquipDtuSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C2A")]
  [MessagePackObject(true)]
  public class EquipDtuSetting
  {
    [Token(Token = "0x4001FCE")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001FCF")]
    [FieldOffset(Offset = "0xC")]
    public EquipAbilitySetting[] abils;
    [Token(Token = "0x4001FD0")]
    [FieldOffset(Offset = "0x10")]
    public AIActionTable acttbl;

    [Token(Token = "0x6003042")]
    [Address(RVA = "0xFE42D0", Offset = "0xFE30D0", VA = "0x10FE42D0")]
    public EquipDtuSetting()
    {
    }
  }
}
