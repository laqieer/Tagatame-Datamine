// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TruthEquipmentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DAE")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TruthEquipmentParam
  {
    [Token(Token = "0x4007638")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007639")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400763A")]
    [FieldOffset(Offset = "0x10")]
    public string icon;
    [Token(Token = "0x400763B")]
    [FieldOffset(Offset = "0x14")]
    public int enable;
    [Token(Token = "0x400763C")]
    [FieldOffset(Offset = "0x18")]
    public JSON_TruthEquipmentLvEffectParam[] lv_effects;

    [Token(Token = "0x600796C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TruthEquipmentParam()
    {
    }
  }
}
