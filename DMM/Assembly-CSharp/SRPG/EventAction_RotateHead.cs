// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_RotateHead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200122F")]
  [EventActionInfo("New/アクター/頭を回転", "指定のオブジェクトの頭を回転させます。", 5592405, 4473992)]
  public class EventAction_RotateHead : EventAction
  {
    [Token(Token = "0x40042CC")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string HeadBoneName;
    [Token(Token = "0x40042CD")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string NeckBoneName;
    [Token(Token = "0x40042CE")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string Spine1BoneName;
    [Token(Token = "0x40042CF")]
    [FieldOffset(Offset = "0xC")]
    private static readonly float NeckRotateInHead;
    [Token(Token = "0x40042D0")]
    [FieldOffset(Offset = "0x10")]
    private static readonly float Spine1RotateInHead;
    [Token(Token = "0x40042D1")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string TargetID;
    [Token(Token = "0x40042D2")]
    [FieldOffset(Offset = "0x1C")]
    [Range(-40f, 40f)]
    public float RotateY;
    [Token(Token = "0x40042D3")]
    [FieldOffset(Offset = "0x20")]
    public EventAction_RotateHead.RotationModes RotationMode;
    [Token(Token = "0x40042D4")]
    [FieldOffset(Offset = "0x24")]
    public ObjectAnimator.CurveType Curve;
    [Token(Token = "0x40042D5")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public float Time;
    [Token(Token = "0x40042D6")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public float Speed;
    [Token(Token = "0x40042D7")]
    [FieldOffset(Offset = "0x30")]
    public bool Async;
    [Token(Token = "0x40042D8")]
    [FieldOffset(Offset = "0x34")]
    private Transform mTargetHead;
    [Token(Token = "0x40042D9")]
    [FieldOffset(Offset = "0x38")]
    private Transform mTargetNeck;
    [Token(Token = "0x40042DA")]
    [FieldOffset(Offset = "0x3C")]
    private Transform mTargetSpine1;
    [Token(Token = "0x40042DB")]
    [FieldOffset(Offset = "0x40")]
    private Quaternion mStartRotationHead;
    [Token(Token = "0x40042DC")]
    [FieldOffset(Offset = "0x50")]
    private Quaternion mEndRotationHead;
    [Token(Token = "0x40042DD")]
    [FieldOffset(Offset = "0x60")]
    private Quaternion mStartRotationNeck;
    [Token(Token = "0x40042DE")]
    [FieldOffset(Offset = "0x70")]
    private Quaternion mEndRotationNeck;
    [Token(Token = "0x40042DF")]
    [FieldOffset(Offset = "0x80")]
    private Quaternion mStartRotationSpine1;
    [Token(Token = "0x40042E0")]
    [FieldOffset(Offset = "0x90")]
    private Quaternion mEndRotationSpine1;
    [Token(Token = "0x40042E1")]
    [FieldOffset(Offset = "0xA0")]
    private float mTime;

    [Token(Token = "0x6004D17")]
    [Address(RVA = "0x122E280", Offset = "0x122D080", VA = "0x1122E280", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D18")]
    [Address(RVA = "0x122E680", Offset = "0x122D480", VA = "0x1122E680", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004D19")]
    [Address(RVA = "0x122E9B0", Offset = "0x122D7B0", VA = "0x1122E9B0")]
    public EventAction_RotateHead()
    {
    }

    [Token(Token = "0x6004D1A")]
    [Address(RVA = "0x122E8E0", Offset = "0x122D6E0", VA = "0x1122E8E0")]
    static EventAction_RotateHead()
    {
    }

    [Token(Token = "0x2001230")]
    public enum RotationModes
    {
      [Token(Token = "0x40042E3")] FixedTime,
      [Token(Token = "0x40042E4")] Speed,
    }
  }
}
