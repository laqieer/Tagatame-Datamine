// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_ActivateObjectInScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011EC")]
  [EventActionInfo("New/オブジェクト/シーン内オブジェクトを表示", "シーン内のオブジェクトを表示・非表示します", 5592405, 4473992)]
  public class EventAction_ActivateObjectInScene : EventAction
  {
    [Token(Token = "0x4004135")]
    [FieldOffset(Offset = "0x18")]
    public EventAction_ActivateObjectInScene.VisibleType visibleType;
    [Token(Token = "0x4004136")]
    [FieldOffset(Offset = "0x1C")]
    public string objectName;
    [Token(Token = "0x4004137")]
    [FieldOffset(Offset = "0x20")]
    public Vector3 objectPosition;

    [Token(Token = "0x6004C3B")]
    [Address(RVA = "0x12155B0", Offset = "0x12143B0", VA = "0x112155B0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C3C")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_ActivateObjectInScene()
    {
    }

    [Token(Token = "0x20011ED")]
    public enum VisibleType
    {
      [Token(Token = "0x4004139")] Visible,
      [Token(Token = "0x400413A")] Invisible,
    }
  }
}
