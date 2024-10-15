// Decompiled with JetBrains decompiler
// Type: SRPG.PreviewUnitController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DA5")]
  [AddComponentMenu("Battle/PreviewUnitController")]
  public class PreviewUnitController : UnitController
  {
    [Token(Token = "0x4002747")]
    [FieldOffset(Offset = "0x128")]
    private Vector3 mStartPosition;
    [Token(Token = "0x4002748")]
    [FieldOffset(Offset = "0x134")]
    public string UnitID;
    [Token(Token = "0x4002749")]
    [FieldOffset(Offset = "0x138")]
    public string JobID;
    [Token(Token = "0x400274A")]
    [FieldOffset(Offset = "0x13C")]
    private List<string> mCameraAnimationNames;
    [Token(Token = "0x400274B")]
    [FieldOffset(Offset = "0x140")]
    private Transform mCameraPos;
    [Token(Token = "0x400274C")]
    [FieldOffset(Offset = "0x144")]
    private Transform mEnemyPos;
    [Token(Token = "0x400274D")]
    [FieldOffset(Offset = "0x148")]
    private int mCameraID;
    [Token(Token = "0x400274E")]
    [FieldOffset(Offset = "0x14C")]
    private Quaternion mCameraShakeOffset;
    [Token(Token = "0x400274F")]
    [FieldOffset(Offset = "0x15C")]
    private float mCameraShakeSeedX;
    [Token(Token = "0x4002750")]
    [FieldOffset(Offset = "0x160")]
    private float mCameraShakeSeedY;
    [Token(Token = "0x4002751")]
    [FieldOffset(Offset = "0x164")]
    public string mCurrentAnimation;
    [Token(Token = "0x4002752")]
    [FieldOffset(Offset = "0x168")]
    public List<string> mAnimationFiles;
    [Token(Token = "0x4002753")]
    [FieldOffset(Offset = "0x16C")]
    private AnimationClip mCameraAnimation;
    [Token(Token = "0x4002754")]
    [FieldOffset(Offset = "0x170")]
    private bool mUseCamera;
    [Token(Token = "0x4002755")]
    [FieldOffset(Offset = "0x174")]
    private Vector2 mAnimListScrollPos;
    [Token(Token = "0x4002756")]
    [FieldOffset(Offset = "0x17C")]
    private Vector2 mCameraAnimListScrollPos;
    [Token(Token = "0x4002757")]
    [FieldOffset(Offset = "0x184")]
    private bool mLoadingAnimation;
    [Token(Token = "0x4002758")]
    [FieldOffset(Offset = "0x185")]
    private bool mLoopAnimation;
    [Token(Token = "0x4002759")]
    [FieldOffset(Offset = "0x186")]
    private bool mMirror;
    [Token(Token = "0x400275A")]
    [FieldOffset(Offset = "0x188")]
    private float mSpeed;
    [Token(Token = "0x400275B")]
    [FieldOffset(Offset = "0x18C")]
    private bool mAnimationLoaded;
    [Token(Token = "0x400275C")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string SLOT0;

    [Token(Token = "0x6003742")]
    [Address(RVA = "0x10A2AC0", Offset = "0x10A18C0", VA = "0x110A2AC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003743")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "21")]
    protected override void PostSetup()
    {
    }

    [Token(Token = "0x6003744")]
    [Address(RVA = "0x10A33A0", Offset = "0x10A21A0", VA = "0x110A33A0", Slot = "8")]
    protected override void OnEventStart(AnimEvent e, float weight)
    {
    }

    [Token(Token = "0x6003745")]
    [Address(RVA = "0x10A34F0", Offset = "0x10A22F0", VA = "0x110A34F0", Slot = "9")]
    protected override void OnEvent(AnimEvent e, float time, float weight)
    {
    }

    [Token(Token = "0x6003746")]
    [Address(RVA = "0x10A3390", Offset = "0x10A2190", VA = "0x110A3390", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6003747")]
    [Address(RVA = "0x10A35C0", Offset = "0x10A23C0", VA = "0x110A35C0")]
    private new void Update()
    {
    }

    [Token(Token = "0x6003748")]
    [Address(RVA = "0x10A2E40", Offset = "0x10A1C40", VA = "0x110A2E40")]
    private new void LateUpdate()
    {
    }

    [Token(Token = "0x6003749")]
    [Address(RVA = "0x10A2C00", Offset = "0x10A1A00", VA = "0x110A2C00")]
    private static void DrawAxis(Vector3 center)
    {
    }

    [Token(Token = "0x600374A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDrawGizmos()
    {
    }

    [Token(Token = "0x600374B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x600374C")]
    [Address(RVA = "0x10A3A20", Offset = "0x10A2820", VA = "0x110A3A20")]
    public PreviewUnitController()
    {
    }

    [Token(Token = "0x600374D")]
    [Address(RVA = "0x10A39D0", Offset = "0x10A27D0", VA = "0x110A39D0")]
    static PreviewUnitController()
    {
    }
  }
}
