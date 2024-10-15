// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TruthEquipmentAbilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DAB")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TruthEquipmentAbilityParam
  {
    [Token(Token = "0x400762D")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400762E")]
    [FieldOffset(Offset = "0xC")]
    public int learn_type;
    [Token(Token = "0x400762F")]
    [FieldOffset(Offset = "0x10")]
    public string abil_iname;
    [Token(Token = "0x4007630")]
    [FieldOffset(Offset = "0x14")]
    public string abil_overwrite;

    [Token(Token = "0x600795F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TruthEquipmentAbilityParam()
    {
    }
  }
}
