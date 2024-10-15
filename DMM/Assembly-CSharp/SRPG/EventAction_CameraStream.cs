// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_CameraStream
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011F4")]
  [EventActionInfo("New/カメラ/カメラストリーム", "カメラ制御用のアニメーションを設定します。", 5592405, 4473992)]
  internal class EventAction_CameraStream : EventAction
  {
    [Token(Token = "0x400414D")]
    [FieldOffset(Offset = "0x18")]
    public AnimationClip m_CameraAnime;
    [Token(Token = "0x400414E")]
    [FieldOffset(Offset = "0x1C")]
    public bool m_Async;
    [Token(Token = "0x400414F")]
    [FieldOffset(Offset = "0x20")]
    public float Near;
    [Token(Token = "0x4004150")]
    [FieldOffset(Offset = "0x24")]
    public float Far;
    [Token(Token = "0x4004151")]
    [FieldOffset(Offset = "0x28")]
    public bool ScaleToFov;

    [Token(Token = "0x6004C4D")]
    [Address(RVA = "0x1216930", Offset = "0x1215730", VA = "0x11216930", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C4E")]
    [Address(RVA = "0x1216B20", Offset = "0x1215920", VA = "0x11216B20", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004C4F")]
    [Address(RVA = "0x1216CB0", Offset = "0x1215AB0", VA = "0x11216CB0")]
    public EventAction_CameraStream()
    {
    }
  }
}
