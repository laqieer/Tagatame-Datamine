// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveActor2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200120C")]
  [EventActionInfo("New/アクター/移動", "アクターを指定パスに沿って移動させます。", 6702148, 11158596)]
  public class EventAction_MoveActor2 : EventAction
  {
    [Token(Token = "0x40041D2")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x40041D3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HideInInspector]
    private IntVector2[] mPoints;
    [Token(Token = "0x40041D4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public Vector3[] m_WayPoints;
    [Token(Token = "0x40041D5")]
    [FieldOffset(Offset = "0x24")]
    public float Delay;
    [Token(Token = "0x40041D6")]
    [FieldOffset(Offset = "0x28")]
    public bool Async;
    [Token(Token = "0x40041D7")]
    [FieldOffset(Offset = "0x29")]
    public bool GotoRealPosition;
    [Token(Token = "0x40041D8")]
    [FieldOffset(Offset = "0x2A")]
    public bool m_StartActorPos;
    [Token(Token = "0x40041D9")]
    [FieldOffset(Offset = "0x2C")]
    protected TacticsUnitController mController;
    [Token(Token = "0x40041DA")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public float Angle;
    [Token(Token = "0x40041DB")]
    [FieldOffset(Offset = "0x34")]
    [Tooltip("マス目にスナップするか？")]
    public bool MoveSnap;
    [Token(Token = "0x40041DC")]
    [FieldOffset(Offset = "0x35")]
    [Tooltip("地面にスナップするか？")]
    public bool GroundSnap;
    [Token(Token = "0x40041DD")]
    [FieldOffset(Offset = "0x38")]
    [Tooltip("移動速度")]
    public float RunSpeed;
    [Token(Token = "0x40041DE")]
    [FieldOffset(Offset = "0x3C")]
    protected float BackupRunSpeed;
    [Token(Token = "0x40041DF")]
    [FieldOffset(Offset = "0x40")]
    [Tooltip("移動する時に向きを固定化するか")]
    public bool LockRotation;
    [Token(Token = "0x40041E0")]
    [FieldOffset(Offset = "0x41")]
    [Tooltip("移動する時にモーションを固定化するか")]
    public bool LockMotion;
    [Token(Token = "0x40041E1")]
    [FieldOffset(Offset = "0x44")]
    private int mMoveIndex;
    [Token(Token = "0x40041E2")]
    [FieldOffset(Offset = "0x48")]
    protected bool mMoving;
    [Token(Token = "0x40041E3")]
    [FieldOffset(Offset = "0x49")]
    protected bool mFinishMove;
    [Token(Token = "0x40041E4")]
    [FieldOffset(Offset = "0x4A")]
    protected bool mActorCollideGround;
    [Token(Token = "0x40041E5")]
    private const float Approximate = 0.001f;
    [Token(Token = "0x40041E6")]
    [FieldOffset(Offset = "0x4B")]
    protected bool mReady;

    [Token(Token = "0x6004CAD")]
    [Address(RVA = "0x121B980", Offset = "0x121A780", VA = "0x1121B980")]
    protected void StartMove()
    {
    }

    [Token(Token = "0x6004CAE")]
    [Address(RVA = "0x121B780", Offset = "0x121A580", VA = "0x1121B780")]
    private TacticsUnitController GetController() => (TacticsUnitController) null;

    [Token(Token = "0x6004CAF")]
    [Address(RVA = "0x121B830", Offset = "0x121A630", VA = "0x1121B830", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CB0")]
    [Address(RVA = "0x121C290", Offset = "0x121B090", VA = "0x1121C290", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CB1")]
    [Address(RVA = "0x121BC30", Offset = "0x121AA30", VA = "0x1121BC30")]
    protected bool UpdateMove() => new bool();

    [Token(Token = "0x6004CB2")]
    [Address(RVA = "0x121C440", Offset = "0x121B240", VA = "0x1121C440")]
    public EventAction_MoveActor2()
    {
    }
  }
}
