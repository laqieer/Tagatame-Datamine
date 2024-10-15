// Decompiled with JetBrains decompiler
// Type: SRPG.UnitCombatPowers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200118E")]
  [MessagePackObject(true)]
  [Serializable]
  public class UnitCombatPowers
  {
    [Token(Token = "0x4003FAD")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x4003FAE")]
    [FieldOffset(Offset = "0x10")]
    public long power;

    [Token(Token = "0x6004AFB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitCombatPowers()
    {
    }
  }
}
