// Decompiled with JetBrains decompiler
// Type: MapProjectile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x200011D")]
[DisallowMultipleComponent]
[AddComponentMenu("Common/MapProjectile")]
public class MapProjectile : MonoBehaviour
{
  [Token(Token = "0x400052C")]
  [FieldOffset(Offset = "0xC")]
  public MapProjectile.HitEvent OnHit;
  [Token(Token = "0x400052D")]
  [FieldOffset(Offset = "0x10")]
  public TacticsUnitController.ProjectileData mProjectileData;
  [Token(Token = "0x400052E")]
  [FieldOffset(Offset = "0x14")]
  public MapProjectile.DistanceChangeEvent OnDistanceUpdate;
  [Token(Token = "0x400052F")]
  [FieldOffset(Offset = "0x18")]
  public Transform CameraTransform;
  [Token(Token = "0x4000530")]
  [FieldOffset(Offset = "0x1C")]
  public Vector3 StartCameraTargetPosition;
  [Token(Token = "0x4000531")]
  [FieldOffset(Offset = "0x28")]
  public Vector3 EndCameraTargetPosition;
  [Token(Token = "0x4000532")]
  [FieldOffset(Offset = "0x34")]
  public Vector3 GoalPosition;
  [Token(Token = "0x4000533")]
  [FieldOffset(Offset = "0x40")]
  public float Speed;
  [Token(Token = "0x4000534")]
  [FieldOffset(Offset = "0x44")]
  public float TeleportTime;
  [Token(Token = "0x4000535")]
  [FieldOffset(Offset = "0x48")]
  public float HitDelay;
  [Token(Token = "0x4000536")]
  [FieldOffset(Offset = "0x4C")]
  public bool IsArrow;
  [Token(Token = "0x4000537")]
  [FieldOffset(Offset = "0x50")]
  public Vector2 MidPoint;
  [Token(Token = "0x4000538")]
  [FieldOffset(Offset = "0x58")]
  private Transform mTransform;
  [Token(Token = "0x4000539")]
  [FieldOffset(Offset = "0x5C")]
  private Vector3 mStartPosition;
  [Token(Token = "0x400053A")]
  [FieldOffset(Offset = "0x68")]
  private Vector3 mCameraInterpStart;
  [Token(Token = "0x400053B")]
  [FieldOffset(Offset = "0x74")]
  private float mElapsedTime;
  [Token(Token = "0x400053C")]
  [FieldOffset(Offset = "0x78")]
  private Vector3 mCameraOffset;
  [Token(Token = "0x400053D")]
  [FieldOffset(Offset = "0x84")]
  private bool mReachedGoal;
  [Token(Token = "0x400053E")]
  [FieldOffset(Offset = "0x88")]
  private Vector3 mPositionHistory;
  [Token(Token = "0x400053F")]
  [FieldOffset(Offset = "0x94")]
  private readonly float G;
  [Token(Token = "0x4000540")]
  [FieldOffset(Offset = "0x98")]
  public float TimeScale;
  [Token(Token = "0x4000541")]
  [FieldOffset(Offset = "0x9C")]
  public float TopHeight;
  [Token(Token = "0x4000542")]
  [FieldOffset(Offset = "0xA0")]
  private float mMoveTime;
  [Token(Token = "0x4000543")]
  [FieldOffset(Offset = "0xA4")]
  private float mStartSpeed;
  [Token(Token = "0x4000544")]
  [FieldOffset(Offset = "0xA8")]
  private Vector3 mPrevPos;
  [Token(Token = "0x4000545")]
  [FieldOffset(Offset = "0xB4")]
  private bool mIsStartProc;

  [Token(Token = "0x6000720")]
  [Address(RVA = "0xD603C0", Offset = "0xD5F1C0", VA = "0x10D603C0")]
  private void InitGravity()
  {
  }

  [Token(Token = "0x6000721")]
  [Address(RVA = "0xD5FFC0", Offset = "0xD5EDC0", VA = "0x10D5FFC0")]
  private void Gravity()
  {
  }

  [Token(Token = "0x6000722")]
  [Address(RVA = "0xD605F0", Offset = "0xD5F3F0", VA = "0x10D605F0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000723")]
  [Address(RVA = "0xD60760", Offset = "0xD5F560", VA = "0x10D60760")]
  private void Update()
  {
  }

  [Token(Token = "0x6000724")]
  [Address(RVA = "0xD5FDF0", Offset = "0xD5EBF0", VA = "0x10D5FDF0")]
  private void CalcMovedDistance()
  {
  }

  [Token(Token = "0x6000725")]
  [Address(RVA = "0xD5FD20", Offset = "0xD5EB20", VA = "0x10D5FD20")]
  public float CalcDepth(Vector3 position) => new float();

  [Token(Token = "0x6000726")]
  [Address(RVA = "0xD612D0", Offset = "0xD600D0", VA = "0x10D612D0")]
  public MapProjectile()
  {
  }

  [Token(Token = "0x200011E")]
  public delegate void HitEvent(TacticsUnitController.ProjectileData pd);

  [Token(Token = "0x200011F")]
  public delegate void DistanceChangeEvent(GameObject go, float distance);
}
