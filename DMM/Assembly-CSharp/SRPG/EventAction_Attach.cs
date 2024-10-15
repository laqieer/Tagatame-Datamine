// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Attach
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011F0")]
  [EventActionInfo("アタッチデタッチ", "指定オブジェクトを別オブジェクトにアタッチ/デタッチします。", 5592405, 4473992)]
  public class EventAction_Attach : EventAction
  {
    [Token(Token = "0x400413F")]
    [FieldOffset(Offset = "0x18")]
    public bool Detach;
    [Token(Token = "0x4004140")]
    [FieldOffset(Offset = "0x1C")]
    public string AttachmentID;
    [Token(Token = "0x4004141")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public string TargetID;
    [Token(Token = "0x4004142")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public string BoneName;

    [Token(Token = "0x6004C43")]
    [Address(RVA = "0x1215FD0", Offset = "0x1214DD0", VA = "0x11215FD0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C44")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_Attach()
    {
    }
  }
}
