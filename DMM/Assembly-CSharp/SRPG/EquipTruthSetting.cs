// Decompiled with JetBrains decompiler
// Type: SRPG.EquipTruthSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C27")]
  [MessagePackObject(true)]
  public class EquipTruthSetting
  {
    [Token(Token = "0x4001FC9")]
    [FieldOffset(Offset = "0x8")]
    public int level;
    [Token(Token = "0x4001FCA")]
    [FieldOffset(Offset = "0xC")]
    public EquipAbilitySetting[] abils;

    [Token(Token = "0x600303F")]
    [Address(RVA = "0xFE4360", Offset = "0xFE3160", VA = "0x10FE4360")]
    public EquipTruthSetting()
    {
    }
  }
}
