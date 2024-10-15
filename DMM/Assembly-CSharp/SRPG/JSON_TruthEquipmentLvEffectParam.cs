// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TruthEquipmentLvEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DAD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TruthEquipmentLvEffectParam
  {
    [Token(Token = "0x4007635")]
    [FieldOffset(Offset = "0x8")]
    public string recipe;
    [Token(Token = "0x4007636")]
    [FieldOffset(Offset = "0xC")]
    public string status;
    [Token(Token = "0x4007637")]
    [FieldOffset(Offset = "0x10")]
    public string learn_ability;

    [Token(Token = "0x600796B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TruthEquipmentLvEffectParam()
    {
    }
  }
}
