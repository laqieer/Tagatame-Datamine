// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_LookAt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001205")]
  [EventActionInfo("アクター/回転", "指定のオブジェクトを回転させます。", 5592405, 4473992)]
  public class EventAction_LookAt : EventAction
  {
    [Token(Token = "0x4004197")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string TargetID;
    [Token(Token = "0x4004198")]
    [FieldOffset(Offset = "0x1C")]
    public EventAction_LookAt.LookAtTypes LookAt;
    [Token(Token = "0x4004199")]
    [FieldOffset(Offset = "0x20")]
    [StringIsActorID]
    [HideInInspector]
    public string LookAtID;
    [Token(Token = "0x400419A")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public Vector3 LookAtPosition;
    [Token(Token = "0x400419B")]
    [FieldOffset(Offset = "0x30")]
    public EventAction_LookAt.RotationModes RotationMode;
    [Token(Token = "0x400419C")]
    [FieldOffset(Offset = "0x34")]
    public ObjectAnimator.CurveType Curve;
    [Token(Token = "0x400419D")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public float Time;
    [Token(Token = "0x400419E")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    public float Speed;
    [Token(Token = "0x400419F")]
    [FieldOffset(Offset = "0x40")]
    public bool Rotate3D;
    [Token(Token = "0x40041A0")]
    [FieldOffset(Offset = "0x44")]
    private Quaternion mStartRotation;
    [Token(Token = "0x40041A1")]
    [FieldOffset(Offset = "0x54")]
    private Quaternion mEndRotation;
    [Token(Token = "0x40041A2")]
    [FieldOffset(Offset = "0x64")]
    private Transform mTarget;
    [Token(Token = "0x40041A3")]
    [FieldOffset(Offset = "0x68")]
    private Vector3 mLookAt;
    [Token(Token = "0x40041A4")]
    [FieldOffset(Offset = "0x74")]
    private float mTime;

    [Token(Token = "0x6004CA1")]
    [Address(RVA = "0x121B360", Offset = "0x121A160", VA = "0x1121B360", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CA2")]
    [Address(RVA = "0x121B630", Offset = "0x121A430", VA = "0x1121B630", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CA3")]
    [Address(RVA = "0x121B750", Offset = "0x121A550", VA = "0x1121B750")]
    public EventAction_LookAt()
    {
    }

    [Token(Token = "0x2001206")]
    public enum LookAtTypes
    {
      [Token(Token = "0x40041A6")] WorldPosition,
      [Token(Token = "0x40041A7")] GameObject,
    }

    [Token(Token = "0x2001207")]
    public enum RotationModes
    {
      [Token(Token = "0x40041A9")] FixedTime,
      [Token(Token = "0x40041AA")] Speed,
    }
  }
}
