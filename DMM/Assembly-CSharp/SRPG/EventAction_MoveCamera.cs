// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001215")]
  [EventActionInfo("カメラ/移動", "カメラを移動します。", 4482628, 4500036)]
  public class EventAction_MoveCamera : EventAction
  {
    [Token(Token = "0x4004222")]
    [FieldOffset(Offset = "0x18")]
    public EventAction_MoveCamera.CameraMoveModes MoveMode;
    [Token(Token = "0x4004223")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public string ActorID;
    [Token(Token = "0x4004224")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public Vector3 StartTargetPosition;
    [Token(Token = "0x4004225")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public float StartRotation;
    [Token(Token = "0x4004226")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public float StartCameraDistance;
    [Token(Token = "0x4004227")]
    [FieldOffset(Offset = "0x34")]
    [HideInInspector]
    public float StartCameraDistanceScale;
    [Token(Token = "0x4004228")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public EventAction_MoveCamera.CameraMoveSpeeds Speed;
    [Token(Token = "0x4004229")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    public Vector3 TargetPosition;
    [Token(Token = "0x400422A")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    public float TargetRotation;
    [Token(Token = "0x400422B")]
    [FieldOffset(Offset = "0x4C")]
    private float mCurrentTime;
    [Token(Token = "0x400422C")]
    [FieldOffset(Offset = "0x50")]
    private float mEndTime;
    [Token(Token = "0x400422D")]
    [FieldOffset(Offset = "0x54")]
    [HideInInspector]
    public float CameraDistance;
    [Token(Token = "0x400422E")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    public float CameraDistanceScale;
    [Token(Token = "0x400422F")]
    [FieldOffset(Offset = "0x5C")]
    [HideInInspector]
    public float MoveTime;
    [Token(Token = "0x4004230")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    public bool Async;
    [Token(Token = "0x4004231")]
    [FieldOffset(Offset = "0x61")]
    [HideInInspector]
    public bool SnapToGround;
    [Token(Token = "0x4004232")]
    [FieldOffset(Offset = "0x64")]
    [HideInInspector]
    public EventAction_MoveCamera.CameraFadeModes FadeMode;
    [Token(Token = "0x4004233")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    public float FadeTime;
    [Token(Token = "0x4004234")]
    private const float SmoothingMargin = 0.5f;

    [Token(Token = "0x6004CCC")]
    [Address(RVA = "0x121F060", Offset = "0x121DE60", VA = "0x1121F060", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CCD")]
    [Address(RVA = "0x121F5B0", Offset = "0x121E3B0", VA = "0x1121F5B0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CCE")]
    [Address(RVA = "0x121E840", Offset = "0x121D640", VA = "0x1121E840")]
    private void UpdateCameraPosition(float t)
    {
    }

    [Token(Token = "0x6004CCF")]
    [Address(RVA = "0x121EC50", Offset = "0x121DA50", VA = "0x1121EC50", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004CD0")]
    [Address(RVA = "0x121EC20", Offset = "0x121DA20", VA = "0x1121EC20")]
    public EventAction_MoveCamera()
    {
    }

    [Token(Token = "0x2001216")]
    public enum CameraMoveModes
    {
      [Token(Token = "0x4004236")] InterpolateToPoint,
      [Token(Token = "0x4004237")] StartEnd,
      [Token(Token = "0x4004238")] SpecificActor,
    }

    [Token(Token = "0x2001217")]
    public enum CameraMoveSpeeds
    {
      [Token(Token = "0x400423A")] Immediate,
      [Token(Token = "0x400423B")] Normal,
      [Token(Token = "0x400423C")] Fast,
      [Token(Token = "0x400423D")] Slow,
    }

    [Token(Token = "0x2001218")]
    public enum CameraFadeModes
    {
      [Token(Token = "0x400423F")] KeepAsIs,
      [Token(Token = "0x4004240")] FadeIn,
      [Token(Token = "0x4004241")] FadeOut,
      [Token(Token = "0x4004242")] FadeInOut,
    }
  }
}
