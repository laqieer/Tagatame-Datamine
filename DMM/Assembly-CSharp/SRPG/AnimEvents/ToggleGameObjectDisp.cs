// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleGameObjectDisp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F4")]
  public class ToggleGameObjectDisp : AnimEvent
  {
    [Token(Token = "0x400EFCC")]
    [FieldOffset(Offset = "0x18")]
    public string[] NameGameObjects;
    [Token(Token = "0x400EFCD")]
    [FieldOffset(Offset = "0x1C")]
    private List<GameObject> mGoTargetLists;

    [Token(Token = "0x600DFB9")]
    [Address(RVA = "0xAA1730", Offset = "0xAA0530", VA = "0x10AA1730")]
    private List<GameObject> GetGoTargets(GameObject go) => (List<GameObject>) null;

    [Token(Token = "0x600DFBA")]
    [Address(RVA = "0xAA19C0", Offset = "0xAA07C0", VA = "0x10AA19C0", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFBB")]
    [Address(RVA = "0xAA1920", Offset = "0xAA0720", VA = "0x10AA1920", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFBC")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public ToggleGameObjectDisp()
    {
    }
  }
}
