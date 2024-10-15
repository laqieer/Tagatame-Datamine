// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200120B")]
  [EventActionInfo("アクター/移動", "アクターを指定パスに沿って移動させます。", 6702148, 11158596)]
  public class EventAction_MoveActor : EventAction
  {
    [Token(Token = "0x40041C9")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x40041CA")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    [SerializeField]
    private IntVector2[] mPoints;
    [Token(Token = "0x40041CB")]
    [FieldOffset(Offset = "0x20")]
    public float Delay;
    [Token(Token = "0x40041CC")]
    [FieldOffset(Offset = "0x24")]
    public bool Async;
    [Token(Token = "0x40041CD")]
    [FieldOffset(Offset = "0x25")]
    public bool GotoRealPosition;
    [Token(Token = "0x40041CE")]
    [FieldOffset(Offset = "0x28")]
    private TacticsUnitController mController;
    [Token(Token = "0x40041CF")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public float Angle;
    [Token(Token = "0x40041D0")]
    [FieldOffset(Offset = "0x30")]
    private bool mMoving;
    [Token(Token = "0x40041D1")]
    [FieldOffset(Offset = "0x31")]
    private bool mReady;

    [Token(Token = "0x6004CA7")]
    [Address(RVA = "0x121DE70", Offset = "0x121CC70", VA = "0x1121DE70")]
    private void StartMove()
    {
    }

    [Token(Token = "0x6004CA8")]
    [Address(RVA = "0x121DBF0", Offset = "0x121C9F0", VA = "0x1121DBF0")]
    private TacticsUnitController GetController() => (TacticsUnitController) null;

    [Token(Token = "0x6004CA9")]
    [Address(RVA = "0x121DDD0", Offset = "0x121CBD0", VA = "0x1121DDD0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CAA")]
    [Address(RVA = "0x121E130", Offset = "0x121CF30", VA = "0x1121E130", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CAB")]
    [Address(RVA = "0x121DCA0", Offset = "0x121CAA0", VA = "0x1121DCA0", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004CAC")]
    [Address(RVA = "0x121E290", Offset = "0x121D090", VA = "0x1121E290")]
    public EventAction_MoveActor()
    {
    }
  }
}
