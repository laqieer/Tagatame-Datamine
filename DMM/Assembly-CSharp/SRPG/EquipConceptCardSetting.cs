// Decompiled with JetBrains decompiler
// Type: SRPG.EquipConceptCardSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C26")]
  [MessagePackObject(true)]
  public class EquipConceptCardSetting
  {
    [Token(Token = "0x4001FC3")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001FC4")]
    [FieldOffset(Offset = "0xC")]
    public int level;
    [Token(Token = "0x4001FC5")]
    [FieldOffset(Offset = "0x10")]
    public int plus;
    [Token(Token = "0x4001FC6")]
    [FieldOffset(Offset = "0x14")]
    public int extra;
    [Token(Token = "0x4001FC7")]
    [FieldOffset(Offset = "0x18")]
    public int index;
    [Token(Token = "0x4001FC8")]
    [FieldOffset(Offset = "0x1C")]
    public EquipAbilitySetting[] abils;

    [Token(Token = "0x600303E")]
    [Address(RVA = "0xFE4280", Offset = "0xFE3080", VA = "0x10FE4280")]
    public EquipConceptCardSetting()
    {
    }
  }
}
