// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleTargetDisp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F5")]
  public class ToggleTargetDisp : AnimEvent
  {
    [Token(Token = "0x600DFBD")]
    [Address(RVA = "0xAA1C30", Offset = "0xAA0A30", VA = "0x10AA1C30")]
    private TacticsUnitController getTarget(TacticsUnitController tuc)
    {
      return (TacticsUnitController) null;
    }

    [Token(Token = "0x600DFBE")]
    [Address(RVA = "0xAA1B70", Offset = "0xAA0970", VA = "0x10AA1B70", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFBF")]
    [Address(RVA = "0xAA1A50", Offset = "0xAA0850", VA = "0x10AA1A50", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFC0")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public ToggleTargetDisp()
    {
    }
  }
}
