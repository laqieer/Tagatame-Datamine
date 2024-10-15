// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SpawnActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200123F")]
  [EventActionInfo("アクター/配置", "キャラクターを配置します", 6702148, 11158596)]
  public class EventAction_SpawnActor : EventAction
  {
    [Token(Token = "0x400431B")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x400431C")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsUnitID]
    public string UnitID;
    [Token(Token = "0x400431D")]
    [FieldOffset(Offset = "0x20")]
    [StringIsJobID]
    public string JobID;
    [Token(Token = "0x400431E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private IntVector2 Position;
    [Token(Token = "0x400431F")]
    [FieldOffset(Offset = "0x2C")]
    private TacticsUnitController mController;
    [Token(Token = "0x4004320")]
    [FieldOffset(Offset = "0x30")]
    public bool Persistent;
    [Token(Token = "0x4004321")]
    [FieldOffset(Offset = "0x34")]
    [Range(0.0f, 359f)]
    public int Angle;
    [Token(Token = "0x4004322")]
    [FieldOffset(Offset = "0x38")]
    public bool ShowEquipments;
    [Token(Token = "0x4004323")]
    [FieldOffset(Offset = "0x3C")]
    public TacticsUnitController.PostureTypes Posture;

    [Token(Token = "0x6004D49")]
    [Address(RVA = "0x12307C0", Offset = "0x122F5C0", VA = "0x112307C0")]
    private GameObject GetPersistentScene() => (GameObject) null;

    [Token(Token = "0x1700089D")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D4A"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D4B")]
    [Address(RVA = "0x1230A90", Offset = "0x122F890", VA = "0x11230A90", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D4C")]
    [Address(RVA = "0x1230870", Offset = "0x122F670", VA = "0x11230870", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D4D")]
    [Address(RVA = "0x12309F0", Offset = "0x122F7F0", VA = "0x112309F0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004D4E")]
    [Address(RVA = "0x1230B00", Offset = "0x122F900", VA = "0x11230B00")]
    public EventAction_SpawnActor()
    {
    }
  }
}
