// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillCriticalHealParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E33")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillCriticalHealParam
  {
    [Token(Token = "0x4007AF1")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007AF2")]
    [FieldOffset(Offset = "0xC")]
    public int heal_type;
    [Token(Token = "0x4007AF3")]
    [FieldOffset(Offset = "0x10")]
    public int eff_val;

    [Token(Token = "0x6007BED")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillCriticalHealParam()
    {
    }
  }
}
