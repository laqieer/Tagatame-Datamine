// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_LookAt2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001208")]
  [EventActionInfo("New/アクター/回転", "指定のオブジェクトを回転させます。", 5592405, 4473992)]
  public class EventAction_LookAt2 : EventAction
  {
    [Token(Token = "0x40041AB")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string TargetID;
    [Token(Token = "0x40041AC")]
    [FieldOffset(Offset = "0x1C")]
    public EventAction_LookAt2.LookAtTypes LookAt;
    [Token(Token = "0x40041AD")]
    [FieldOffset(Offset = "0x20")]
    [StringIsActorID]
    [HideInInspector]
    public string LookAtID;
    [Token(Token = "0x40041AE")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public Vector3 LookAtPosition;
    [Token(Token = "0x40041AF")]
    [FieldOffset(Offset = "0x30")]
    public EventAction_LookAt2.RotationModes RotationMode;
    [Token(Token = "0x40041B0")]
    [FieldOffset(Offset = "0x34")]
    public ObjectAnimator.CurveType Curve;
    [Token(Token = "0x40041B1")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public float Time;
    [Token(Token = "0x40041B2")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    public float Speed;
    [Token(Token = "0x40041B3")]
    [FieldOffset(Offset = "0x40")]
    public bool Async;
    [Token(Token = "0x40041B4")]
    [FieldOffset(Offset = "0x41")]
    public bool Rotate3D;
    [Token(Token = "0x40041B5")]
    [FieldOffset(Offset = "0x44")]
    private Quaternion mStartRotation;
    [Token(Token = "0x40041B6")]
    [FieldOffset(Offset = "0x54")]
    private Quaternion mEndRotation;
    [Token(Token = "0x40041B7")]
    [FieldOffset(Offset = "0x64")]
    private Transform mTarget;
    [Token(Token = "0x40041B8")]
    [FieldOffset(Offset = "0x68")]
    private Vector3 mLookAt;
    [Token(Token = "0x40041B9")]
    [FieldOffset(Offset = "0x74")]
    public bool m_MoveSnap;
    [Token(Token = "0x40041BA")]
    [FieldOffset(Offset = "0x75")]
    public bool Reverse;
    [Token(Token = "0x40041BB")]
    [FieldOffset(Offset = "0x78")]
    [Range(0.0f, 359f)]
    [HideInInspector]
    public float RotateX;
    [Token(Token = "0x40041BC")]
    [FieldOffset(Offset = "0x7C")]
    [Range(0.0f, 359f)]
    [HideInInspector]
    public float RotateY;
    [Token(Token = "0x40041BD")]
    [FieldOffset(Offset = "0x80")]
    [Range(0.0f, 359f)]
    [HideInInspector]
    public float RotateZ;
    [Token(Token = "0x40041BE")]
    [FieldOffset(Offset = "0x84")]
    private Vector3 mEulerStartRotate;
    [Token(Token = "0x40041BF")]
    [FieldOffset(Offset = "0x90")]
    private Vector3 mEulerEndRotate;
    [Token(Token = "0x40041C0")]
    [FieldOffset(Offset = "0x9C")]
    private Vector3 mAddEulerAngle;
    [Token(Token = "0x40041C1")]
    [FieldOffset(Offset = "0xA8")]
    private float mTime;

    [Token(Token = "0x6004CA4")]
    [Address(RVA = "0x121ABE0", Offset = "0x12199E0", VA = "0x1121ABE0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CA5")]
    [Address(RVA = "0x121B1A0", Offset = "0x1219FA0", VA = "0x1121B1A0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CA6")]
    [Address(RVA = "0x121B330", Offset = "0x121A130", VA = "0x1121B330")]
    public EventAction_LookAt2()
    {
    }

    [Token(Token = "0x2001209")]
    public enum LookAtTypes
    {
      [Token(Token = "0x40041C3")] WorldPosition,
      [Token(Token = "0x40041C4")] GameObject,
      [Token(Token = "0x40041C5")] WorldRotate,
    }

    [Token(Token = "0x200120A")]
    public enum RotationModes
    {
      [Token(Token = "0x40041C7")] FixedTime,
      [Token(Token = "0x40041C8")] Speed,
    }
  }
}
