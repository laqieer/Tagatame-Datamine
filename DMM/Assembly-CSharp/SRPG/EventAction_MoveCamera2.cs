// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveCamera2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001219")]
  [EventActionInfo("New/カメラ/移動", "カメラを移動します。", 4482628, 4500036)]
  public class EventAction_MoveCamera2 : EventAction
  {
    [Token(Token = "0x4004243")]
    [FieldOffset(Offset = "0x18")]
    public EventAction_MoveCamera2.CameraMoveModes MoveMode;
    [Token(Token = "0x4004244")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public string ActorID;
    [Token(Token = "0x4004245")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public Vector3 StartTargetPosition;
    [Token(Token = "0x4004246")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public float StartRotation;
    [Token(Token = "0x4004247")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public float StartCameraDistance;
    [Token(Token = "0x4004248")]
    [FieldOffset(Offset = "0x34")]
    [HideInInspector]
    public float StartCameraDistanceScale;
    [Token(Token = "0x4004249")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public EventAction_MoveCamera2.CameraMoveSpeeds Speed;
    [Token(Token = "0x400424A")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    public Vector3 TargetPosition;
    [Token(Token = "0x400424B")]
    [FieldOffset(Offset = "0x48")]
    [Range(0.0f, 359f)]
    [HideInInspector]
    public float TargetRotation;
    [Token(Token = "0x400424C")]
    [FieldOffset(Offset = "0x4C")]
    private float mCurrentTime;
    [Token(Token = "0x400424D")]
    [FieldOffset(Offset = "0x50")]
    private float mEndTime;
    [Token(Token = "0x400424E")]
    [FieldOffset(Offset = "0x54")]
    [HideInInspector]
    public float CameraDistance;
    [Token(Token = "0x400424F")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    public float CameraDistanceScale;
    [Token(Token = "0x4004250")]
    [FieldOffset(Offset = "0x5C")]
    [HideInInspector]
    public float MoveTime;
    [Token(Token = "0x4004251")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    public bool Async;
    [Token(Token = "0x4004252")]
    [FieldOffset(Offset = "0x61")]
    [HideInInspector]
    public bool SnapToGround;
    [Token(Token = "0x4004253")]
    [FieldOffset(Offset = "0x64")]
    [HideInInspector]
    public EventAction_MoveCamera2.CameraFadeModes FadeMode;
    [Token(Token = "0x4004254")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    public float FadeTime;
    [Token(Token = "0x4004255")]
    private const float SmoothingMargin = 0.5f;

    [Token(Token = "0x6004CD1")]
    [Address(RVA = "0x121E2F0", Offset = "0x121D0F0", VA = "0x1121E2F0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CD2")]
    [Address(RVA = "0x121EA40", Offset = "0x121D840", VA = "0x1121EA40", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CD3")]
    [Address(RVA = "0x121E840", Offset = "0x121D640", VA = "0x1121E840")]
    private void UpdateCameraPosition(float t)
    {
    }

    [Token(Token = "0x6004CD4")]
    [Address(RVA = "0x121EC20", Offset = "0x121DA20", VA = "0x1121EC20")]
    public EventAction_MoveCamera2()
    {
    }

    [Token(Token = "0x200121A")]
    public enum CameraMoveModes
    {
      [Token(Token = "0x4004257")] InterpolateToPoint,
      [Token(Token = "0x4004258")] StartEnd,
      [Token(Token = "0x4004259")] SpecificActor,
    }

    [Token(Token = "0x200121B")]
    public enum CameraMoveSpeeds
    {
      [Token(Token = "0x400425B")] Immediate,
      [Token(Token = "0x400425C")] Normal,
      [Token(Token = "0x400425D")] Fast,
      [Token(Token = "0x400425E")] Slow,
    }

    [Token(Token = "0x200121C")]
    public enum CameraFadeModes
    {
      [Token(Token = "0x4004260")] KeepAsIs,
      [Token(Token = "0x4004261")] FadeIn,
      [Token(Token = "0x4004262")] FadeOut,
      [Token(Token = "0x4004263")] FadeInOut,
    }
  }
}
