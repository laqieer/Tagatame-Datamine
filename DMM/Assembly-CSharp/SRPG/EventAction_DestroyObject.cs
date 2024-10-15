// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_DestroyObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011F6")]
  [EventActionInfo("New/オブジェクト/削除", "指定のオブジェクトを削除します。", 6702148, 11158596)]
  public class EventAction_DestroyObject : EventAction
  {
    [Token(Token = "0x4004153")]
    [FieldOffset(Offset = "0x18")]
    [StringIsObjectList]
    [SerializeField]
    public string TargetID;

    [Token(Token = "0x6004C52")]
    [Address(RVA = "0x1216DD0", Offset = "0x1215BD0", VA = "0x11216DD0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C53")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_DestroyObject()
    {
    }
  }
}
