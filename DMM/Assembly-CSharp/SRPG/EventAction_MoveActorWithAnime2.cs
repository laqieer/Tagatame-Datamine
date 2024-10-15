// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveActorWithAnime2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001210")]
  [EventActionInfo("New/アクター/移動2(アニメーション再生付)", "アクターを指定パスに沿って移動させます。", 6702148, 11158596)]
  public class EventAction_MoveActorWithAnime2 : EventAction
  {
    [Token(Token = "0x40041F1")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x40041F2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HideInInspector]
    private IntVector2[] mPoints;
    [Token(Token = "0x40041F3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public Vector3[] m_WayPoints;
    [Token(Token = "0x40041F4")]
    [FieldOffset(Offset = "0x24")]
    public float Delay;
    [Token(Token = "0x40041F5")]
    [FieldOffset(Offset = "0x28")]
    public bool Async;
    [Token(Token = "0x40041F6")]
    [FieldOffset(Offset = "0x29")]
    public bool GotoRealPosition;
    [Token(Token = "0x40041F7")]
    [FieldOffset(Offset = "0x2A")]
    public bool m_StartActorPos;
    [Token(Token = "0x40041F8")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public float Angle;
    [Token(Token = "0x40041F9")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("マス目にスナップするか？")]
    public bool MoveSnap;
    [Token(Token = "0x40041FA")]
    [FieldOffset(Offset = "0x31")]
    [Tooltip("地面にスナップするか？")]
    public bool GroundSnap;
    [Token(Token = "0x40041FB")]
    [FieldOffset(Offset = "0x32")]
    [Tooltip("移動する時にモーションを固定化するか")]
    public bool LockMotion;
    [Token(Token = "0x40041FC")]
    [FieldOffset(Offset = "0x33")]
    private bool FoldoutLockRotation;
    [Token(Token = "0x40041FD")]
    [FieldOffset(Offset = "0x34")]
    [HideInInspector]
    public bool LockRotationX;
    [Token(Token = "0x40041FE")]
    [FieldOffset(Offset = "0x35")]
    [HideInInspector]
    public bool LockRotationY;
    [Token(Token = "0x40041FF")]
    [FieldOffset(Offset = "0x36")]
    [HideInInspector]
    public bool LockRotationZ;
    [Token(Token = "0x4004200")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public EventAction_MoveActorWithAnime2.RunTypes RunType;
    [Token(Token = "0x4004201")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    [Tooltip("移動速度")]
    public float RunSpeed;
    [Token(Token = "0x4004202")]
    [FieldOffset(Offset = "0x40")]
    private float BackupRunSpeed;
    [Token(Token = "0x4004203")]
    [FieldOffset(Offset = "0x44")]
    [Tooltip("移動時間")]
    [HideInInspector]
    public float RunTime;
    [Token(Token = "0x4004204")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    public string m_AnimationName;
    [Token(Token = "0x4004205")]
    [FieldOffset(Offset = "0x4C")]
    [HideInInspector]
    public bool m_Loop;
    [Token(Token = "0x4004206")]
    [FieldOffset(Offset = "0x50")]
    [HideInInspector]
    public EventAction_MoveActorWithAnime2.AnimeType m_AnimeType;
    [Token(Token = "0x4004207")]
    [FieldOffset(Offset = "0x54")]
    private string m_AnimationID;
    [Token(Token = "0x4004208")]
    private const string MOVIE_PATH = "Movies/";
    [Token(Token = "0x4004209")]
    private const string DEMO_PATH = "Demo/";
    [Token(Token = "0x400420A")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    public EventAction_MoveActorWithAnime2.PREFIX_PATH Path;
    [Token(Token = "0x400420B")]
    [FieldOffset(Offset = "0x5C")]
    private bool FoldoutAnimation;
    [Token(Token = "0x400420C")]
    [FieldOffset(Offset = "0x60")]
    private int mMoveIndex;
    [Token(Token = "0x400420D")]
    [FieldOffset(Offset = "0x64")]
    private float mTime;
    [Token(Token = "0x400420E")]
    [FieldOffset(Offset = "0x68")]
    private TacticsUnitController mController;
    [Token(Token = "0x400420F")]
    [FieldOffset(Offset = "0x6C")]
    private bool mReady;
    [Token(Token = "0x4004210")]
    [FieldOffset(Offset = "0x6D")]
    private bool mMoving;
    [Token(Token = "0x4004211")]
    [FieldOffset(Offset = "0x6E")]
    private bool mActorCollideGround;
    [Token(Token = "0x4004212")]
    [FieldOffset(Offset = "0x70")]
    private Vector3 mActorRotation;
    [Token(Token = "0x4004213")]
    [FieldOffset(Offset = "0x7C")]
    private List<float> distanceList;
    [Token(Token = "0x4004214")]
    [FieldOffset(Offset = "0x80")]
    private List<float> timeAtPointList;

    [Token(Token = "0x6004CBE")]
    [Address(RVA = "0x121C780", Offset = "0x121B580", VA = "0x1121C780")]
    protected void StartMove()
    {
    }

    [Token(Token = "0x6004CBF")]
    [Address(RVA = "0x121C4D0", Offset = "0x121B2D0", VA = "0x1121C4D0")]
    private TacticsUnitController GetController() => (TacticsUnitController) null;

    [Token(Token = "0x17000885")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004CC0"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004CC1")]
    [Address(RVA = "0x121C710", Offset = "0x121B510", VA = "0x1121C710", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004CC2")]
    [Address(RVA = "0x121C580", Offset = "0x121B380", VA = "0x1121C580", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CC3")]
    [Address(RVA = "0x121D580", Offset = "0x121C380", VA = "0x1121D580", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CC4")]
    [Address(RVA = "0x121CBB0", Offset = "0x121B9B0", VA = "0x1121CBB0")]
    private bool UpdateMove() => new bool();

    [Token(Token = "0x6004CC5")]
    [Address(RVA = "0x121D780", Offset = "0x121C580", VA = "0x1121D780")]
    public EventAction_MoveActorWithAnime2()
    {
    }

    [Token(Token = "0x2001211")]
    public enum RunTypes
    {
      [Token(Token = "0x4004216")] Time,
      [Token(Token = "0x4004217")] Speed,
    }

    [Token(Token = "0x2001212")]
    public enum AnimeType
    {
      [Token(Token = "0x4004219")] Custom,
      [Token(Token = "0x400421A")] Idel,
    }

    [Token(Token = "0x2001213")]
    public enum PREFIX_PATH
    {
      [Token(Token = "0x400421C")] Demo,
      [Token(Token = "0x400421D")] Movie,
      [Token(Token = "0x400421E")] Default,
    }
  }
}
