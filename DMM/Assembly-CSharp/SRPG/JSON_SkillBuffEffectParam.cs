// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillBuffEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D25")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillBuffEffectParam
  {
    [Token(Token = "0x4007246")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007247")]
    [FieldOffset(Offset = "0xC")]
    public string[] target_eff_list;
    [Token(Token = "0x4007248")]
    [FieldOffset(Offset = "0x10")]
    public string target_eff_se;
    [Token(Token = "0x4007249")]
    [FieldOffset(Offset = "0x14")]
    public string[] self_eff_list;
    [Token(Token = "0x400724A")]
    [FieldOffset(Offset = "0x18")]
    public string self_eff_se;

    [Token(Token = "0x6007788")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillBuffEffectParam()
    {
    }
  }
}
